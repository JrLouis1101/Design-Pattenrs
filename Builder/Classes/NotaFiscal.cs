using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes
{
    public class NotaFiscal
    {
        public String RazaoSocial {get; set;}
        public String CNPJ{get; set;}
        public DateTime DataDeEmissao{get; set;}
        public double  ValorBruto{get; set;}
        public double Impostos{get; set;}
        public IList<ItemDaNota> Itens {get; set;}
        public String Observacoes{ get; set; }

        public NotaFiscal(string razaoSocial, string cNPJ, DateTime dataDeEmissao, double valorBruto, double impostos, IList<ItemDaNota> itens, string observacoes)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            DataDeEmissao = dataDeEmissao;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Itens = itens;
            Observacoes = observacoes;
        }
    }
}
