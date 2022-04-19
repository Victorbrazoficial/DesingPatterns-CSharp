using Strategy.Descontos;
using Strategy.Investimentos;
using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // IImposto iss = new ISS();
            // IImposto icms = new ICMS();
            // IImposto iccc = new ICCC();
            // IImposto ir = new IR();

            // IInvestimento arrojado = new Arrojado();
            // IInvestimento conservador = new Conservardor();
            // IInvestimento moderado = new Moderado();

            // Conta conta = new Conta(1000);
            // //conta.Deposita(1000);
            // Orcamento orcamento = new Orcamento(1000);

            // RealizadorDeInvestimento realizadorDeInvestimento = new RealizadorDeInvestimento();
            // CalculadorDeImposto calculador = new CalculadorDeImposto();

            // Console.WriteLine("Investidor Arrojado");
            // realizadorDeInvestimento.RealizaCalculoInvestimento(conta,arrojado);

            Orcamento orcamento = new Orcamento(500);

            Item item = new Item("Caderno", 250); 
            Item item1 = new Item("Lapis", 1.0); 
            // Item item2 = new Item("Papel", 250); 
            // Item item3 = new Item("Toalha", 1.0); 
            // Item item4 = new Item("Pincel", 1.0); 
            // Item item5 = new Item("Pin444cel", 1.0); 

            Console.WriteLine("Lista de ITENS");
            orcamento.AdicionaItem(item);
            orcamento.AdicionaItem(item1);
            // orcamento.AdicionaItem(item2);
            // orcamento.AdicionaItem(item3);
            // orcamento.AdicionaItem(item4);
            // orcamento.AdicionaItem(item5);
            Console.WriteLine(orcamento.Itens[1].Nome);
            Console.WriteLine(orcamento.Itens[1].Valor);


            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            calculador.Calcula(orcamento);

            //Console.WriteLine(item.Nome);

            //Console.WriteLine("Investidor Moderado");
            //realizadorDeInvestimento.RealizaInvestimento(conta,moderado);

            //Console.WriteLine("Investidor Conservador");
            //realizadorDeInvestimento.RealizaInvestimento(conta,conservador);

            //Console.WriteLine();
            //Console.WriteLine("-----//-----//-----");
            //Console.WriteLine();
            
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
