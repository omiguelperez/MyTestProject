using ThisWillBeTested;
using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MyTestProject
{
    [Binding]
    public class DefinitivaSteps
    {
        CalculAnibal calculadora = new CalculAnibal();

        [Given(@"Yo ingrese la primera nota (.*) en la CalculAnibal")]
        public void GivenYoIngreseLaPrimeraNotaEnLaCalculAnibal(Decimal primera)
        {
            calculadora.PrimeraNota = primera;
        }
        
        [Given(@"Yo ingrese la segunda nota (.*) en la CalculAnibal")]
        public void GivenYoIngreseLaSegundaNotaEnLaCalculAnibal(Decimal segunda)
        {
            calculadora.SegundaNota = segunda;
        }

        [Given(@"Yo ingrese la tercera nota (.*) en la CalculAnibal")]
        public void GivenYoIngreseLaTerceraNotaEnLaCalculAnibal(Decimal tercera)
        {
            calculadora.TerceraNota = tercera;
        }

        [When(@"Yo presiono Calcular")]
        public void WhenYoPresionoCalcular()
        {
            calculadora.Calcular();
        }
        
        [Then(@"el resultado deber ser (.*) en la pantalla")]
        public void ThenElResultadoDeberSerEnLaPantalla(Decimal notaDefinitiva)
        {
            Assert.AreEqual(notaDefinitiva, calculadora.Nota);
        }
    }
}
