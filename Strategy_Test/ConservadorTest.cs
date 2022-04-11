using Strategy.Excpetions;
using Strategy.Investimentos;
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
            var calculoInvestimento = conservardor.Calcula(conta);

            //Assert
            Assert.Equal(result, calculoInvestimento);

        }

        [Fact]
        public void CalculaInvestimento_SobreOValorDoSaldoZerado_RetornaExceptionSucesso()
        {
            //Arrange
            Conta conta = new Conta();
            Conservardor conservardor = new Conservardor();

            //Act

            //Assert
            Assert.Throws<SaldoZeradoException>(() => conservardor.Calcula(conta));
        }

        [Fact]
        public void CalculaInvestimento_SobreOValorDoSaldoNegativo_RetornaExceptionSucesso()
        {
            //Arrange
            Conta conta = new Conta(-100);
            Conservardor conservardor = new Conservardor();

            //Act

            //Assert
            Assert.Throws<SaldoNegativoException>(() => conservardor.Calcula(conta));
        }
    }
}
