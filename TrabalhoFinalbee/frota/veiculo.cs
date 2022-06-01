using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frota
{
    internal class veiculo
    {
        public string placa, marca, modelo;

        public string ObterDescricao(string placa, string modelo)
        {

            return modelo + "(" + placa + ")";
        }
    }
   
    
       
    }

