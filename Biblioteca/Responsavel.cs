using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Biblioteca
{
    public class Responsavel
    {
        public int Id { get; set; }
       
        public string NomeResponsavel { get; set; }
        public string Apelido { get; set; }
        
        public string Telemovel { get; set; }
        public string Email { get; set; }

        public string Nif { get; set; }



        public string DadosResponsavel
        {
            get
            {
                return $"{Id};{NomeResponsavel};{Apelido}";
            }
                      

        }
      

        public string[] Split(string v)
        {
            return NomeResponsavel.Split(v);
        }

        public override string ToString()
        {
            return $"{Id};{NomeResponsavel};{Apelido};{Telemovel};{Email};{Nif}";
        }

        
        
    }
}
