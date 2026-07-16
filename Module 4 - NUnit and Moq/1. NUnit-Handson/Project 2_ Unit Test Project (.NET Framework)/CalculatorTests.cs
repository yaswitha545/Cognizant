using NUnit.Framework;
using CalcLibrary;


namespace CalculatorUnitTests
{

    [TestFixture]
    public class CalculatorTests
    {

        Calculator calculator;


        // Runs before every test method
        [SetUp]
        public void Init()
        {
            calculator = new Calculator();
        }



        // Parameterized Test Cases
        [TestCase(10,20,30)]
        [TestCase(50,50,100)]
        [TestCase(-5,10,5)]
        public void Addition_Test(
            int number1,
            int number2,
            int expected)
        {

            int result =
                calculator.Add(
                    number1,
                    number2
                );


            Assert.That(
                result,
                Is.EqualTo(expected)
            );

        }



        // Runs after every test method
        [TearDown]
        public void Cleanup()
        {
            calculator = null;
        }



        // Example for Ignore Attribute

        [Ignore("Testing Ignore Attribute")]
        [Test]
        public void Ignore_Test()
        {
            Assert.Pass();
        }


    }
}
