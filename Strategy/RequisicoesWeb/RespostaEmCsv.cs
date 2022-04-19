using System;
using Strategy.Investimentos;

namespace Strategy.RequisicoesWeb
{
    public class RespostaEmCsv : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public RespostaEmCsv(IResposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);

            OutraResposta.Responde(req, conta);
        }
    }
}