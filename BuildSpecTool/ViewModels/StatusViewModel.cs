using BuildSpecTool.Models.ReferenceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSpecTool.ViewModels
{
    public class StatusViewModel
    {
        public IEnumerable<Status> RefStatus { get; set; }
        public IEnumerable<EventStatus> EventStatusList { get; set; }
        public EventStatus EventStatus { get; set; }
    }
}