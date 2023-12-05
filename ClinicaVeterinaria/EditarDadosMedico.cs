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
    public partial class EditarDadosMedico : Form
    {
        Medico _medicos;
        List<Medico> MedicoList;
        RegistoMedicos _formregistoMedico;
        public EditarDadosMedico(RegistoMedicos formregistoMedicos, Medico edicaoMedico)
        {
            InitializeComponent();
            _formregistoMedico = formregistoMedicos;
            _medicos = edicaoMedico;
            txt_nomeMedico.Text = edicaoMedico.NomeMedico.ToString();
            txt_apelidoMedico.Text = edicaoMedico.ApelidoMedico.ToString();
            txt_moradaMedico.Text = edicaoMedico.Morada.ToString();
            txt_nifMedico.Text = edicaoMedico.NifMedico.ToString();
            masked_tlmMedico.Text = edicaoMedico.TlmMedico.ToString();

        }
        /// <summary>
        /// Botão que confirma e grava as edições feitas e atualiza os dados na datagridview no form gerir médico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_guardareditMedico_Click(object sender, EventArgs e)
        {
            if(ValidaInformacao())
            {
                _medicos.NomeMedico= txt_nomeMedico.Text;
                _medicos.ApelidoMedico= txt_apelidoMedico.Text;
                _medicos.NifMedico=int.Parse(txt_nifMedico.Text);
                _medicos.TlmMedico= masked_tlmMedico.Text;
                _medicos.Morada = txt_moradaMedico.Text;
                _formregistoMedico.InitiDatagridMedico();
                this.Close();
            }

        }
        /// <summary>
        /// Método que faz a validação para confirmar se os dados foram inseridos corretamente 
        /// </summary>
        /// <returns></returns>
        private bool ValidaInformacao()
        {
            bool output = true;

            if (string.IsNullOrEmpty(txt_nomeMedico.Text))
            {
                MessageBox.Show("Insira o Nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txt_apelidoMedico.Text))
            {
                MessageBox.Show("Insira o Apelido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;

            }
            if (string.IsNullOrEmpty(txt_moradaMedico.Text))
            {
                MessageBox.Show("Insira a Morada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;

            }
            if (string.IsNullOrEmpty(txt_nifMedico.Text))
            {
                MessageBox.Show("Insira o NIF", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(masked_tlmMedico.Text))
            {
                MessageBox.Show("Insira o Telefone!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
        /// <summary>
        /// Botão que fecha o form editar médico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
