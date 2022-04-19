
using System;
using System.Collections.Generic;

namespace Strategy.Descontos
{
    public class CalculadorDeDescontos
    {
        
        public void Calcula(Orcamento orcamento)
        {
            IDescontos d1 = new DescontoPorCincoItens();
            IDescontos d2 = new DescontoPorMaisDeQuinhetosReais();
            IDescontos d3 = new SemDesconto();
            d1.Proximo = d2;
            d2.Proximo = d3;
           
            double desconto = d1.Desconta(orcamento);
        }      
    }
}