using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    /// <summary>
    /// Handler: определяет интерфейс для обработки запроса. Также может определять ссылку на следующий обработчик запроса
    /// </summary>
    abstract class PayHandler 
    {
        public PayHandler? Successor { get; set; }
        public abstract void Handle(Receiver receiver, decimal amount);
    }
}
