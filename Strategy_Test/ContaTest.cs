using Strategy;
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

        [Fact]
        public void Construtor_ComValorDoParametroSaldoZerado_RetornaExceptionSucesso()
        {
            //Arrange
            Conta conta = new Conta();
            var saldo = 0;

            //Act

            //Assert
            Assert.Throws<SaldoZeradoException>(() => conta = new Conta(saldo));
        }

        [Fact]
        public void Construtor_ComValorDoParametroSaldoNegativo_RetornaExceptionSucesso()
        {
            //Arrange
            Conta conta = new Conta();
            var saldo = -100;

            //Act

            //Assert
            Assert.Throws<SaldoNegativoException>(() => conta = new Conta(saldo));
        }

        [Fact]
        public void Calculador_ImpostoSobreSaldo_RetornoComSucesso()
        {
            //Arrange
            Conta conta = new Conta(1000);
            IImpostoSobreLucro ir = new IR();
            var esperado = 250;

            //Act
            ir.CalculaImpostoSobreSaldo(conta);
            var result = conta.Imposto;
            

            //Assert
            Assert.Equal(esperado, result);
        }

        [Fact]
        public void Soma_ImpostoAnteriorComOAtualSempreQueCalculaImpostoIR_RetornoComSucesso()
        {
            //Arrange
            Conta conta = new Conta(1000);
            IImpostoSobreLucro ir = new IR();
            var esperado = 500;

            //Act
            ir.CalculaImpostoSobreSaldo(conta);
            ir.CalculaImpostoSobreSaldo(conta);
            var result = conta.Imposto;

            //Assert
            Assert.Equal(esperado, result);
        }
    }
}
