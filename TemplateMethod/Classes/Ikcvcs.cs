using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Classes
{
    class Ikcvcs : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.valor >= 500 && PossuiItemMaiorQue100Reais(orcamento);
           
        }
     
        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor * 0.1;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor * 0.06;
        }

        public Boolean PossuiItemMaiorQue100Reais(Orcamento orcamento)
        {
            
            return orcamento.Equals(
        }
    }
}
