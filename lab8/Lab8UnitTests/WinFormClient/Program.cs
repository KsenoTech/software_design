using DIApp.Util;
using Interfaces.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4DI
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
            var kernel = new StandardKernel(new NinjectRegistrations(), new ReposModule(mongo));

            IPhoneService phoneServ = kernel.Get<IPhoneService>();
            IOrderService orderServ = kernel.Get<IOrderService>();
            IReportService reportServ = kernel.Get<IReportService>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(phoneServ,orderServ,reportServ));
        }
    }
}
