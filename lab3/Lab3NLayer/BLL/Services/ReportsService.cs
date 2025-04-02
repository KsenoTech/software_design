using DAL;
using DAL.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class ReportsService
    {
        public class OrdersByMonth
        {
            public string Customer { get; set; }
            public string Motos { get; set; }
            public DateTime Date { get; set; }
        }
        public class SPResult
        {
            //public string Customer { get; set; }
            //public string Brand_Name { get; set; }
            //public DateTime Date { get; set; }
            public string Brand_name { get; set; }
            public string Model_name { get; set; }
            public int Cost { get; set; }
            //public bool HaveInStore { get; set; }
            public int Credit_On { get; set; }

        }
        public class ReportData
        {
            public string Brand_Name { get; set; }
            public decimal Cost { get; set; }
        }

        //выполнить ХП
        public static List<SPResult> ExecuteSP(int count, int nalichie)
        {
            System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@count", count);
            System.Data.SqlClient.SqlParameter param2 = new System.Data.SqlClient.SqlParameter("@nalichie", nalichie);
            shop db = new shop();
            var result = db.Database.SqlQuery<SPResult>("sqlzaprosLAB1 @count,@nalichie", new object[] { param1, param2 }).ToList();
            return result;
        }

        public static List<ReportData> ReportOrdersByMonth(int TypeID)
        {
            shop db = new shop();
            var request = db.Motorcycles
             .Join(db.Types, ph => ph.id_Type_FK, m => m.id_Type, (ph, m) => ph)
             .Where(i => i.id_Type_FK == TypeID)
             .Select(i => new ReportData() { Brand_Name = i.Brand_name, Cost = i.Cost })
             .ToList();
            return request;
        }
    }
}
