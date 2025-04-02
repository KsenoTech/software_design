using DomainModel;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using Type = DomainModel.Type;

namespace DAL
{
    public partial class ShopContext : DbContext
    {
        public ShopContext()
            : base("name=shop")
        {
        }

        public virtual DbSet<Motorcycle> Motorcycles { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Type>().ToTable("Type");
            modelBuilder.Entity<Motorcycle>().ToTable("Motorcycle");
            modelBuilder.Entity<Order>().ToTable("Order");
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
