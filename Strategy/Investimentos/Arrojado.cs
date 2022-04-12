using Strategy.Excpetions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Investimentos
{
    public class Arrojado : IInvestimento
    {
        public int Random { get; private set; }

        public Arrojado(int random)
        {
            Random = random;
            if (Random < 0)
                throw new NumeroRandomNegativoException(random);
        }

        public Arrojado()
        {   
            Random = new Random().Next(101);
            
            Console.WriteLine(Random);
        }

        public double Calcula(Conta saldo)
        {
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
