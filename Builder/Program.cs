using System;
using Builder.Classes;
namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            builder.ParaEmpresa("empresa nome")
                   .ComCNPJ("1233132312")
                   .ComItem(new ItemDaNota("bola", 50.50))
                   .ComObservacoes("obs1")
                   .NaDataAtual();
            NotaFiscal nf = builder.builder();

        }
    }
}
