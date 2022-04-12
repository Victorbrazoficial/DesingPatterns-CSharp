using Strategy.Impostos;
using Strategy.Investimentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class IR : IImposto, IImpostoSobreLucro, IImpostoSobreSaldo
    {
        private const double Ir = 0.25;

        public double Calcula(Conta conta)
        {
            conta.Imposto += conta.Lucro * Ir;
            return conta.Imposto;
        }

        public double CalculaImpostoSobreSaldo(Conta conta)
        {
            conta.Imposto += conta.Saldo * Ir;
            return conta.Imposto;
        }

        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * Ir;
        }
    }
}
