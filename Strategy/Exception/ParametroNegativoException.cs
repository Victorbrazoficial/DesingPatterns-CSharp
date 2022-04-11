using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Excpetions
{
    public class ParametroNegativoException : Exception
    {
        public ParametroNegativoException(double valor) : this("Deposito negativo. Valor paramentro = " + valor + ".")
        {

        }

        public ParametroNegativoException(string mensagem) : base(mensagem)
        {

        }

        public ParametroNegativoException()
        {

        }

        public ParametroNegativoException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        {

        }
    }
}
