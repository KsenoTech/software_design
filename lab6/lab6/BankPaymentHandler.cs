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
    class BankPaymentHandler : PayHandler
    {
        private decimal balance = 500;
        public override void Handle(Receiver receiver, decimal amount)
        {
            if (receiver.WriteMassage == true) 
                Console.WriteLine("Взял управление БАНК \n");

            if (amount <= balance)
            {
                balance -= amount;
                    Console.WriteLine($"Оплачено {amount} с использованием банковского счета. Остаток на счете {balance}.");
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
///В данном случае для простоты примера в качестве параметра передается некоторое число, 
///сначала обработчик обрабатывает запрос и, если передано соответствующее число, завершает его обработку.
///Иначе передает запрос на обработку следующем в цепи обработчику при его наличии.