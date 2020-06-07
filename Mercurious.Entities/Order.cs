using Mercurius.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mercurius.Entities
{
    public class Order : IEntity
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
