using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mercurius.Entities
{
    public class OrderProduct
    {
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        [ForeignKey("Product")]      
        public int ProductId { get; set; }                
        public Product Product { get; set; }
    }
}
