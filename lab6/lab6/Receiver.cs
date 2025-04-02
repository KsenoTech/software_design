using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Receiver
    {
        public bool WriteMassage { get; set; }

        /// <summary>
        /// перевод через Банк
        /// </summary>
        public bool BankTransfer { get; set; }

        /// <summary>
        /// перевод через PayPal
        /// </summary>
        public bool PayPalTransfer { get; set; }

        /// <summary>
        /// перевод через Биток
        /// </summary>
        public bool BitCoinTransfer { get; set; }

        public Receiver(bool bankTr, bool paypalTr, bool bitcoinTr, bool writeMassageTr)
        {
            BankTransfer = bankTr;
            PayPalTransfer = paypalTr;
            BitCoinTransfer = bitcoinTr;
            WriteMassage = writeMassageTr;
        }
    }
}
