using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Excpetions
{
    public class NumeroRandomNegativoException : Exception
    {
        public NumeroRandomNegativoException(double valor) : this("Numero Random negativo. Valor paramentro = " + valor + ".")
        {

        }

        public NumeroRandomNegativoException(string mensagem) : base(mensagem)
        {

        }

        public NumeroRandomNegativoException()
        {

        }

        public NumeroRandomNegativoException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        {

        }
    }
}
