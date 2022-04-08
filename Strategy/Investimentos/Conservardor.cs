using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Investimentos
{
    public class Conservardor : IInvestimento
    {
        public double Caulcula(Conta saldo)
        {
            return (saldo.Saldo * 0.008);
        }
    }
}
