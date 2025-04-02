using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace lab2_.net_.EF
{
    public partial class MotosContext : DbContext
    {
        public MotosContext()
            : base("name=DbConnection")
        {
        }

        public virtual DbSet<Motorcycle> Motorcycle { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Type> Type { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Motorcycle>()
                .Property(e => e.Cost);
                //.IsFixedLength();

            modelBuilder.Entity<Type>()
                .HasMany(e => e.Motorcycle)
                .WithOptional(e => e.Type)
                .HasForeignKey(e => e.id_Type_FK);
        }
    }
}
