namespace CustomerCommLib
{
    public class CustomerComm
    {
        private IMailSender _mailSender;


        // Constructor Injection
        public CustomerComm(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }


        public bool SendMailToCustomer()
        {
            // Actual logic

            _mailSender.SendMail(
                "cust123@abc.com",
                "Some Message"
            );


            return true;
        }
    }
}
