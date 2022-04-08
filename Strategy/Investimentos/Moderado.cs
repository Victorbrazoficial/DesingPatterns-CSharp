using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Investimentos
{
    public class Moderado : IInvestimento
    {

        private bool _escolhido;

        public Moderado()
        {
            _escolhido = new Random().Next(101) > 50;
        }
        public double Caulcula(Conta saldo)
        {
            
            Console.WriteLine(_escolhido);

            if (_escolhido)
            {
                return (saldo.Saldo * 0.025);
            }
            return (saldo.Saldo * 0.007);
        }
    }
}
