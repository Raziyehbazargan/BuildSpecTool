using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSpecTool.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsMicrosoftEvent { get; set; }

        public bool IsMicrosoftInternal { get; set; }

        public string URL { get; set; }

        public string Alias { get; set; }

        public int EstimatedAttendance { get; set; }

        public string Registration_Lead { get; set; }

        public string Technical_Lead { get; set; }

        public string TimeFormat { get; set; }

        public string DateFormat { get; set; }

        public DateTime Actual_EventDate { get; set; }

        public DateTime Live_EventDate { get; set; }

        public DateTime BuildDueDate { get; set; }

        public DateTime ClientReviewDueDate { get; set; }

        public DateTime ClientEditDueDate { get; set; }

        public string Phone { get; set; }

        public byte TeamId { get; set; } //foreign key

        public int ClientId { get; set; } //foreign key

        public EventComponent EventComponent { get; set; }
    }
}