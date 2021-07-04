using Observer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interfaces
{
    public interface AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf);
    }
}
