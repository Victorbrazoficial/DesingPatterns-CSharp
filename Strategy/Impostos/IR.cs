using Strategy.Investimentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class IR : IImposto, IImpostoSobreLucro
    {
        public double Calcula(Conta conta)
        {
            return conta.Lucro * 0.25;
        }

        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.25;
        }
    }
}
