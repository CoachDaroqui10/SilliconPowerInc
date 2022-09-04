using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoonamisSPI.Controllers.Authentication.Requests;
using Doonamis.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Doonamis.Services;

namespace DoonamisSPI.Controllers.Authentication
{
    [ApiController]
    [Route("api")]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILogger<AuthenticationController> logger;
        private readonly IAuthenticationService authenticationService;

        public AuthenticationController(
            ILogger<AuthenticationController> logger,
            IAuthenticationService authenticationService)
        {
            this.logger = logger;
            this.authenticationService = authenticationService;
        }

        /// <summary>
        /// Registers a user in the application
        /// </summary>
        /// <returns></returns>
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            //Check if request is correct
            if (!ModelState.IsValid)
            {
                return BadRequest("Incorrect register request");
            }

            try
            {
                authenticationService.Register(request);
                return Ok(new { message = "User registered" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        /// <summary>
        /// Logs a user into the application
        /// </summary>
        /// <returns></returns>
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            return Ok(new
            {
                token = "AuthToken"
            });
        }
    }
}
