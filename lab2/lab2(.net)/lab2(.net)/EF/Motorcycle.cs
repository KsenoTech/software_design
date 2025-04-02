namespace lab2_.net_.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Motorcycle")]
    public partial class Motorcycle
    {
        [Required]
        [StringLength(50)]
        public string Brand_name { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Required]
        [StringLength(50)]
        public string Color { get; set; }

        public bool HaveInStore { get; set; }

        [Key]
        public int id_Motorcycle { get; set; }

        public int Cost { get; set; }

        public int id_Type_FK { get; set; }

        public virtual Type Type { get; set; }
    }
}
