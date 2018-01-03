using BuildSpecTool.Models.ReferenceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSpecTool.Models
{
    public class EventMail
    {
        public int Id { get; set; }  

        public byte MailId { get; set; }

        public int EventId { get; set; }

        public Event Event { get; set; }

        public bool IsBlast { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public IEnumerable<Mail> MailList { get; set; }

        public Mail Mail { get; set; }
    }
}