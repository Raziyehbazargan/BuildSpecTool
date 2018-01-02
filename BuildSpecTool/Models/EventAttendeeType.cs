using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSpecTool.Models
{
    public class EventAttendeeType
    {
        public int Id { get; set; }

        public int EventId { get; set; } //foreign key

        public Event Event { get; set; }

        public byte AttendeeTypeId { get; set; } //foreign key

        public IEnumerable<AttendeeType> AttendeeTypes { get; set; }

        public bool Invited { get; set; }

        public bool HasRSVP { get; set; }

        public int Capacity { get; set; }

        public string Description { get; set; }
    }
}