using Strategy.Investimentos;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Strategy_Test
{
    public class ConservadorTest
    {
        [Fact]
        public void CalculaInvestimento_SobreOValorDoSaldo_RetornaLucroComSucesso()
        {
            //Arrange
            Conta conta = new Conta();
            Conservardor conservardor = new Conservardor();
            var result = 8;

            //Act
            conta.Deposita(1000);
            var calculoInvestimento = conservardor.Caulcula(conta);

            //Assert
            Assert.Equal(result, calculoInvestimento);

        }

        [Fact]
        public void CalculaInvestimento_SobreOValorDoSaldoZerado_RetornaLucroComFalied()
        {
            //Arrange
            Conta conta = new Conta();
            Conservardor conservardor = new Conservardor();
            var result = 0;

            //Act
            conta.Deposita(0);
            var calculoInvestimento = conservardor.Caulcula(conta);

            //Assert
            Assert.Equal(result, calculoInvestimento);
        }

        [Fact]
        public void CalculaInvestimento_SobreOValorDoSaldoNegativo_RetornaLucroComFalied()
        {
            //Arrange
            Conta conta = new Conta();
            Conservardor conservardor = new Conservardor();
            var result = -8;

            //Act
            conta.Deposita(-1000);
            var calculoInvestimento = conservardor.Caulcula(conta);

            //Assert
            Assert.Equal(result, calculoInvestimento);
        }
    }
}
