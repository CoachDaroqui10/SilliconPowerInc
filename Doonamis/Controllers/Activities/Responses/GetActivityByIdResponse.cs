using System;
namespace DoonamisSPI.Controllers.Activities.Responses
{
    public class GetActivityByIdResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public float Rank { get; set; }
        public string Location { get; set; }
        public IEnumerable<DateTime> Availability { get; set; }
        public IEnumerable<string> Comments { get; set; }
    }
}

