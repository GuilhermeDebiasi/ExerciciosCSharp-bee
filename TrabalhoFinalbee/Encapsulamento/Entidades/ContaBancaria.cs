using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento.Entidades
{
    internal class ContaBancaria
    {
        public int Valor { get; set; }
        public decimal Saldo { get; set; }
        public Pessoa Pessoa { get; set; }

    }
}
