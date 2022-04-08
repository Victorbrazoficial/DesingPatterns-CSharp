using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface IImposto
    {
        public double Calcular(Orcamento orcamento);
    }
}
