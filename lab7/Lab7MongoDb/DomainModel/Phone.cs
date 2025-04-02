namespace DomainModel
{

    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Phone
    {
        public Phone()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public decimal Cost { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public int ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer1 { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
