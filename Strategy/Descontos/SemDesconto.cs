using System;
namespace Strategy.Descontos
{
    public class SemDesconto : IDescontos
    {
        public IDescontos Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            Console.WriteLine("Sem desconto.");
            return 0;
        }
    }
}