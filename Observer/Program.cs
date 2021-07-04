using Observer.Classes;
using System;

namespace Observer
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

            builder.AddAcao(new EnvioPorEmail());
            builder.AddAcao(new NotaFiscalDao());
            builder.AddAcao(new EnvioPorSMS());

            NotaFiscal nf = builder.builder();

        }
    }
}
