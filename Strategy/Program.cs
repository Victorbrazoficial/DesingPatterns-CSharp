using Strategy.Investimentos;
using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto iccc = new ICCC();
            IImposto ir = new IR();

            IInvestimento arrojado = new Arrojado();
            IInvestimento conservador = new Conservardor();
            IInvestimento moderado = new Moderado();

            Conta conta = new Conta();
            conta.Deposita(1000);
            Orcamento orcamento = new Orcamento(1000);

            RealizadorDeInvestimento realizadorDeInvestimento = new RealizadorDeInvestimento();
            CalculadorDeImposto calculador = new CalculadorDeImposto();

            Console.WriteLine("Investidor Arrojado");
            realizadorDeInvestimento.RealizaInvestimento(conta,arrojado,realizadorDeInvestimento);

            Console.WriteLine("Investidor Moderado");
            realizadorDeInvestimento.RealizaInvestimento(conta,moderado,realizadorDeInvestimento);

            Console.WriteLine("Investidor Conservador");
            realizadorDeInvestimento.RealizaInvestimento(conta,conservador,realizadorDeInvestimento);

            Console.WriteLine();
            Console.WriteLine("-----//-----//-----");
            Console.WriteLine();
            
            //Console.WriteLine("ICMS:");
            //calculador.RealizaCalculo(orcamento, icms);

            //Console.WriteLine("ISS:");
            //calculador.RealizaCalculo(orcamento, iss);

            //Console.WriteLine("IR:");
            //calculador.RealizaCalculo(orcamento, ir);

            //Console.WriteLine("ICCC:");
            //calculador.RealizaCalculo(orcamento, iccc);
        }
    }
}
