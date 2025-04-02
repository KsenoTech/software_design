using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    public interface IReportService
    {
        /// <summary>
        /// выполнить ХП - отчет по заказам за месяц
        /// </summary>
        List<OrdersByMonth> ExecuteSP(int month, int year);
        /// <summary>
        /// Телефоны производителя
        /// </summary>
        List<ReportData> ReportPhonesOfMunufacturer(int manufId);
    }
}
