using System;
using System.Collections.Generic;
using Mercurius.Entities.Interfaces;

namespace Mercurius.Entities
{
    public class Vendor : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public DateTime VendorEffectiveDate { get; set; }
        public bool IsActive { get; set; }
        //public IEnumerable<VendorContactInfo> VendorContactInfoList { get; set; }

    }
}
