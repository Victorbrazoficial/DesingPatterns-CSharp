using System;
using Strategy.Investimentos;

namespace Strategy.RequisicoesWeb
{
    public class RespostaEmXml : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public RespostaEmXml(IResposta outraResposta)
        {
            OutraResposta = outraResposta;
        }
        
        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");

            OutraResposta.Responde(req, conta);
        }
    }
}