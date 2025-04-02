using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab5AspnetMVC.Models
{
    public class SPReportModel
    {
        public List<OrdersByMonth> ReportData { get; set; }
        public int SelectedMonth { get; set; }
        public int SelectedYear { get; set; }
    }
}