using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class OrderModel
    {
        public OrderDto Order { get; set; }
        public List<MotoDto> MotoList { get; set; }
    }
}