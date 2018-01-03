using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BuildSpecTool.Models
{
    public class Component
    {
        public int Id { get; set; }

        public int EventId { get; set; } //foreign key

        [Display(Name = "Invitation Upload")]
        public bool InvitationUpload { get; set; }

        [Display(Name = "Dynamic Agenda")]
        public bool DynamicAgenda { get; set; }

        [Display(Name = "RSVP Codes")]
        public bool RSVPCodes { get; set; }

        [Display(Name = "Registration Session")]
        public bool Session { get; set; }

        [Display(Name = "Hotel")]
        public bool HasHotel { get; set; }

        [Display(Name = "Approval Tool")]
        public bool ApprovalTool { get; set; }

        [Display(Name = "Onsite Tool")]
        public bool OnsiteTool { get; set; }

        [Display(Name = "Overall Evals")]
        public bool OverallEvals { get; set; }

        [Display(Name = "Session Evals")]
        public bool SessionEvals { get; set; }

        [Display(Name = "Search Engine")]
        public bool Search_Engine { get; set; }

        [Display(Name = "Speaker Information")]
        public bool SpeakerInformation { get; set; }

        [Display(Name = "Agenda Filter")]
        public bool AgendaFilter { get; set; }

        [Display(Name = "Agenda Sessions")]
        public bool AgendaSessionsSignup { get; set; }

        [Display(Name = "Progress Bar")]
        public bool Progress_bar { get; set; }

    }
}