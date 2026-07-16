namespace AdapterPatternExample
{
    public class PayPalAdapter : PaymentProcessor
    {
        private PayPalGateway payPalGateway;

        public PayPalAdapter(PayPalGateway gateway)
        {
            payPalGateway = gateway;
        }

        public void ProcessPayment(double amount)
        {
            payPalGateway.MakePayment(amount);
        }
    }
}
