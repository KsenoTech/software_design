using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DomainModel
{
    //[BsonIgnoreExtraElements]
    public partial class Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Type()
        {
            Motorcycle = new HashSet<Motorcycle>();
        }
        //[BsonId]
        //public ObjectId _id { get; set; }

        [Key]
        //[BsonId]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Motorcycle> Motorcycle { get; set; }
    }
}
