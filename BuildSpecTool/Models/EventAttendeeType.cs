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

        public byte AttendeeTypeId { get; set; } //foreign key

        public AttendeeType AttendeeType { get; set; }

        public bool Invited { get; set; }

        public bool HasRSVP { get; set; }

        public int Capacity { get; set; }

        public string Description { get; set; }
    }
}