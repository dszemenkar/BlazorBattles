using BlazorBattles.Server.Data;
using BlazorBattles.Server.Interfaces;
using BlazorBattles.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorBattles.Server.Controllers
{
    [Authorize]
    public class UserController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly IUtilityService _utilityService;

        public UserController(DataContext context, IUtilityService utilityService)
        {
            _context = context;
            _utilityService = utilityService;
        }



        [HttpGet("getgold")]
        public async Task<IActionResult> GetGold()
        {
            var user = await _utilityService.GetUser();
            return Ok(user.Gold);
        }

        [HttpPut("addgold")]
        public async Task<IActionResult> AddGold([FromBody]int gold)
        {
            var user = await _utilityService.GetUser();
            user.Gold += gold;

            await _context.SaveChangesAsync();
            return Ok(user.Gold);
        }

        [HttpGet("leaderboard")]
        public async Task<IActionResult> GetLeaderboard()
        {
            var users = await _context.AppUsers.Where(x => !x.IsDeleted && x.IsConfirmed).ToListAsync();
            users = users.OrderByDescending(x => x.Victories)
                            .ThenBy(x => x.Defeats)
                            .ThenBy(x => x.DateCreated)
                            .ToList();
            int rank = 1;
            var response = users.Select(x => new UserStatistics
            {
                Rank = rank++,
                UserId = x.Id,
                Username = x.Username,
                Battles = x.Battles,
                Victories = x.Victories,
                Defeats = x.Defeats
            });

            return Ok(response);
        }

        [HttpGet("history")]
        public async Task<IActionResult> GetHistory()
        {
            var user = await _utilityService.GetUser();
            var battles = await _context.Battles
                .Where(x => x.AttackerId == user.Id || x.OpponentId == user.Id)
                .Include(x => x.Attacker)
                .Include(x => x.Opponent)
                .Include(x => x.Winner)
                .ToListAsync();
            var history = battles.Select(x => new BattleHistoryEntry
            {
                BattleId = x.Id,
                BattleDate = x.BattleDate,
                AttackerId = x.AttackerId,
                OpponentId = x.OpponentId,
                AttackerName = x.Attacker.Username,
                OpponentName = x.Opponent.Username,
                YouWon = x.WinnerId == user.Id,
                RoundsFought = x.RoundsFought,
                WinnerDamageDealt = x.WinnerDamage
            });

            return Ok(history.OrderByDescending(x => x.BattleDate));
        }
    }
}
