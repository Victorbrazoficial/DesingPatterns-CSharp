using System;
namespace Strategy.Descontos
{
    public class DescontoPorCincoItens : IDescontos
    {
        public IDescontos Proximo { get ; set ; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count >= 5 )
            {
                Console.WriteLine("Desconto mais de 5 itens");
                return orcamento.Valor * 0.1;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}