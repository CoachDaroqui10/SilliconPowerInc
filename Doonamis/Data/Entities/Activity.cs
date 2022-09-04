using System;
namespace DoonamisSPI.Data.Entities
{
    public class Activity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public string Location { get; set; }
        public float Rank { get; set; }
        public IEnumerable<DateTime> Availability { get; set; }
    }
}

