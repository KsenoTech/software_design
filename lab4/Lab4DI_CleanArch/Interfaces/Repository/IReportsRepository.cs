using DTO;
using System.Collections.Generic;

namespace Interfaces.Repository
{

    public interface IReportsRepository
    {
        List<OrdersByMonth> ExecuteSP(int month, int year);
        List<ReportData> PhonesOfMunufacturer(int manufId);
    }

}
