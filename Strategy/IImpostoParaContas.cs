using Strategy.Investimentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface IImpostoSobreLucro
    {
        public double Calcula(RealizadorDeInvestimento realizadorDeInvestimento);
    }
}
