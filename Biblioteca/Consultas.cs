using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Biblioteca
{
    public  class Consultas
    {
        public int IDConsulta { get; set; }
        public string Medico { get; set; }
     
        public string Animal { get; set; }
        public DateOnly Data { get; set; }

        public string Tipo_Consulta { get; set; }
        public TimeOnly Hora { get; set; }
        public string Observacao { get; set; }


        
        public override string ToString()
        {
            return $"{IDConsulta};{Medico};{Animal};{Tipo_Consulta};{Data};{Hora};{Observacao}";
        }

        
    }
}
