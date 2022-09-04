using System;
using Doonamis.Controllers.Users.Response;
using DoonamisSPI.Controllers.Activities;
using DoonamisSPI.Controllers.Activities.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Doonamis.Controllers.Users
{
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> logger;

        public UserController(ILogger<UserController> logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Get the user information
        /// </summary>
        /// <returns>List of activities</returns>
        [HttpGet("users/{id}")]
        public async Task<IActionResult> GetUser([FromRoute] int id)
        {
            return Ok(new GetUserResponse());
        }

        /// <summary>
        /// Update user's information
        /// </summary>
        /// <returns>List of activities</returns>
        [HttpPut("users/{id}")]
        public async Task<IActionResult> UpdateUser([FromRoute] int id)
        {
            return Ok(new UpdateUserResponse());
        }

        /// <summary>
        /// Update user's information
        /// </summary>
        /// <returns>List of activities</returns>
        [HttpGet("users/{id}/activities")]
        public async Task<IActionResult> GetBookedActivitiesByUser([FromRoute] int id)
        {
            return Ok(new GetBookedActivitiesByUserResponse());
        }
    }
}

