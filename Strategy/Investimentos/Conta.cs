using System;

namespace Strategy.Investimentos
{
    public class Conta
    {
        public double Saldo { get; private set; } 

        public Conta()
        {
            
        }

        public void Deposita(double valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor de deposito menor ou igual a 0.", nameof(valor));

            Saldo += valor;
        }
    }
}