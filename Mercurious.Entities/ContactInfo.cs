using Mercurius.Entities.Enums;
using Mercurius.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mercurius.Entities
{
    public class ContactInfo : IEntity
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }

        [MaxLength(2)]
        public string State { get; set; }   
        
        CountryEnum Country { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public ContactTypeEnum Type { get; set; }
        public string Notes { get; set; }

        [ForeignKey("Vendor")]
        public int? VendorId { get; set; }
        public Vendor Vendor { get; set; }

        [ForeignKey("Person")]
        public int? PersonId { get; set; }
        public Person Person { get; set; }
    }
}
