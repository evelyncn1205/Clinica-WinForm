using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class GravarLer
    {
        Animal animais;
        List<PossiveisClientes> clientes;
        

        public void GravarResponsavel(List<Responsavel> responsaveis)
        {
            string ficheiro = @"InfoResponsaveis.txt";

            using (TextWriter tw = new StreamWriter(ficheiro)) 
            {
                foreach (Responsavel responsavel in responsaveis)
                {
                    tw.WriteLine(responsavel.ToString());
                }
            }

        }

        public List<Responsavel> LerResponsaveis(int cont)
        {
            List<Responsavel> R = new List<Responsavel>();
            string ficheiro = @"InfoResponsaveis.txt";
            StreamReader sr = new StreamReader(ficheiro);
            Responsavel responsaveis;
            if (File.Exists(ficheiro))
            {
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    string[] campos = s.Split(";");

                    if (s != null)
                    {
                        responsaveis = new Responsavel
                        {
                           Id = Convert.ToInt32(campos[0]),
                           NomeResponsavel = campos[1],
                           Apelido = campos[2],
                           Telemovel = campos[3],
                           Email = campos[4],
                           Nif = campos[5],
                        };
                        R.Add(responsaveis);

                    }

                }
            }
            foreach (Responsavel r in R)
            {
              if (r.Id >= cont)
              {
                cont = r.Id + 1;
              }
            }
            sr.Close();                   
            
            return R;

        }



        public void GravarAnimal(List<Animal> animais)
        {
            string ficheiro = @"InfoAnimal.txt";
            
            using (TextWriter tw = new StreamWriter(ficheiro))
            {
                foreach (Animal animal in animais)
                {
                    tw.WriteLine(animal.ToString());
                }
            }

        }       
                   

        public List<Animal> LerAnimal (List<Responsavel> Responsaveis)
        {
            List<Animal> A = new List<Animal>();
            string ficheiro = @"InfoAnimal.txt";
            StreamReader sr;
            Animal animais;
                    
            sr = File.OpenText(ficheiro);
           while (!sr.EndOfStream)
           {
              string s = sr.ReadLine();
              string[] campos = s.Split(";");
              if (s != null)
              {
                        
                 animais = new Animal
                 {                            
                    NomeAnimal = campos[0],
                    Especie = campos[1],
                    Raça = campos[2],
                    Idade = Convert.ToInt32(campos[3]),
                    Porte = campos[4],
                    Observacoes = campos[5],
                 };

                A.Add(animais);
              }

           }
           
               
            sr.Close();            
                                     
            return A;

        }

        public void GravarMedico(List<Medico> medicos)
        {
            string ficheiro = @"InfoMedicos.txt";

            using (TextWriter tw = new StreamWriter(ficheiro))
            {
                foreach (Medico medico in medicos)
                {
                    tw.WriteLine(medico.ToString());
                }
            }

        }

        public List<Medico> LerMedicos(int contM)
        {
            List<Medico>M = new List<Medico>();
            string ficheiro = @"InfoMedicos.txt";
            StreamReader sr;
            Medico medicos;
            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    string[] campos = s.Split(";");
                    if (s != null)
                    {
                        medicos = new Medico
                        {
                            IDMedico = Convert.ToInt32(campos[0]),
                            Sala = Convert.ToInt32(campos[1]),
                            NomeMedico = campos[2],
                            ApelidoMedico = campos[3],
                            NifMedico = Convert.ToInt32(campos[4]),
                            TlmMedico = campos[5],
                            Morada= campos[6],
                            
                        };

                        M.Add(medicos);
                    }

                }
                foreach(Medico medico in M)
                {
                    if(medico.IDMedico >= contM)
                    {
                        contM = medico.IDMedico + 1;
                    }
                }
                sr.Close();
            }
            else M = new List<Medico>();
            return M;

        }


        public void GravarConsulta(List<Consultas> consultas)
        {
            string ficheiro = @"AgendaConsulta.txt";

            using (TextWriter tw = new StreamWriter(ficheiro))
            {
                foreach (Consultas consulta in consultas)
                {
                    tw.WriteLine(consulta.ToString());
                }
            }

        }
        public List<Consultas> LerConsultas(int contaConsulta)
        {
            List<Consultas> C = new List<Consultas>();
            string ficheiro = @"AgendaConsulta.txt";
            StreamReader sr;
            Consultas consultas;
            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    string[] campos = s.Split(";");
                    if (s != null)
                    {
                        consultas = new Consultas
                        {   
                            IDConsulta = Convert.ToInt32(campos[0]),
                            Medico = campos[1],
                            Animal = campos[2],
                            Tipo_Consulta = campos[3],
                            Data = DateOnly.Parse(campos[4]),
                            Hora = TimeOnly.Parse(campos[5]),
                            Observacao = campos[6],
                           
                        };

                       C.Add(consultas);
                    }

                }
                foreach(Consultas consulta in C)
                {
                    if(consulta.IDConsulta >= contaConsulta)
                    {
                        contaConsulta = consulta.IDConsulta + 1;
                    }
                }
                sr.Close();
            }
            else C = new List<Consultas>();
            return C;
            
        }


        public void GravarPossiveisClientes(List<PossiveisClientes> clientes)
        {
            string ficheiro = @"PossiveisClientes.txt";

            using (TextWriter tw = new StreamWriter(ficheiro))
            {
                foreach (PossiveisClientes pc in clientes)
                {
                    tw.WriteLine(pc.ToString());
                }
            }
            

        }

        public List<PossiveisClientes> LerPossiveisClientes(List<PossiveisClientes> PC)
        {                
                    
            string ficheiro = @"PossiveisClientes.txt";
            StreamReader sr;
            PossiveisClientes clientes;

            sr = File.OpenText(ficheiro);
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                string[] campos = s.Split(";");
                if (s != null)
                {
                    clientes = new PossiveisClientes
                    {
                        Nome_Cliente = campos[0],
                        Telemovel_Cliente = campos[1],
                        Email_Cliente = campos[2],
                        Motivo = campos[3],
                    };

                    PC.Add(clientes);

                }
                
            }

            sr.Close();

            return PC;
        }
    }
}
