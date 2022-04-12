using Strategy.Excpetions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Investimentos
{
    public class Conservardor : IInvestimento
    {
        public double Calcula(Conta saldo)
        {
            return (saldo.Lucro * 0.008);
        }
    }
}
