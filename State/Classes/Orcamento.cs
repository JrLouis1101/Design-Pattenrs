using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Classes
{
    public class Orcamento
    {
        public double valor { get; set; }
        public IList<Item> Itens { get; private set; }

        public EstadoDeUmOrcamento EstadoAtual { get; set; }

        public Orcamento(double valor)
        {
            this.valor = valor;
            Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void aplicaDescontoExtra()
        {
            EstadoAtual.descontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }
        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finalizada()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
