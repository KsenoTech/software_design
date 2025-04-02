namespace DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Motorcycle")]
    public partial class Motorcycle // объекты доменной модели, копия сущности в бд
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Motorcycle()
        {
            Orders = new HashSet<Order>();
        }


        [Required]
        [StringLength(50)]
        public string Brand_name { get; set; }
        [Required]
        [StringLength(50)]
        public string Model_name { get; set; }
        [StringLength(50)]
        public string Color { get; set; }

        public bool HaveInStore { get; set; }
        [Key]
        public int Id { get; set; }

        public int Cost { get; set; }

        public int? id_Type_FK { get; set; }

        public virtual Type Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
