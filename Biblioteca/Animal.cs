using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Biblioteca
{
    public class Animal
    {
        public string NomeAnimal { get; set; }
        public string Especie { get; set; }

        public string Raça { get; set; }

        public int Idade { get; set; }

        public string Porte { get; set; }

        public string Observacoes { get; set; }

           
        
        

        public override string ToString()
        {
            return $"{NomeAnimal};{Especie};{Raça};{Idade};{Porte};{Observacoes}";
        }
    }
}
