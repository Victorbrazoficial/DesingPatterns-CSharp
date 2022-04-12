using Strategy;
using Strategy.Investimentos;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Strategy_Test
{
    public class RealizadorDeInvestimentosTest
    {
        [Fact]
        public void RealizaCalculoInvestimento_LucroConservadorComDescontoDoImpostoIR_RetornoComSucesso()
        {
            //Arrange
            Conta conta = new Conta(1000);
            IInvestimento conservardor = new Conservardor();
            RealizadorDeInvestimento realizadorDeInvestimento = new RealizadorDeInvestimento();
            var esperado = 6;

            //Act
            var result = realizadorDeInvestimento.RealizaCalculoInvestimento(conta,conservardor);

            //Assert
            Assert.Equal(esperado, result);
        }

        [Fact]
        public void RealizaCalculoInvestimento_ImpostoIRSobreLucroDoInvestidorConservador_RetornoComSucesso()
        {
            //Arrange
            Conta conta = new Conta(1000);
            //IImpostoSobreLucro ir = new IR();
            IInvestimento conservardor = new Conservardor();
            RealizadorDeInvestimento realizadorDeInvestimento = new RealizadorDeInvestimento();
            var esperado = 2;

            //Act
            realizadorDeInvestimento.RealizaCalculoInvestimento(conta, conservardor);
            var result = conta.Imposto;

            //Assert
            Assert.Equal(esperado, result);
        }

        [Fact]
        public void RealizaCalculoInvestimento_LucroConservadorSemDescontoDoImpostoIR_RetornoComSucesso()
        {
            //Arrange
            Conta conta = new Conta(1000);
            IInvestimento conservardor = new Conservardor();
            RealizadorDeInvestimento realizadorDeInvestimento = new RealizadorDeInvestimento();
            var esperado = 8;

            //Act
            var result = conservardor.Calcula(conta);

            //Assert
            Assert.Equal(esperado, result);
        }

    }
}
