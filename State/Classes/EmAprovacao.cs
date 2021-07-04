using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace State.Classes
{
    public class EmAprovacao : EstadoDeUmOrcamento
    {
      
        public void descontoExtra(Orcamento orcamento)
        {
            orcamento.valor -= orcamento.valor * 0.05;
        }
        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }


        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Não pode ir de em aprovação para finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}
