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
    public class ReportService: IReportService
    {
        private IDbRepos db;

        public ReportService(IDbRepos repos)
        {
            db = repos;
        }

        public List<OrdersByMonth> ExecuteSP(int month, int year)
        {

            return db.Reports.ExecuteSP(month, year).Select(i => new OrdersByMonth { Customer = i.Customer, Date = i.Date, Phones = i.Phones }).ToList();
        }

        public List<ReportData> ReportPhonesOfMunufacturer(int manufId)
        {
            var request = db.Reports.PhonesOfMunufacturer(manufId)
             .Select(i => new ReportData() { PhoneName = i.PhoneName, Cost = i.Cost })
             .ToList();
            return request;
        }
    }
}
