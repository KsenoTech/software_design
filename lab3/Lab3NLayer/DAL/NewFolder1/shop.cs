using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.NewFolder1
{
    public partial class shop : DbContext
    {
        public shop()
            : base("name=shop")
        {
        }

        public virtual DbSet<Motorcycle> Motorcycles { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(e => e.Motorcycles)
                .WithMany(e => e.Orders)
                .Map(m => m.ToTable("MotoOrder").MapLeftKey("OrderID").MapRightKey("MotoID"));

            modelBuilder.Entity<Type>()
                .HasMany(e => e.Motorcycle)
                .WithOptional(e => e.Type)
                .HasForeignKey(e => e.id_Type_FK);
        }
    }
}
