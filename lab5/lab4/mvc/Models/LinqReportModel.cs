using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class LinqReportModel
    {
        public List<ReportSQLData> ReportSQLData { get; set; }
        public List<TypeDto> TypeList { get; set; }
        public int SelectedTypeId { get; set; }
    }
}