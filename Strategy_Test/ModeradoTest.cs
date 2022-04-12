using Strategy.Investimentos;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Strategy_Test
{
    public class ModeradoTest
    {
        [Fact]
        public void Calcula_InvestidorModeradoComCondicionalRandomSempreTrue_RetornoComSucesso()
        {
            //Arrange
            Moderado moderado = new Moderado(true);
            Conta conta = new Conta(1000);
            var esperado = 25;

            //Act
            var result = moderado.Calcula(conta);

            //Assert        
            Assert.Equal(result,esperado);
        }

        [Fact]
        public void Calcula_InvestidorModeradoComCondicionalRandomSempreFalse_RetornoComSucesso()
        {
            //Arrange
            Moderado moderado = new Moderado(false);
            Conta conta = new Conta(1000);
            var esperado = 7;

            //Act
            var result = moderado.Calcula(conta);

            //Assert        
            Assert.Equal(result, esperado);
        }
    }
}
