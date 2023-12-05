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

namespace ClinicaVeterinaria
{
    public partial class RegistoMedicos : Form
    {
        GravarLer gravarler = new GravarLer();
        
        List<Medico> Medicos;

        int contMedico = 1;
        public RegistoMedicos(List<Medico>medicos)
        {
            InitializeComponent();
            Medicos = medicos;
            txt_idmedico.Text= contMedico.ToString();
            InitiDatagridMedico();
        }

        /// <summary>
        /// Botão que regista os dados dos medicos inserindo-os em uma lista, depois de guardar limpa a texbox e a maskedbom para que possa inserir novos dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_guardarMedico_Click(object sender, EventArgs e)
        {
            Medico novoMedico;
            if (ValidaInformacao() == true)
            {
                novoMedico = new Medico
                {
                    IDMedico = contMedico,
                    NomeMedico = txt_nomemedico.Text,
                    ApelidoMedico = txt_apelidomedico.Text,
                    Morada = txt_moradamedico.Text,
                    NifMedico = Convert.ToInt32(maskedNifmedico.Text),
                    TlmMedico = masked_TelMedico.Text.ToString(),
                    Sala = Convert.ToInt32(txt_sala.Text)
                };
                Medicos.Add(novoMedico);
                contMedico++;
                InitiDatagridMedico();
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os dados corretamente!", "Erro", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            txt_nomemedico.Text = string.Empty;
            txt_apelidomedico.Text = string.Empty;
            txt_moradamedico.Text = string.Empty;
            maskedNifmedico.Text = string.Empty;
            masked_TelMedico.Text = string.Empty;
            txt_sala.Text = string.Empty;

        }
        /// <summary>
        /// Método que inicializa o datagriedview e apresenta as informações registadas
        /// </summary>
        public void InitiDatagridMedico()
        {
            DGV_Medico.DataSource = null;
            DGV_Medico.DataSource = Medicos;
        }

        /// <summary>
        /// Método que faz a validação para confirmar se os dados foram inseridos corretamente 
        /// </summary>
        /// <returns></returns>
        private bool ValidaInformacao()
        {
            bool output = true;
            if (string.IsNullOrEmpty(txt_idmedico.Text))
            {
                MessageBox.Show("Insira nome Id !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_sala.Text))
            {
                MessageBox.Show("Insira a Sala de Atendimento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_nomemedico.Text))
            {
                MessageBox.Show("Insira o Nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txt_apelidomedico.Text))
            {
                MessageBox.Show("Insira o Apelido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;

            }
            if (string.IsNullOrEmpty(txt_moradamedico.Text))
            {
                MessageBox.Show("Insira a Morada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;

            }
            if (string.IsNullOrEmpty(maskedNifmedico.Text))
            {
                MessageBox.Show("Insira o NIF", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(masked_TelMedico.Text))
            {
                MessageBox.Show("Insira o Telefone!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            
            return output;
        }
        /// <summary>
        /// Boão que abre o form para editar os dados 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editarMedico_Click(object sender, EventArgs e)
        {
            Medico editarMedico = (Medico)DGV_Medico.SelectedRows[0].DataBoundItem;
            Medico edicaoMedico = null;
            if(editarMedico != null)
            {
               foreach(Medico medico in Medicos)
               {
                    if(editarMedico.IDMedico== editarMedico.IDMedico)
                    {
                        edicaoMedico = medico;
                    }
               }
               
            }
            EditarDadosMedico editarDados = new EditarDadosMedico(this, edicaoMedico);
            editarDados.ShowDialog();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistoMedicos_Load(object sender, EventArgs e)
        {
            InitiDatagridMedico();
        }

        
    }
}
