using System;
using Doonamis.Controllers.Activities.Request;
using DoonamisSPI.Controllers.Activities.Responses;
using DoonamisSPI.Controllers.Authentication;
using DoonamisSPI.Controllers.Authentication.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoonamisSPI.Controllers.Activities
{
    [ApiController]
    [Route("api")]
    public class ActivityController : ControllerBase
    {
        private readonly ILogger<ActivityController> logger;

        public ActivityController(ILogger<ActivityController> logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets a list of all the activities
        /// </summary>
        /// <returns>List of activities</returns>
        [HttpGet("activities")]
        public async Task<IActionResult> GetActivities([FromQuery] string category, string distance)
        {
            return Ok(new GetActivitiesResponse());
        }

        /// <summary>
        /// Gets an activity by id
        /// </summary>
        /// <returns>Activity information</returns>
        [HttpGet("activities/{id}")]
        public async Task<IActionResult> GetActivityById([FromRoute] int id)
        {
            return Ok(new GetActivityByIdResponse());
        }

        /// <summary>
        /// Books an activity
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet("activities/{id}/book")]
        public async Task<IActionResult> BookActivity([FromRoute] int id, [FromQuery] DateTime date)
        {
            return Ok();
        }

        /// <summary>
        /// Rank an activity
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpPut("activities/{id}/rank")]
        public async Task<IActionResult> RankActivity([FromRoute] int id, RankRequest rank)
        {
            return Ok();
        }

        /// <summary>
        /// Comment an activity
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpPost("activities/{id}/comment")]
        public async Task<IActionResult> CommentActivity([FromRoute] int id, CommentRequest comment)
        {
            return Ok();
        }
    }
}

