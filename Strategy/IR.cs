using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class IR : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.25;
        }
    }
}
