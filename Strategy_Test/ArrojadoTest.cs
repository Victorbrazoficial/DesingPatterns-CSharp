using Strategy.Excpetions;
using Strategy.Investimentos;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Strategy_Test
{
    public class ArrojadoTest
    {
        [Fact]
        public void Calcula_InvestidorArrojadoQuandoRandomMenorOuIgualA20_RetorComSucesso()
        {
            //Arrange
            Arrojado arrojado = new Arrojado(0);
            Conta conta = new Conta(1000);
            var esperado = 50;

            //Act
            var result = arrojado.Calcula(conta);

            //Assert
            Assert.Equal(esperado, result);   
        }

        [Fact]
        public void Calcula_InvestidorArrojadoQuandoRandomMaiorA20_RetornaComSucesso()
        {
            //Arrange
            Arrojado arrojado = new Arrojado(21);
            Conta conta = new Conta(1000);
            var esperado = 30;

            //Act
            var result = arrojado.Calcula(conta);

            //Assert
            Assert.Equal(esperado, result);
        }

        [Fact]
        public void Calcula_InvestidorArrojadoQuandoRandomIgualOuMenorA30_RetornaComSucesso()
        {
            //Arrange
            Arrojado arrojado = new Arrojado(30);
            Conta conta = new Conta(1000);
            var esperado = 30;

            //Act
            var result = arrojado.Calcula(conta);

            //Assert
            Assert.Equal(esperado, result);
        }

        [Fact]
        public void Calcula_InvestidorArrojadoQuandoRandomMenorQueZero_RetornaExceptionComSucesso()
        {
            //Arrange
            Arrojado arrojado = new Arrojado(1);
            var random = -1;

            //Act

            //Assert
            Assert.Throws<NumeroRandomNegativoException>(() => arrojado = new Arrojado(random));
        }
    }
}
