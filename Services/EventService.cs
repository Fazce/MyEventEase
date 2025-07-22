using System;
using System.Collections.Generic;

namespace MyEventEase.Services
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Location { get; set; } = string.Empty;
    }

    public class EventService
    {
        public List<Event> GetEvents() => new()
        {
            new Event { Id = 1, Name = "Annual Gala", Date = new DateTime(2024, 10, 15), Location = "Grand Ballroom, City Hotel" },
            new Event { Id = 2, Name = "Tech Conference", Date = new DateTime(2024, 11, 5), Location = "Convention Center" },
            new Event { Id = 3, Name = "Holiday Mixer", Date = new DateTime(2024, 12, 20), Location = "Downtown Rooftop" }
        };
    }
}