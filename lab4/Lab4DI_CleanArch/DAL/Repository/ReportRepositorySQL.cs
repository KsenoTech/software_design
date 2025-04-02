using DomainModel;
using DTO;
using Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ReportRepositorySQL: IReportsRepository
    {
        private PhonesContext db;
        private class SPResult
        {
            public string Customer { get; set; }
            public string PhoneName { get; set; }
            public DateTime Date { get; set; }
        }
        public ReportRepositorySQL(PhonesContext dbcontext)
        {
            this.db = dbcontext;
        }

        //выполнить ХП
        public List<OrdersByMonth> ExecuteSP(int month, int year)
        {
            System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@month", month);
            System.Data.SqlClient.SqlParameter param2 = new System.Data.SqlClient.SqlParameter("@year", year);
            
            var result = db.Database.SqlQuery<SPResult>("Orders_getByMonth @month,@year", new object[] { param1, param2 }).ToList();
            var data = result.GroupBy(i => new { i.Customer, i.Date }).ToDictionary(i => i.Key, i => i.Select(j => j.PhoneName))
                .Select(i => new OrdersByMonth
                {
                    Customer = i.Key.Customer,
                    Date = i.Key.Date,
                    Phones = String.Join(",", i.Value.Select(j => j).ToArray())
                }).ToList();
            return data;


        }

        public List<ReportData> PhonesOfMunufacturer(int manufId)
        {
            var request = db.Phones
             .Join(db.Manufacturers, ph => ph.ManufacturerId, m => m.Id, (ph, m) => ph)
             .Where(i => i.ManufacturerId == manufId)
             .Select(i => new ReportData() { PhoneName = i.Name, Cost = i.Cost })
             .ToList();
            return request;
        }
    }
}
