using DIApp.Util;
using Interfaces.Services;
using Ninject;
using System;
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
            // внедрение зависимостей
            var kernel = new StandardKernel(new NinjectRegistrations(), new ReposModule("shop"));

            IMotoService motoServ = kernel.Get<IMotoService>();
            IOrderService orderServ = kernel.Get<IOrderService>();
            IReportService reportServ = kernel.Get<IReportService>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new lab4(motoServ, orderServ, reportServ));
        }
    }
}
