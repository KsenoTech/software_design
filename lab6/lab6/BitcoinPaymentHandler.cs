using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    /// <summary>
    /// ConcreteHandler1 и ConcreteHandler2: конкретные обработчики, которые реализуют функционал для обработки запроса. При невозможности обработки и наличия ссылки на следующий обработчик, передают запрос этому обработчику
    /// </summary>
    class BitcoinPaymentHandler : PayHandler
    {
        static decimal balance = 36535;
        public override void Handle(Receiver receiver, decimal amount)
        {
            if (receiver.WriteMassage == true) 
                Console.WriteLine("Взял управление BitCoin \n");
            if (amount <= balance)
            {
                balance -= amount;
                    Console.WriteLine($"Оплачено {amount} с использованием Bitcoin. Остаток на счете {balance}.");
            }
            else if (Successor != null)
            {
                Console.WriteLine("Недостаточно средств для оплаты.");
            }
            else Console.WriteLine("Доступных способов оплаты НЕТ! Обратитесь, пожалуйста, в свой банк для решения этой ситуации.");
              
        }
    }
}
