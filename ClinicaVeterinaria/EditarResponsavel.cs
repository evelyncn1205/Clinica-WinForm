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
    public partial class EditarResponsavel : Form
    {
        Responsavel _editResponsavel;
        List<Responsavel> _responsavelList;
        GerirPaciente _formgerir;
        public EditarResponsavel(GerirPaciente formgerir, Responsavel editresponsavel)
        {
            InitializeComponent();
            _editResponsavel = editresponsavel;
            _formgerir = formgerir;
            txt_id.Text= editresponsavel.Id.ToString();
            txt_nome.Text = editresponsavel.NomeResponsavel.ToString();
            txt_apelido.Text = editresponsavel.Apelido.ToString();
            masked_telResp.Text = editresponsavel.Telemovel.ToString();
            txt_email.Text = editresponsavel.Email.ToString();
            txt_nif.Text = editresponsavel.Nif.ToString();
        }
        /// <summary>
        /// Botão que fecha o form editar responsável
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Botão que confirma e grava as edições feitas e atualiza os dados na datagridview no form gerir responsável 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if(ValidaInformacao())
            {
                _editResponsavel.NomeResponsavel = txt_nome.Text;
                _editResponsavel.Apelido = txt_apelido.Text;
                _editResponsavel.Telemovel = masked_telResp.Text;
                _editResponsavel.Email = txt_email.Text;
                _editResponsavel.Nif= txt_nif.Text;
                _formgerir.PreencheDataGrid();
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
            if (string.IsNullOrEmpty(txt_nome.Text))
            {
                MessageBox.Show("Insira corretamente o Nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if(string.IsNullOrEmpty(txt_apelido.Text))
            {
                MessageBox.Show("Insira corretamente o Apelido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if(string.IsNullOrEmpty(masked_telResp.Text))
            {
                MessageBox.Show("Insira corretamente o Telefone!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if(string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Insira corretamente o E-mail!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_nif.Text))
            {
                MessageBox.Show("Insira corretamente o NIF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }

        
    }
}
