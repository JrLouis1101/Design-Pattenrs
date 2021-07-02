using Decorator.Classes;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto icms = new ICMS(new ISS());

            Orcamento orcamento = new Orcamento(500);

            double valor = icms.Calcula(orcamento);

            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
}
