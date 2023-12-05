using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PossiveisClientes
    {
        public string Nome_Cliente { get; set; }
        public string Telemovel_Cliente { get; set; }

        public string Email_Cliente { get; set; }

        public string Motivo { get; set; }


        public override string ToString()
        {
            return $"{Nome_Cliente};{Telemovel_Cliente};{Email_Cliente};{Motivo}";
        }
    }
}
