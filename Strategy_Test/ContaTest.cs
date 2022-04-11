using Strategy.Investimentos;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Strategy_Test
{
    public class ContaTest
    {
        [Fact]
        public void Deposita_ValorNoSaldoDaConta_Sucesso()
        {
            //Arrange
            Conta conta = new Conta();
            var deposito = 1000;

            //Act
            conta.Deposita(1000);
            double result = conta.Saldo;

            //Assert
            Assert.Equal(deposito, result);
        }

        [Fact]
        public void Deposita_ValorNegativoNoSaldoDaConta_Falied()
        {
            //Arrange
            Conta conta = new Conta();
            var deposito = -1000;

            //Act
            conta.Deposita(-1000);
            double result = conta.Saldo;

            //Assert
            Assert.Equal(deposito, result);
        }

        [Fact]
        public void Deposita_ValorZeraNoSaldoDaConta_Falied()
        {
            //Arrange
            Conta conta = new Conta();
            var deposito = 0;

            //Act
            conta.Deposita(0);
            double result = conta.Saldo;

            //Assert
            Assert.Equal(deposito, result);
        }


    }
}
