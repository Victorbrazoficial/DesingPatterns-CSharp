using Strategy.Investimentos;

namespace Strategy.RequisicoesWeb
{
    public interface IResposta
    {
         public void Responde(Requisicao req, Conta conta);
         public IResposta OutraResposta { get; set; }
    }
}