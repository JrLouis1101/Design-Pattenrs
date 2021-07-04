using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Classes
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        public void descontoExtra(Orcamento orcamento)
        {
            orcamento.valor -= orcamento.valor * 0.02;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já aprovado");
        }


        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Ja foi aprovado");
            
        }

    }
}
