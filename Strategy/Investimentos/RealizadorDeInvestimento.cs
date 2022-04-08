using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Investimentos
{
    public class RealizadorDeInvestimento
    {
        public void RealizaInvestimento(Conta conta, IInvestimento investimento)
        {
            double resultado = investimento.Caulcula(conta);
            conta.Deposita(resultado * 0.75);
            Console.WriteLine("Novo Saldo: " + conta.Saldo);
        }

    }
}
