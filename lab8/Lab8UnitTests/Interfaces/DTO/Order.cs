using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public decimal? Total { get; set; }

        public string Customer { get; set; }

        public DateTime? Date { get; set; }

        public string OrderedPhones { get; set; }
        public List<int> OrderedPhonesIds { get; set; }

        public OrderDto() { }
        public OrderDto(Order o) {
            Id = o.Id;
            PhoneNumber = o.PhoneNumber;
            Address = o.Address;
            Customer = o.Customer;
            Total = o.Total;
            Date = o.Date;
            OrderedPhones = String.Join(",",o.Phones.Select(i => i.Name).ToList());
            OrderedPhonesIds = o.Phones.Select(i => i.Id).ToList();
        }
    }
}
