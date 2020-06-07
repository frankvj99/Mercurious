using Microsoft.EntityFrameworkCore;
using Mercurius.Entities;

namespace Mercurius.DataAccess
{
    public class MercuriusContext : DbContext
    {
        public MercuriusContext(DbContextOptions<MercuriusContext> options)
            :base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<ContactInfo> ContactInfoList { get; set; }
        //public DbSet<PersonContactInfo> PersonContactInfoList { get; set; }
        //public DbSet<VendorContactInfo> VendorContactInfoList { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrderProduct>(o =>
                o.HasKey("OrderId", "ProductId")            
            );
            //builder.Entity<PersonContactInfo>(o =>
            //    o.HasKey("PersonId", "ContactInfoId")
            //);
            //builder.Entity<VendorContactInfo>(o =>
            //    o.HasKey("VendorId", "ContactInfoId")
            //);
        }
    }
}
