using Mercurius.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mercurius.Entities
{
    public class Product : IEntity
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }
        public int Id { get; set; }
        public string ProductNum { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DateActivated { get; set; }

        [ForeignKey("Vendor")]
        public int SourceVendorId { get; set; }
        public Vendor Vendor { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
