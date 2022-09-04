using System;
using DoonamisSPI.Data.Entities;

namespace DoonamisSPI.Controllers.Activities.Responses
{
    public class GetActivitiesResponse
    {
        public IEnumerable<Activity> Activities { get; set; }
    }
}

