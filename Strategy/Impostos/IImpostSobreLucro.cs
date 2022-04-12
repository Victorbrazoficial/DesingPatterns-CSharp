using Strategy.Investimentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface IImpostoSobreLucro
    {
        public double CalculaImpostoSobreSaldo(Conta conta);
        double Calcula(Conta conta);
    }
}
