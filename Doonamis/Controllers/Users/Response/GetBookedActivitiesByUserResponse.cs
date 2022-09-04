using System;
using DoonamisSPI.Data.Entities;

namespace Doonamis.Controllers.Users.Response
{
    public class GetBookedActivitiesByUserResponse
    {
        public IEnumerable<Activity> Activities { get; set; }
    }
}

