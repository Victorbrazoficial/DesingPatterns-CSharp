using System;

namespace Strategy.Descontos
{
    public class DescontoPorMaisDeQuinhetosReais : IDescontos
    {
        public IDescontos Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor >= 500)
            {
                Console.WriteLine("Desconto mais de 500 reais;");
                return orcamento.Valor * 0.07;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}