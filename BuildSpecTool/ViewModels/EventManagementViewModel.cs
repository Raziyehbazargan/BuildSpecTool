using BuildSpecTool.Models;
using BuildSpecTool.Models.ReferenceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSpecTool.ViewModels
{
    public class EventManagementViewModel
    {
        public Event Event { get; set; }
        public Component Component { get; set; }

        public EventAttendeeType EventAttendeeType { get; set; }

        public EventStatus EventStatus { get; set; }

        public EventPage EventPage { get; set; }

        public EventMail EventMail { get; set; }

        public EventManagementViewModel(int id)
        {
            Component = new Component { EventId = id};
            EventAttendeeType = new EventAttendeeType { EventId = id };
            EventStatus = new EventStatus { EventId = id };
            EventPage = new EventPage { EventId = id };
            EventMail = new EventMail { EventId = id };
            Event = new Event { Id = id };
        }
    }
}