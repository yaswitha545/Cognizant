using System;

namespace AdapterPatternExample
{
    public class StripeGateway
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Payment of Rs." + amount + " processed through Stripe.");
        }
    }
}
