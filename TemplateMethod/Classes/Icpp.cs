using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Interfaces;

namespace TemplateMethod.Classes
{
    public class Icpp : TemplateDeImpostoCondicional
    {

        public override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.valor >= 500;

        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor * 0.07;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor * 0.05;
        }
    }
}
