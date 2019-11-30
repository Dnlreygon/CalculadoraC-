using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Example1_Luxoft_Core
{
    [Binding]
    public class CalculadoraSteps
    {
        Calculatora calculadora = new Calculatora();
        double resultado;

        [Given(@"I set (.*) as first number on calculator")]
        public void GivenISetAsFirstNumberOnCalculator(double numero1)
        {
            calculadora.num1= numero1;
        }
        
        [Given(@"I set (.*) into the calculator")]
        public void GivenISetIntoTheCalculator(double numero2)
        {
            calculadora.num2= numero2;
        }
        
        [When(@"Execute sum operation")]
        public void WhenExecuteSumOperation()
        {
            resultado = calculadora.sum();
        }
        
        [When(@"Execute substraction operation")]
        public void WhenExecuteSubstractionOperation()
        {
            resultado = calculadora.substraction();


        }
        [When(@"Execute multiplicacion operation")]
        public void WhenExecuteMultiplicacionOperation()
        {
            resultado = calculadora.multiplication();
        }

        [When(@"Execute division operation")]
        public void WhenExecuteDivisionOperation()
        {
            resultado = calculadora.Divition();
        }


        [Then(@"The result should be (.*)")]
        public void ThenTheResultShouldBe(double actualResult)
        {
            Assert.AreEqual(resultado, actualResult, "la suma se hizo mal. Intentó sumar " + calculadora);
        }
    }
}
