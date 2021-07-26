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
using System.Threading.Tasks;

namespace BlazorBattles.Server.Controllers
{
    [Authorize]
    public class UserUnitController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly IUtilityService _utilityService;

        public UserUnitController(DataContext context, IUtilityService utilityService)
        {
            _context = context;
            _utilityService = utilityService;
        }

        [HttpPost("revive")]
        public async Task<IActionResult> ReviveArmy()
        {
            var user = await _utilityService.GetUser();
            var userUnits = await _context.UserUnits
                .Where(x => x.UserId == user.Id)
                .Include(x => x.Unit)
                .ToListAsync();

            int goldCost = 1000;

            if (user.Gold < goldCost)
            {
                return BadRequest("Not enough gold. You will need 1000 gold to revive your army.");
            }

            user.Gold -= goldCost;

            bool armyAlreadyAlive = true;
            foreach (var userUnit in userUnits)
            {
                if (userUnit.HitPoints <= 0)
                {
                    armyAlreadyAlive = false;
                    userUnit.HitPoints = new Random().Next(0, userUnit.Unit.HitPoints);
                }
            }

            if (armyAlreadyAlive)
                return Ok("Army already alive.");

            user.Gold -= goldCost;

            await _context.SaveChangesAsync();

            return Ok("Army revivied");
        }

        [HttpPost]
        public async Task<IActionResult> BuildUserUnit([FromBody] int unitId)
        {
            var unit = await _context.Units.FirstOrDefaultAsync<Unit>(x => x.Id == unitId);
            var user = await _utilityService.GetUser();
            if (user.Gold < unit.GoldCost)
            {
                return BadRequest("Not enough gold!");
            }

            user.Gold -= unit.GoldCost;
            var newUserUnit = new UserUnit
            {
                UnitId = unit.Id,
                UserId = user.Id,
                HitPoints = unit.HitPoints
            };

            _context.UserUnits.Add(newUserUnit);
            await _context.SaveChangesAsync();
            return Ok(newUserUnit);
        }

        [HttpGet]
        public async Task<IActionResult> GetUserUnits()
        {
            var user = await _utilityService.GetUser();
            var userUnits = await _context.UserUnits.Where(x => x.UserId == user.Id).ToListAsync();
            var response = userUnits.Select(
                unit => new UserUnitResponse
                {
                    UnitId = unit.UserId,
                    HitPoints = unit.HitPoints
                });
            return Ok(response);
        }
    }
}
