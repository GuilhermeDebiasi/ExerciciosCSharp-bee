using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças
{
    internal class Pessoa
    {
        public string Cpf { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public virtual string ObterNomeCompleto()
        {
            return $"{Nome} {Sobrenome}";
        }

    }
}
