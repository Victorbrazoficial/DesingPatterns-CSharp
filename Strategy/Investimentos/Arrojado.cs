using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Investimentos
{
    public class Arrojado : IInvestimento
    {
        public double Caulcula(Conta saldo)
        {
            
            int _escolhido = new Random().Next(101);

            Console.WriteLine(_escolhido);

            if (_escolhido <= 20)
            {
                return (saldo.Saldo * 0.05);

            }
            else
            {
                if ((_escolhido > 20) && (_escolhido <= 30))
                {
                    return (saldo.Saldo * 0.03);
                }

                return (saldo.Saldo * 0.006);
            }
        }
    }
}
