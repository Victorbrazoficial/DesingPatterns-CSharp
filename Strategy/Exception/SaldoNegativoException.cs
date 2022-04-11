using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Excpetions
{
    public class SaldoNegativoException : Exception
    {
        public SaldoNegativoException(double valor) : this("Saldo negativo. Valor paramentro = " + valor + ".")
        {

        }

        public SaldoNegativoException(string mensagem) : base(mensagem)
        {

        }

        public SaldoNegativoException()
        {

        }

        public SaldoNegativoException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        {

        }
    }
}
