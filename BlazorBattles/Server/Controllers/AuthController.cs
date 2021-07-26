﻿using BlazorBattles.Server.Interfaces;
using BlazorBattles.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattles.Server.Controllers
{
    public class AuthController : BaseApiController
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegister request)
        {
            var response = await _authRepo.Register(
                new AppUser
                {
                    Username = request.Username,
                    Email = request.Email,
                    Gold = request.Gold,
                    DateOfBirth = request.DateOfBirth,
                    IsConfirmed = request.IsConfirmed
                }, 
                request.Password,
                request.StartUnitId);
            
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLogin request)
        {
            var response = await _authRepo.Login(
                request.Email, request.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
