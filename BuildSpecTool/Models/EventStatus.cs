using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSpecTool.Models.ReferenceModels
{
    public class EventStatus
    {
        public int Id { get; set; }

        public int EventId { get; set; } //foreign key

        public byte StatusId { get; set; } //foreign key

        public IEnumerable<Status> StatusList { get; set; }

        public bool UsedInEvent { get; set; }

        public bool IsInvitation { get; set; }

        public string Description { get; set; }
    }
}