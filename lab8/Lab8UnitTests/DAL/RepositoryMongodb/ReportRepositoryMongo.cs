using DomainModel;
using DTO;
using Interfaces.Repository;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Mongodb
{
    class ReportRepositoryMongo : IReportsRepository
    {
        private MongoContext db;

        public ReportRepositoryMongo(MongoContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<OrdersByMonth> ExecuteSP(int month, int year)
        {
            var builder = new FilterDefinitionBuilder<Phone>();
            var filter = builder.Empty; // фильтр для выборки всех документов

            //проекция, Запрос к вложенным объектам
            var project = BsonDocument.Parse(
                "{Customer: '$Customer',PhoneName:'$Phones.Name',Date:'$Date', month: {$month: '$Date'},year: {$year: '$Date'}}");

            var fil = BsonDocument.Parse(
                "{$and:[{'month':{$eq: " + month + "}},{'year':{$eq:" + year + "}}]}");

            var res = db.OrderCollection.Aggregate()
                .Project(project)
                .Match(fil)
                .ToList()
                .Select(i => new OrdersByMonth {
                    Customer = i.GetValue("Customer").AsString,
                    Date = i.GetValue("Date").ToLocalTime(),
                    Phones = String.Join(",", i.GetValue("PhoneName").AsBsonArray.ToList()) });
            return res.ToList();
        }

        public List<ReportData> PhonesOfMunufacturer(int manufId)
        {
            //var test = db.PhoneCollection.Aggregate().Lookup("Manufacturer" , "ManufacturerId", "Id", "resultData").ToList();
            var request =  (
                from ph in db.PhoneCollection.AsQueryable()
             join m in db.ManufacturerCollection.AsQueryable()
             on ph.ManufacturerId equals m.Id into gr
             where ph.ManufacturerId == manufId
             select new ReportData() { PhoneName = ph.Name, Cost = ph.Cost })
             .ToList();
            return request;
        }
    }
}
