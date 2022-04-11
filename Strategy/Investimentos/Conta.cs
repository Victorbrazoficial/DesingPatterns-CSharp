using Strategy.Excpetions;
using System;

namespace Strategy.Investimentos
{
    public class Conta
    {
        public double Saldo { get; private set; } 

        public double Lucro { get; set; }

        public Conta()
        {
            
        }

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Deposita(double valor)
        {
            if (valor < 0)
                throw new ParametroNegativoException(valor);

            if (valor == 0)
                throw new ParametroZeradoException(valor);
            Saldo += valor;
            
        }
    }
}