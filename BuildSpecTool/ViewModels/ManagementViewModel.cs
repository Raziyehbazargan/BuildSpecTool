using BuildSpecTool.Models;
using BuildSpecTool.Models.ReferenceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSpecTool.ViewModels
{
    public class ManagementViewModel
    {
        public Event Event { get; set; }
        public Component Component { get; set; }

        public EventAttendeeType EventAttendeeType { get; set; }

        public EventStatus EventStatus { get; set; }

        public EventPage EventPage { get; set; }

        public EventMail EventMail { get; set; }

        public ManagementViewModel()
        {
            Component = new Component();
            EventAttendeeType = new EventAttendeeType();
            EventStatus = new EventStatus();
            EventPage = new EventPage();
            EventMail = new EventMail();
            Event = new Event();
        }
    }
}