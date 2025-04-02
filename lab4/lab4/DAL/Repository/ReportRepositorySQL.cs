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
    public class ReportRepositorySQL : IReportsRepository
    {
        private ShopContext db;
        //private class SPResult
        //{
        //    public string Customer { get; set; }
        //    public string Brand_name { get; set; }
        //    public DateTime Date { get; set; }
        //}
        public class SPResult
        {

            public string Brand_name { get; set; }
            public string Model { get; set; }
            public int Cost { get; set; }
            public int Credit_On { get; set; }

        }
        public ReportRepositorySQL(ShopContext dbcontext)
        {
            this.db = dbcontext;
        }

        //выполнить ХП
        public List<sqlzaprosLAB1> ExecuteSP(int count, int nalichie)
        {
            System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@count", count);
            System.Data.SqlClient.SqlParameter param2 = new System.Data.SqlClient.SqlParameter("@nalichie", nalichie);

            var result = db.Database.SqlQuery<SPResult>("sqlzaprosLAB1 @count,@nalichie", new object[] { param1, param2 }).ToList();
            var data = result.GroupBy(i => new { i.Brand_name, i.Model, i.Cost, i.Credit_On })
                .Select(i => new sqlzaprosLAB1
                {
                    Brand_name = i.Key.Brand_name,
                    Model = i.Key.Model,
                    Cost = i.Key.Cost,
                    Credit_On = i.Key.Credit_On,
                }).ToList();
            return data;


        }

        public List<ReportData> MotosOfType(int typeId)
        {
            var request = db.Motorcycles
             .Join(db.Types, ph => ph.id_Type_FK, m => m.Id, (ph, m) => ph)
             .Where(i => i.id_Type_FK == typeId)
             .Select(i => new ReportData() { Brand_name = i.Brand_name, Cost = i.Cost })
             .ToList();
            return request;
        }

    }
}
