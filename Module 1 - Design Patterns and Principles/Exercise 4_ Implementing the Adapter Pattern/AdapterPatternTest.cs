using System;

namespace AdapterPatternExample
{
    class AdapterPatternTest
    {
        static void Main(string[] args)
        {
            PaymentProcessor paypal = new PayPalAdapter(new PayPalGateway());
            PaymentProcessor stripe = new StripeAdapter(new StripeGateway());

            paypal.ProcessPayment(5000);
            stripe.ProcessPayment(7500);
        }
    }
}
