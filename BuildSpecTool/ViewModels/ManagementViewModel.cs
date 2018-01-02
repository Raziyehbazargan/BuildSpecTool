﻿using BuildSpecTool.Models;
using BuildSpecTool.Models.ReferenceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSpecTool.ViewModels
{
    public class ManagementViewModel
    {
        public Component Component { get; set; }
        public AttendeeTypeViewModel AttendeeTypeViewModel { get; set; }
        public Status Status { get; set; }
        public Mail Mail { get; set; }

        public ManagementViewModel()
        {
            Component = new Component();
            AttendeeTypeViewModel = new AttendeeTypeViewModel();
            Status = new Status();
            Mail = new Mail();
        }
 
    }
}