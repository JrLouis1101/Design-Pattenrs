using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Classes
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void descontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentro Finalizado n recebe desconto extra");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já finalizado");
        }


        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Ja foi finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Ja foi finalizado");

        }

    }
}
