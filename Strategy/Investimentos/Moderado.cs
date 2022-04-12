using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Investimentos
{
    public class Moderado : IInvestimento
    {
        public bool Random { get; private set; }

        public Moderado(bool random)
        {
            Random = random;
        }

        public Moderado()
        {
            Random = new Random().Next(101) > 50;
        }

        public double Calcula(Conta saldo)
        {       
            Console.WriteLine(Random);

            if (Random)
            {
                return (saldo.Saldo * 0.025);
            }
            return (saldo.Saldo * 0.007);
        }
    }
}
