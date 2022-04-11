using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Investimentos
{
    public class Conservardor : IInvestimento
    {
        public double Caulcula(Conta saldo)
        {
            if (saldo.Saldo <= 0)
                throw new ArgumentException("Saldo menor ou igual a 0.", nameof(saldo));

            return (saldo.Saldo * 0.008);
        }
    }
}
