using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab5AspnetMVC.Models
{
    public class OrderModel
    {
        public OrderDto Order { get; set; }
        public List<PhoneDto> PhoneList { get; set; }
    }
}