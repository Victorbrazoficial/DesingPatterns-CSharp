using Strategy.Excpetions;
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
        public void Deposita_ValorNegativoNoSaldoDaConta_RetornaExceptionSucesso()
        {
            //Arrange
            Conta conta = new Conta();

            //Act

            //Assert
            Assert.Throws<ParametroNegativoException>(() => conta.Deposita(-1000));
        }

        [Fact]
        public void Deposita_ValorZeraNoSaldoDaConta_RetornaExceptionSucesso()
        {
            //Arrange
            Conta conta = new Conta();

            //Act
           
            //Assert         
            Assert.Throws<ParametroZeradoException>(() => conta.Deposita(0));
        }
    }
}
