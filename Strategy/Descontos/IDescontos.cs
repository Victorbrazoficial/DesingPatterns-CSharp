namespace Strategy.Descontos
{
    public interface IDescontos
    {
         public IDescontos Proximo { get; set; }

         public double Desconta(Orcamento orcamento);
    }
}