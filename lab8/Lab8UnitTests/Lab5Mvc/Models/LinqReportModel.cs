using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab5AspnetMVC.Models
{
    public class LinqReportModel
    {
        public List<ReportData> ReportData { get; set; }
        public List<ManufacturerDto> ManufList { get; set; }
        public int SelectedManufId { get; set; }
    }
}