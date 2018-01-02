using BuildSpecTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSpecTool.ViewModels
{
    public class AttendeeTypeViewModel
    {
        public IEnumerable<AttendeeType> AttendeeTypes { get; set; }
        public IEnumerable<EventAttendeeType> EventAttendeeTypes { get; set; }
        public EventAttendeeType EventAttendeeType { get; set; }
    }
}