namespace DomainModel
{
    using System;
    using System.Collections.Generic;
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Motorcycles = new HashSet<Motorcycle>();
        }

        public int ID { get; set; }

        public string Adress { get; set; }

        public string Customer { get; set; }

        public string PhoneNumber { get; set; }

        public int? Total { get; set; }

        public DateTime? Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Motorcycle> Motorcycles { get; set; }
    }
}
