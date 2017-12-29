using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSpecTool.Models
{
    public class Component
    {
        public int Id { get; set; }

        public int EventId { get; set; } //foreign key
        public Event Event { get; set; }

        public bool InvitationUpload { get; set; }

        public bool DynamicAgenda { get; set; }

        public bool RSVPCodes { get; set; }

        public bool Session { get; set; }

        public bool HasHotel { get; set; }

        public bool ApprovalTool { get; set; }

        public bool OnsiteTool { get; set; }

        public bool OverallEvals { get; set; }

        public bool SessionEvals { get; set; }

        public bool Search_Engine { get; set; }

        public bool SpeakerInformation { get; set; }

        public bool AgendaFilter { get; set; }

        public bool AgendaSessionsSignup { get; set; }

        public bool Progress_bar { get; set; }

    }
}