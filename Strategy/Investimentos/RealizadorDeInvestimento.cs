using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Investimentos
{
    public class RealizadorDeInvestimento
    {
        //public double Lucro { get; private set; } 

        public void RealizaInvestimento(Conta conta, IInvestimento investimento)
        {
            IImpostoSobreLucro ir = new IR();
            
            conta.Lucro += investimento.Calcula(conta);
            Console.WriteLine("Lucro sem imposto: " + conta.Lucro);
            
            double imposto = ir.Calcula(conta);
            Console.WriteLine("Valor do imposto sobre o lucro: " + imposto);

            conta.Lucro -= imposto;
            Console.WriteLine("Valor do Lucro - Imposto : " + conta.Lucro);
            
            conta.Deposita(conta.Lucro);
            Console.WriteLine("Novo Saldo: " + conta.Saldo);
        }

    }
}
