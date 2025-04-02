using DIApp.Util;
using Interfaces.Services;
using Ninject;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Lab3NLayer
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var mongo = ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString;
            // внедрение зависимостей
            //var kernel = new StandardKernel(new NinjectRegistrations(), new ReposModule("shop"));
            var kernel = new StandardKernel(new NinjectRegistrations(), new ReposModule(mongo));

            IMotoService motoServ = kernel.Get<IMotoService>();
            IOrderService orderServ = kernel.Get<IOrderService>();
            IReportService reportServ = kernel.Get<IReportService>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new lab5My(motoServ, orderServ, reportServ));
        }
    }
}
