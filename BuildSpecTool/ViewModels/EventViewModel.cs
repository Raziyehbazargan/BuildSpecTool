using BuildSpecTool.Models;
using BuildSpecTool.Models.ReferenceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSpecTool.ViewModels
{
    public class EventViewModel
    {
        public IEnumerable<Client> Clients { get; set; }

        public IEnumerable<Team> Teams { get; set; }

        public Event Event { get; set; }
    }
}