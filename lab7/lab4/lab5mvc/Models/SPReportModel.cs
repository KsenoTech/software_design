using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab5mvc.Models
{
    public class SPReportModel
    {
        public List<sqlzaprosLAB1> ReportSQLData { get; set; }
        public int SelectedMonth { get; set; }
        public int SelectedYear { get; set; }
    }
}