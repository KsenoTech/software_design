using DTO;
using System.Collections.Generic;

namespace Interfaces.Repository
{

    public interface IReportsRepository // методы получения отчетов
    {
        List<sqlzaprosLAB1> ExecuteSP(int count, int nalichie);
        List<ReportSQLData> MotosOfType(int typeId);
    }

}
