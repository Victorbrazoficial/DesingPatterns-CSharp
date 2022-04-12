using Strategy.Investimentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Impostos
{
    public interface IImpostoSobreSaldo
    {
        public double Calcula(Conta conta);
    }
}
