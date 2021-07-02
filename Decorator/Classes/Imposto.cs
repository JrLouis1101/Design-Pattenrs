using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Classes
{
    public abstract class Imposto
    {

        public Imposto outroImposto { get; set; }

        public Imposto(Imposto imposto)
        {
            this.outroImposto = imposto;
        }

        public Imposto()
        {
            this.outroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);
        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (outroImposto == null) return 0;
            return outroImposto.Calcula(orcamento);
        }

    }
}
