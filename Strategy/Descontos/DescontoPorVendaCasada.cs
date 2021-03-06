using System;
namespace Strategy.Descontos
{
    public class DescontoPorVendaCasada : IDescontos
    {
        public IDescontos Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (aconteceuVendaCasadaEm(orcamento))
            {
                Console.WriteLine("Desconto por Venda Casada.");
                return orcamento.Valor * 0.05;
            } 

            return Proximo.Desconta(orcamento);
        }

        private bool aconteceuVendaCasadaEm(Orcamento orcamento) 
        {
            return Existe("CANETA", orcamento) && Existe("LAPIS", orcamento);
        }

        private bool Existe(string nomeDoItem, Orcamento orcamento) 
        {
            foreach (Item item in orcamento.Itens) 
            {
                if(item.Nome.Equals(nomeDoItem)) 
                    return true;
            }
            return false;
        }
    }
}