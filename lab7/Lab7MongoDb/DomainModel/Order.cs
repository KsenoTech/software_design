namespace DomainModel
{
    using System;
    using System.Collections.Generic;

    public partial class Order
    {
        public Order()
        {
            Phones = new HashSet<Phone>();
        }

        public int Id { get; set; }

        public string Address { get; set; }

        public decimal? Total { get; set; }

        public string Customer { get; set; }

        public DateTime? Date { get; set; }

        public string PhoneNumber { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }
    }
}
