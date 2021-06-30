using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Interfaces;

namespace TemplateMethod.Classes
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (DeveUsarTaxacaoMaxima(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }

        public abstract bool DeveUsarTaxacaoMaxima(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
