using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace chainOfResponsabilityExample.Models
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public Double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}

