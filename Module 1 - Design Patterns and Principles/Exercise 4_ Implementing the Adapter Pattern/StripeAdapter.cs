namespace AdapterPatternExample
{
    public class StripeAdapter : PaymentProcessor
    {
        private StripeGateway stripeGateway;

        public StripeAdapter(StripeGateway gateway)
        {
            stripeGateway = gateway;
        }

        public void ProcessPayment(double amount)
        {
            stripeGateway.Pay(amount);
        }
    }
}
