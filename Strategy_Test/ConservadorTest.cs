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
    }
}
