using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Classes
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void descontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentro reprovado n recebe desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já Reprovado");
        }


        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Ja foi Reprovado");

        }
    }
}
