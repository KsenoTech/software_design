using DomainModel;
using System.Data.Entity;

namespace DAL
{

    public partial class PhonesContext : DbContext
    {
        public PhonesContext()
            : base("MongoDb")
        {
        }

        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>().ToTable("Manufacturer");
            modelBuilder.Entity<Phone>().ToTable("Phone");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Phone)
                .WithRequired(e => e.Manufacturer1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Phones)
                .WithMany(e => e.Orders)
                .Map(m => m.ToTable("PhoneOrder").MapLeftKey("OrderId").MapRightKey("PhoneId"));
        }
    }
}
