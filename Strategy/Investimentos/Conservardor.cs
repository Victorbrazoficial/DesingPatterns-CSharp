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
            if (saldo.Saldo < 0)
                throw new SaldoNegativoException(saldo.Saldo);

            if (saldo.Saldo == 0)
                throw new SaldoZeradoException(saldo.Saldo);

            return (saldo.Saldo * 0.008);
        }
    }
}
