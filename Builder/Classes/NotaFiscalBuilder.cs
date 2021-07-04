using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes
{
    public class NotaFiscalBuilder
    {
        public String RazaoSocial { get; set; }
        public String CNPJ { get; set; }
        public String Observacoes { get; set; }
        public DateTime DataAtual { get; set; }


        private double ValorTotal { get; set; }
        private double Impostos { get; set; }
        private IList<ItemDaNota> Itens = new List<ItemDaNota>(); 


        public NotaFiscal builder()
        {
            return new NotaFiscal(RazaoSocial, CNPJ, DataAtual, ValorTotal, Impostos, Itens, Observacoes);
        }
        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }
        public NotaFiscalBuilder ComCNPJ(String cnpj)
        {
            this.CNPJ = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String obs)
        {
            this.Observacoes = obs;
            return this;
        }
        public NotaFiscalBuilder NaDataAtual()
        {
            this.DataAtual = DateTime.Now;
            return this;
        }



        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            this.Itens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.02;
            return this;
        }



    }
}
