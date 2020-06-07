using System;

namespace Mercurius.Entities
{
    public class Customer : Person
    {
        public string CustomerNumber { get; set; }
        public DateTime FirstActivityDate { get; set; }
        public bool ClubMember { get; set; }
        public DateTime ClubMemberEffectiveDate { get; set; }
        public DateTime ClubMemberCancelationDate { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
    }
}
