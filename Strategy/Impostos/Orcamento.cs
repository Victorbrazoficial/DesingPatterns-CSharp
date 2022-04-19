
using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Descontos;

namespace Strategy
{
    public class Orcamento
    {
        public double Valor { get; private set; }

        public List<Item> Itens { get; private set; }

        public double ValorTotalDosItens { get; set; }


        public Orcamento()
        {
            Itens = new List<Item>();     
        }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
