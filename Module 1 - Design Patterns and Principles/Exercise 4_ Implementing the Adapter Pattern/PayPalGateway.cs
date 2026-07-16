using System;

namespace AdapterPatternExample
{
    public class PayPalGateway
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine("Payment of Rs." + amount + " processed through PayPal.");
        }
    }
}
