using BuildSpecTool.Models.ReferenceModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BuildSpecTool.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Microsoft Event")]
        public bool IsMicrosoftEvent { get; set; }

        [Display(Name = "Internal Event")]
        public bool IsMicrosoftInternal { get; set; }

        public string URL { get; set; }

        public string Alias { get; set; }

        [Display(Name = "Estimated Attendance")]
        public int EstimatedAttendance { get; set; }

        [Display(Name = "Registration Lead")]
        public string Registration_Lead { get; set; }

        [Display(Name = "Technical Lead")]
        public string Technical_Lead { get; set; }

        [Display(Name = "Time Format")]
        public string TimeFormat { get; set; }

        [Display(Name = "Date Format")]
        public string DateFormat { get; set; }

        [Display(Name = "Event Date")]
        public DateTime Actual_EventDate { get; set; }

        [Display(Name = "Live Date")]
        public DateTime Live_EventDate { get; set; }

        [Display(Name = "Build Due")]
        public DateTime BuildDueDate { get; set; }

        [Display(Name = "Client Review")]
        public DateTime ClientReviewDueDate { get; set; }

        [Display(Name = "Client Edit")]
        public DateTime ClientEditDueDate { get; set; }

        public string Phone { get; set; }

        public byte TeamId { get; set; } //foreign key

        public int ClientId { get; set; } //foreign key

        public Team Team { get; set; }

        public Client Client { get; set; }
    }
}