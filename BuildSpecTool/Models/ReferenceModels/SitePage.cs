using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSpecTool.Models.ReferenceModels
{
    public class SitePage
    {
        public byte Id { get; set; }

        public string Name { get; set; }

        public string  Type { get; set; }

        public string Path { get; set; }
    }
}