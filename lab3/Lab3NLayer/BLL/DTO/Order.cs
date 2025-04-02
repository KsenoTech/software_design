using System;
using DAL.NewFolder1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class Orders
    {
        public int ID { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }

        public int? Total { get; set; }

        public string Customer { get; set; }

        public DateTime? Date { get; set; }

        public string OrderedMotos { get; set; }
        public List<int> OrderedMotosIDs { get; set; }

        public Orders() { }
        public Orders(Order o)
        {
            ID = o.ID;
            PhoneNumber = o.PhoneNumber;
            Adress = o.Adress;
            Customer = o.Customer;
            Total = o.Total;
            Date = o.Date;
            OrderedMotos = string.Join(",", o.Motorcycles.Select(i => i.Brand_name).ToList());
            OrderedMotosIDs = o.Motorcycles.Select(i => i.Id).ToList();
        }
    }
}
