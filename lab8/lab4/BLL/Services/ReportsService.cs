using DAL;
using DomainModel;
using DTO;
using Interfaces.Repository;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ReportService : IReportService
    {
        private IDbRepos db;

        public ReportService(IDbRepos repos)
        {
            db = repos;
        }

        public List<sqlzaprosLAB1> ExecuteSP(int count, int nalichie)
        {

            return db.Reports.ExecuteSP(count, nalichie).ToList();
        }

        public List<ReportSQLData> ReportMotosOfType(int manufId)
        {
            var request = db.Reports.MotosOfType(manufId)
             .Select(i => new ReportSQLData() { Brand_name = i.Brand_name, Cost = i.Cost })
             .ToList();
            return request;
        }

    }
}
