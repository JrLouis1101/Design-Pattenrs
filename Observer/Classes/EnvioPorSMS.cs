using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classes
{
    public class EnvioPorSMS : AcaoAposGerarNota
    {

        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Envia por sms");
        }
    }
}
