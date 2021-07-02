using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Classes
{
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto) { }
        public ISS() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.valor * 0.01 + CalculoDoOutroImposto(orcamento);
        }

   

    }
}
