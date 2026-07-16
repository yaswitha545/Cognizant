using NUnit.Framework;
using Moq;
using CustomerCommLib;


namespace CustomerComm.Tests
{

    [TestFixture]
    public class CustomerCommTest
    {

        Mock<IMailSender> mockMailSender;


        [OneTimeSetUp]
        public void Init()
        {

            mockMailSender = new Mock<IMailSender>();


            mockMailSender
                .Setup(x => x.SendMail(
                    It.IsAny<string>(),
                    It.IsAny<string>()
                 ))
                .Returns(true);

        }



        [TestCase]
        public void SendMailToCustomer_Test()
        {

            CustomerComm customer =
                new CustomerComm(
                    mockMailSender.Object
                );


            bool result =
                customer.SendMailToCustomer();


            Assert.AreEqual(true, result);

        }

    }
}
