using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Investimentos
{
    public class Arrojado : IInvestimento
    {
        public int Random { get; private set; }
        public double Caulcula(Conta saldo)
        {
            if (saldo.Saldo <= 0 )
                throw new ArgumentException("Saldo menor ou igual a 0.", nameof (saldo));

            Random = new Random().Next(101);
            Console.WriteLine(Random);

            if (Random <= 20)
            {
                return (saldo.Saldo * 0.05);

            }
            else
            {
                if ((Random > 20) && (Random <= 30))
                {
                    return (saldo.Saldo * 0.03);
                }

                return (saldo.Saldo * 0.006);
            }
        }
    }
}
