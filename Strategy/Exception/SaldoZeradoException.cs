using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Excpetions
{
    public class SaldoZeradoException : Exception
    {
        public SaldoZeradoException(double valor) : this("Saldo zerado. Valor paramentro = " + valor + ".")
        {

        }

        public SaldoZeradoException(string mensagem) : base(mensagem)
        {

        }

        public SaldoZeradoException()
        {

        }

        public SaldoZeradoException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        {

        }
    }
}
