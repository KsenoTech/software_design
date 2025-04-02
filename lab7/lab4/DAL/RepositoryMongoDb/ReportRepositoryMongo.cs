using DomainModel;
using DTO;
using Interfaces.Repository;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MongoDB.Driver.WriteConcern;

/*Так как в NoSql нет хранимых процедур, выборки для отчетов реализуются в коде. 
 * Для соединения коллекций можно использовать Linq(проще) или метод Aggregate(). 
 * Создайте базовые сущности (в примере это телефон и заказ) и посмотрите структуру документов, созданных в MongoDb. 
 * Основываясь на этом, можно написать код выборки.*/

namespace DAL.RepositoryMongoDb //реализации репозиториев 
{
    class ReportRepositoryMongo : IReportsRepository
    {
        private MongoContext db;

        public ReportRepositoryMongo(MongoContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<sqlzaprosLAB1> ExecuteSP(int cost, int nalichie)
        {
            //var builder = new FilterDefinitionBuilder<Motorcycle>();
            //var filter = builder.Empty; // фильтр для выборки всех документов

            ////проекция, Запрос к вложенным объектам
            //var project = BsonDocument.Parse(
            //    "{Brand_name: '$Brand_name',PhoneName:'$Phones.Name',Date:'$Date', month: {$month: '$Date'},year: {$year: '$Date'}}");

            //var fil = BsonDocument.Parse(
            //    "{$and:[{'month':{$eq: " + cost + "}},{'year':{$eq:" + nalichie + "}}]}");

            //var res = db.OrderCollection.Aggregate()
            //    .Project(project)
            //    .Match(fil)
            //    .ToList()
            //    .Select(i => new sqlzaprosLAB1
            //    {
            //        Brand_name = i.GetValue("Brand_name").AsString,
            //        //Date = i.GetValue("Date").ToLocalTime(),
            //        Model_name = String.Join(",", i.GetValue("Model_name").AsBsonArray.ToList())
            //    });
            //return res.ToList();
             IMongoCollection<Motorcycle> motorcycleCollection;
            motorcycleCollection = db.MotoCollection;

            var builder = Builders<Motorcycle>.Filter;
            FilterDefinition<Motorcycle> filter;

            if (nalichie == 2)
            {
                filter = builder.In("HaveInStore", new[] { 0, 1 });
            }
            else
            {
                filter = builder.Eq("HaveInStore", nalichie);
            }

            var projection = Builders<Motorcycle>.Projection.Expression(
                doc => new sqlzaprosLAB1
                {
                    Brand_name = doc.Brand_name,
                    Model_name = doc.Model_name,
                    Cost = cost >= doc.Cost ? doc.Cost : -doc.Cost,
                    Credit_On = cost < doc.Cost ? doc.Cost - cost : 0
                });

            var result = motorcycleCollection
                .Find(filter)
                .Project(projection)
                .ToList();

            return result;

        }

        public List<ReportSQLData> MotosOfType(int typeid)
        {
            //var test = db.PhoneCollection.Aggregate().Lookup("Manufacturer" , "ManufacturerId", "Id", "resultData").ToList();
            var request = (
                from ph in db.MotoCollection.AsQueryable()
                join m in db.TypeCollection.AsQueryable()
                on ph.id_Type_FK equals m.Id into gr
                where ph.id_Type_FK == typeid
                select new ReportSQLData() { Brand_name = ph.Brand_name, Cost = ph.Cost })
             .ToList();
            return request;
        }
    }
}
