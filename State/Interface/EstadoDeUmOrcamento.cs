using State.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Interface
{
    public interface EstadoDeUmOrcamento
    {
        public void descontoExtra(Orcamento orcamento);

        public void Aprova(Orcamento orcamento);
        public void Reprova(Orcamento orcamento);
        public void Finaliza(Orcamento orcamento);
    }
}
