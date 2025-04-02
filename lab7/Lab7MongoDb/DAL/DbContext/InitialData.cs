using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DbContexts
{
    public static class InitialData
    {
        public static IList<Manufacturer> ManufacturerList => new List<Manufacturer>
        {
                new Manufacturer() { Id=1, Name = "Sony" },
                new Manufacturer() { Id=2, Name = "Samsung" },
                new Manufacturer() { Id=3, Name = "Xaiomi" },
                new Manufacturer() { Id=4, Name = "Apple" }
        };
    }
}
