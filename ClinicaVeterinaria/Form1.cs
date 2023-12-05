using Biblioteca;

namespace ClinicaVeterinaria
{
    public partial class Form1 : Form
    {
        GravarLer gravarler = new GravarLer();
        
        List<Responsavel> Responsaveis;
        List<Animal> Animais;
        List<Medico> Medicos;
        List<Consultas> Consulta;
        List<PossiveisClientes> Clientes;

        int contaResponsavel;
        int contMedico;
        int contConsulta;
        public Form1()
        {
            gravarler = new GravarLer();
            Clientes = new List<PossiveisClientes>();
            InitializeComponent();
            Responsaveis = gravarler!.LerResponsaveis(contaResponsavel);
            Animais = gravarler!.LerAnimal(Responsaveis);
            Medicos= gravarler!.LerMedicos(contMedico);
            Consulta = gravarler!.LerConsultas(contConsulta);
            Clientes = gravarler!.LerPossiveisClientes(Clientes);
           
        }

        /// <summary>
        /// Botão que abre o form de registo e gestão do responsável dos animais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn_GerirPaciente_Click(object sender, EventArgs e)
        {
            
            this.panelChild.Controls.Clear();
            GerirPaciente gerirPaciente = new GerirPaciente(Responsaveis, contaResponsavel) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            gerirPaciente.FormBorderStyle = FormBorderStyle.None;
            this.panelChild.Controls.Add(gerirPaciente);                    
            gerirPaciente.Show();
            
        }

               
        /// <summary>
        /// Botão que fecha a aplicação 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Botão que abre o fomr de registo e gestão dos animais 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RegistarAnimal_Click(object sender, EventArgs e)
        {
            
            this.panelChild.Controls.Clear();
            RegistarPet registarPet = new RegistarPet(Animais, Responsaveis) {Dock = DockStyle.Fill, TopLevel = false, TopMost=true};
            registarPet.FormBorderStyle = FormBorderStyle.None;
            this.panelChild.Controls.Add(registarPet);
            registarPet.Show();
        }
        /// <summary>
        /// Botão que abre o form de registo e gestão dos médicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GerirMedico_Click(object sender, EventArgs e)
        {
            
           
            this.panelChild.Controls.Clear();
            RegistoMedicos registoMedico = new RegistoMedicos(Medicos) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            registoMedico.FormBorderStyle = FormBorderStyle.None;
            this.panelChild.Controls.Add(registoMedico);
            registoMedico.Show();
        }
        /// <summary>
        /// Botão que abre o form que agenda consulta, mostra agenda e faz a comunicação com o cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GerirConsultas_Click(object sender, EventArgs e)
        {           
            
            this.panelChild.Controls.Clear();
            AgendarConsulta agenda = new AgendarConsulta(Consulta) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            agenda.FormBorderStyle = FormBorderStyle.None;
            this.panelChild.Controls.Add(agenda);
            agenda.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.panelChild.Controls.Clear();
            ContatoComCliente contato = new ContatoComCliente(Clientes) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            contato.FormBorderStyle = FormBorderStyle.None;
            this.panelChild.Controls.Add(contato);
            contato.Show();
        }
        /// <summary>
        /// Evento que faz a gravação dos ficheiros ao fechar a aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            gravarler.GravarResponsavel(Responsaveis);
            gravarler.GravarAnimal(Animais);
            gravarler.GravarMedico(Medicos);
            gravarler.GravarConsulta(Consulta);
            gravarler.GravarPossiveisClientes(Clientes);
        }

        /// <summary>
        /// Evento que move o panel utilizado para indicar o form escolhido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GerirPaciente_MouseHover(object sender, EventArgs e)
        {
            panel2.Show();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        /// <summary>
        ///Evento que move o panel utilizado para indicar o form escolhido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RegistarAnimal_MouseHover(object sender, EventArgs e)
        {
            panel3.Show();
            panel2.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        /// <summary>
        /// Evento que move o panel utilizado para indicar o form escolhido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GerirMedico_MouseHover(object sender, EventArgs e)
        {
            panel4.Show();
            panel3.Hide();
            panel2.Hide();
            panel5.Hide();
            panel6.Hide();
        }
        /// <summary>
        /// Evento que move o panel utilizado para indicar o form escolhido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GerirConsultas_MouseHover(object sender, EventArgs e)
        {
            panel5.Show();
            panel6.Hide();
            panel4.Hide();
            panel3.Hide();
            panel2.Hide();
        }
        /// <summary>
        /// Evento que move o panel utilizado para indicar o form escolhido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseHover(object sender, EventArgs e)
        {
            panel6.Show();
            panel3.Hide();
            panel2.Hide();
            panel4.Hide();
            panel5.Hide();
        }
    }
}