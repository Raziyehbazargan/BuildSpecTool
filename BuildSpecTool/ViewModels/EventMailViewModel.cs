using BuildSpecTool.Models;
using BuildSpecTool.Models.ReferenceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSpecTool.ViewModels
{
    public class EventMailViewModel
    {
        public IEnumerable<Mail> RefMails { get; set; }
        public IEnumerable<EventMail> EventMailList { get; set; }
        public EventMail EventMail { get; set; }
    }
}