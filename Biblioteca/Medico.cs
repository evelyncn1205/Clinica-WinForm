using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Medico
    {
        public int IDMedico { get; set; }

        public int Sala { get; set; }
        public string NomeMedico { get; set;}

        public string ApelidoMedico { get; set;}
                
        public int NifMedico { get; set;}

        public string TlmMedico { get; set;}

        public string Morada { get; set;}

          

        

        public override string ToString()
        {
            return $"{IDMedico};{Sala};{NomeMedico};{ApelidoMedico};{NifMedico};{TlmMedico};{Morada}";
        }
    }

    
}
