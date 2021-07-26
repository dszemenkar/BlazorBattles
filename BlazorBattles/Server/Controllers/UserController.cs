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
    }
}
