using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double ImpostoCalculado = imposto.Calcular(orcamento);
            Console.WriteLine(ImpostoCalculado);
        }
    }
}
