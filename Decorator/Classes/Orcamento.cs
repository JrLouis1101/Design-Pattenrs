using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Classes
{
    public class Orcamento
    {
       
            public double valor { get; set; }
            public IList<Item> Itens { get; private set; }

            public Orcamento(double valor)
            {
                this.valor = valor;
                Itens = new List<Item>();
            }

            public void AdicionaItem(Item item)
            {
                Itens.Add(item);
            }
        
    }
}
