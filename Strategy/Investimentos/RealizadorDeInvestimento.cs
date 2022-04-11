using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Investimentos
{
    public class RealizadorDeInvestimento
    {
        public double Lucro { get; private set; } 

        public void RealizaInvestimento(Conta conta, IInvestimento investimento, RealizadorDeInvestimento realizadorDeInvestimentos)
        {
            IImpostoSobreLucro ir = new IR();
            
            Lucro += investimento.Caulcula(conta);
            Console.WriteLine("Lucro sem imposto: " + Lucro);
            
            double imposto = ir.Calcula(realizadorDeInvestimentos);
            Console.WriteLine("Valor do imposto sobre o lucro: " + imposto);

            Lucro -= imposto;
            Console.WriteLine("Valor do Lucro - Imposto : " + Lucro);
            
            conta.Deposita(Lucro);
            Console.WriteLine("Novo Saldo: " + conta.Saldo);
        }

    }
}
