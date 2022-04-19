using System;
using Strategy.Investimentos;

namespace Strategy.RequisicoesWeb
{
    public class RespostaEmPorcento : IResposta
    {
        public IResposta OutraResposta { get; set; }

        
        public RespostaEmPorcento(IResposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);

            OutraResposta.Responde(req, conta);
        }
    }
}