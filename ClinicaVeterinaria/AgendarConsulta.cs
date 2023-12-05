using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicaVeterinaria
{
    public partial class AgendarConsulta : Form
    {
        List<Medico> medicos;
        List<Animal> animais;
        List<Consultas> Consulta;
        GravarLer _gravarler;
        int contConsulta = 1;

        
        public AgendarConsulta(List<Consultas> consultas)
        {
            Consulta = consultas;
            InitializeComponent();
            ComboBoxMedico();
            ComboBoxAnimal();
            PreencherDataGrid();
            txt_idconsulta.Text = contConsulta.ToString();

            DateTimePicker date = new DateTimePicker();
            date.Format = DateTimePickerFormat.Short;
            date.ShowUpDown = true;
            dtp_dataConsulta.MinDate = DateTime.Now;
                        
            PreencherComboboxHora();
            Consultas novaconsulta = new Consultas();
            
        }


        /// <summary>
        /// Método que preenche o comboboxMedico com nome dos médicos registados utilizando o aquivo txt para extrair a informação.
        /// </summary>
        private void ComboBoxMedico()
        {
            string[] nome = File.ReadAllLines(@"InfoMedicos.txt");
            cbo_medico.Text = "[Selecione]";

            foreach (var medico in nome)
            {
                string[] dados = medico.Split(";");
                cbo_medico.Items.Add(dados[2]);

            }

        }

        /// <summary>
        /// Método utilizado para preencher o combobox Hora.
        /// </summary>
        private void PreencherComboboxHora()
        {
            List<TimeOnly> horaDisponivel = new List<TimeOnly>();
            TimeOnly startTime = new TimeOnly(8, 0); 
            TimeOnly endTime = new TimeOnly(18, 0); 
            TimeOnly horaAtual = startTime;
            while (horaAtual <= endTime)
            {
                horaDisponivel.Add(horaAtual);
                horaAtual = horaAtual.AddHours(1); 
            }
            cbo_hora.DataSource = horaDisponivel;
        }

               
        /// <summary>
        /// Evento que preenche o combobox hora definindo uma hora de inicio e hora fim 
        /// Informa que o horário foi escolhido caso o usuario pretenda agendar 2 consultas no mesmo horário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private Dictionary<TimeOnly, List<string>> _consultasAgendadas = new Dictionary<TimeOnly, List<string>>();
        private readonly object comboBoxLock = new object();
        private List<DateTime> Horamarcada = new List<DateTime>();
        private void cbo_hora_SelectedIndexChanged(object sender, EventArgs e)
        {
            lock (comboBoxLock)
            {
                if (cbo_hora.SelectedItem == null)
                {
                    MessageBox.Show("Selecione outro horário!", "Mensagem", MessageBoxButtons.OK);
                    return;
                }

                string Time_Start = "8:00";
                string Time_End = "18:00";
                TimeOnly time_Start = TimeOnly.Parse(Time_Start);
                TimeOnly time_End = TimeOnly.Parse(Time_End);
                TimeOnly horaselecionada = TimeOnly.Parse(cbo_hora.SelectedItem.ToString());
                DateTime dataselecionada = dtp_dataConsulta.Value.Date;

                if (Horamarcada.Any(h => h.Date == dataselecionada && h.TimeOfDay.Equals(horaselecionada)))
                {
                    MessageBox.Show("O horário selecionado não está disponível.", "Horário indisponível", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbo_hora.SelectedIndex = -1;
                }
                else
                {
                    Horamarcada.Add(new DateTime(dataselecionada.Year, dataselecionada.Month, dataselecionada.Day, horaselecionada.Hour, horaselecionada.Minute, 0));
                }
            }
                            
            
        }


        
        /// <summary>
        /// Método que preenche o comboboxAnimal com nome dos animais registados utilizando o aquivo txt para extrair a informação
        /// </summary>
        private void ComboBoxAnimal()
        {
            string[] nome = File.ReadAllLines(@"InfoAnimal.txt");
            cbo_animal.Text = "[Selecione]";

            foreach (var animal in nome)
            {
                string[] dados = animal.Split(";");
                cbo_animal.Items.Add(dados[0]);

            }

        }
        /// <summary>
        /// Método que preenche o comboboxTipoConsulta 
        /// </summary>
        private void CriarCBOTipoCnsulta()
        {
            cbo_tipoconsulta.Items.Add("Primeira Consulta");
            cbo_tipoconsulta.Items.Add("Acompanhamento");
            cbo_tipoconsulta.Items.Add("Urgência");
            cbo_tipoconsulta.Items.Add("Exame");
            cbo_tipoconsulta.Items.Add("Outro");

        }

       

        /// <summary>
        /// Botão que agenda consultas salvando os dados numa lista , depois de guardar limpa os dados para que possa ser feito novo agendamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_agendarconsulta_Click(object sender, EventArgs e)
        {

            Consultas novaconsulta;
            if (ValidaConsulta() == true)
            {
                novaconsulta = new Consultas
                {
                    IDConsulta = contConsulta,
                    Medico = cbo_medico.Text.ToString(),
                    Animal = cbo_animal.Text.ToString(),
                    Data = DateOnly.Parse(dtp_dataConsulta.Text),
                    Hora = TimeOnly.Parse(cbo_hora.Text),
                    Observacao = txt_obs.Text,
                    Tipo_Consulta = cbo_tipoconsulta.Text,

                };
                Consulta.Add(novaconsulta);
                contConsulta++;
                PreencherDataGrid();

                MessageBox.Show("Consulta agendada com sucesso!", "Mensagem", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os dados corretamente!", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            cbo_animal.Text = string.Empty;
            cbo_medico.Text = string.Empty;
            cbo_tipoconsulta.Text = string.Empty;
            dtp_dataConsulta.Text = string.Empty;
            cbo_hora.Text = string.Empty;
            txt_obs.Text = string.Empty;



        }
       
       
        /// <summary>
        /// Método que preenche e mostra os dados no datagridview
        /// </summary>
        private void PreencherDataGrid()
        {
            dgv_agenda.DataSource = null;
            dgv_agenda.DataSource = Consulta;
        }

        /// <summary>
        /// Método que faz a validação para confirmar se os dados foram inseridos corretamente 
        /// </summary>
        /// <returns></returns>
        private bool ValidaConsulta()
        {
            bool output = true;
            if (string.IsNullOrEmpty(cbo_medico.Text))
            {
                MessageBox.Show("Escolha o nome do Médico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(cbo_animal.Text))
            {
                MessageBox.Show("Escolha o Nome do Animal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(cbo_tipoconsulta.Text))
            {
                MessageBox.Show("Insira o Tipo da Consulta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;

            }

            if (string.IsNullOrEmpty(dtp_dataConsulta.Text))
            {
                MessageBox.Show("Escolha a Data da Consulta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;

            }
            if (string.IsNullOrEmpty(cbo_hora.Text))
            {
                MessageBox.Show("Insira a Hora da consulta !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;

            }


            return output;
        }
        /// <summary>
        /// Evento que mostra o datagridview e o combobox tipo conculta já preenchidos ao abri o form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgendarConsulta_Load(object sender, EventArgs e)
        {
            PreencherDataGrid();
            CriarCBOTipoCnsulta();
            PreencherComboboxHora();
               
        }


        /// <summary>
        /// Botão que cancela e apaga a consulta selecionada 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Consultas cancelarconsulta = (Consultas)dgv_agenda.SelectedRows[0].DataBoundItem;
            Consultas cancelada = null;

            if (cancelarconsulta != null)
            {
                foreach (Consultas consulta in Consulta)
                {
                    if (cancelarconsulta.IDConsulta == consulta.IDConsulta)
                    {
                        cancelada = consulta;
                    }
                }
            }
            if (cancelada != null)
            {
                DialogResult resposta;
                resposta = MessageBox.Show($"Tem a certeza que pretende cancelar a consulta?",
                                            "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult.OK == resposta)
                {
                    Consulta.Remove(cancelada);
                    PreencherDataGrid();
                }
            }

        }       

        

        
    }
}
