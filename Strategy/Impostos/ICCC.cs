using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ICCC : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {

           if (orcamento.Valor < 1000)
           {
               return orcamento.Valor * 0.05;
           }
           else
           {
               if ((orcamento.Valor >= 1000) && ( orcamento.Valor <= 3000))
               {
                   return orcamento.Valor * 0.07;
               }   
               return (orcamento.Valor * 0.08) + 30;
           }
        }
    }
}
