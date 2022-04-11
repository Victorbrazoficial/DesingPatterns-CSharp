using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Excpetions
{
    public class ParametroZeradoException : Exception
    {
        public ParametroZeradoException(double valor) : this("Deposito Zerado. Valor paramentro = " + valor + ".")
        {

        }

        public ParametroZeradoException(string mensagem) : base(mensagem)
        {

        }

        public ParametroZeradoException()
        {

        }

        public ParametroZeradoException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        {

        }
    }
}
