using lab6;
class Client
{
    static void Main()
    {
        // флаги, чтобы можно было отключать какие-то способы оплаты
        Receiver receiver = new Receiver(false, false, true, true);

        PayHandler bankHandler = new BankPaymentHandler();
        PayHandler paypalHandler = new PaypalPaymentHandler();
        PayHandler bitcoinHandler = new BitcoinPaymentHandler();

        // Устанавливаем цепочку обработчиков
        bankHandler.Successor = paypalHandler;
        paypalHandler.Successor = bitcoinHandler;


        while (true)
        {
            Console.Write("Введите стоимость товара: ");
            // Задаем стоимость покупки
            if (decimal.TryParse(Console.ReadLine(), out decimal purchaseAmount))
            {
                // Выполняем оплату
                bankHandler.Handle(receiver, purchaseAmount);
            }
            else
            {
                Console.WriteLine("Некорректный ввод стоимости товара.");
            }
        }
    }
}

