using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    /// <summary>
    /// конкретные обработчики, которые реализуют функционал для обработки запроса. При невозможности обработки и наличия ссылки на следующий обработчик, передают запрос этому обработчику
    /// </summary>
    class PaypalPaymentHandler : PayHandler
    {
        private decimal balance = 2000;
        public override void Handle(Receiver receiver, decimal amount)
        {
            if (receiver.WriteMassage == true)
                Console.WriteLine("Взял управление PayPal \n");

            if ((receiver.PayPalTransfer == true) && (amount <= balance))
            {
                balance -= amount;
                    Console.WriteLine($"Оплачено {amount} с использованием PayPal. Остаток на счете {balance}.");
            }
            else if (Successor != null)
            {
                if (receiver.WriteMassage == true)
                    Console.WriteLine("Передаю управление через Handle \n");

                Successor.Handle(receiver, amount);
            }       
        }
    }
}
