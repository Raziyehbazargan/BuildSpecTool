using BuildSpecTool.Models.ReferenceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSpecTool.Models
{
    public class EventPage
    {
        public byte Id { get; set; }
        public byte SitePageId { get; set; }
        public int EventId { get; set; }
        public IEnumerable<SitePage> SitePageList { get; set; }
        public bool IsInNav { get; set; }
        public string Description { get; set; }
    }
}