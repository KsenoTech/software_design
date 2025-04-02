using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrdersByMonth
    {
        public string Customer { get; set; }
        public string Phones { get; set; }
        public DateTime Date { get; set; }
    }

    public class ReportData
    {
        public string PhoneName { get; set; }
        public decimal Cost { get; set; }
    }
}
