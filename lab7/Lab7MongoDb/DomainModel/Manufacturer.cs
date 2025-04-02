namespace DomainModel
{
    using System;
    using System.Collections.Generic;

    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Phone = new HashSet<Phone>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Phone> Phone { get; set; }
    }
}
