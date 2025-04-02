using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel
{
    // [Table("Motorcycle")]
    //[BsonIgnoreExtraElements]
    public partial class Motorcycle // объекты доменной модели, копия сущности в бд
    {
        //[BsonId]
        //public ObjectId _id { get; set; }

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
        //[BsonId]
        public int Id { get; set; }

        public int Cost { get; set; }

        public int? id_Type_FK { get; set; }

        public virtual Type Type { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
