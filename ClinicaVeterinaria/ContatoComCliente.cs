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

    public partial class ContatoComCliente : Form
    {
        List<PossiveisClientes> possiveisClientes;
        GravarLer gravarler;
        public ContatoComCliente(List<PossiveisClientes> clientes)
        {
            possiveisClientes = clientes;
            InitializeComponent();
            DataGridPossiveisClientes();
        }


        /// <summary>
        /// Botão que valida se as informações foram preenchidas, e faz o envio da sms ao cliente 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sms_Click(object sender, EventArgs e)
        {
            if (ValidaSms())
            {
                MessageBox.Show("SMS enviada com sucesso!", "Mensagem", MessageBoxButtons.OK);
                txt_tlm.Text = string.Empty;
                txt_mensagem.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Preencha os dados Corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_tlm.Text = string.Empty;
            txt_mensagem.Text = string.Empty;
        }


        /// <summary>
        /// Método que valida se as informações foram preenchidas para enviar a sms
        /// </summary>
        /// <returns></returns>
        private bool ValidaSms()
        {
            if (string.IsNullOrEmpty(txt_mensagem.Text))
            {
                MessageBox.Show("Escreva a mensagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mensagem.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txt_tlm.Text))
            {
                MessageBox.Show("Insira o número de telefone!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                masked_telPossivelCliente.Focus();
                return false;
            }
            return true;
           

        }


        /// <summary>
        /// Botão  faz o envio do E-mail ao cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_email_Click(object sender, EventArgs e)
        {
            if (ValidaEmail() == true)
            {
                MessageBox.Show("E-mail enviado com sucesso!", "Mensagem", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Preencha os dados Corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_email.Text= string.Empty;
            txt_mensagem.Text = string.Empty;
        }


        /// <summary>
        /// Método que valida se as informações foram preenchidas para enviar o email
        /// </summary>
        /// <returns></returns>
        private bool ValidaEmail()
        {
            bool output = true;
            if (string.IsNullOrEmpty(txt_mensagem.Text))
            {
                MessageBox.Show("Escreva a mensagem !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_mensagem.Focus();
                output = false;
            }
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Insira o E-mail!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tlm.Focus();
                output = false;
            }
            return output;
        }


        /// <summary>
        /// Botão que faz o registo de contato criando uma lista de cliente para prospecção futura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_registar_Click(object sender, EventArgs e)
        {
            PossiveisClientes cliente = new PossiveisClientes();
            PossiveisClientes novocliente;

            if (ValidaPossivelCliente() == true)
            {
                novocliente = new PossiveisClientes
                {
                    Nome_Cliente = txt_nomePossivelcliente.Text,
                    Telemovel_Cliente = masked_telPossivelCliente.Text,
                    Email_Cliente = txt_emailPossivelcliente.Text,
                    Motivo = txt_motivo.Text
                };
                possiveisClientes.Add(novocliente);
                DataGridPossiveisClientes();
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os dados corretamente!", "Erro", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            txt_nomePossivelcliente.Text = string.Empty;
            masked_telPossivelCliente.Text = string.Empty;
            txt_emailPossivelcliente.Text = string.Empty;
            txt_motivo.Text = string.Empty; 
        }

        /// <summary>
        /// Preenche o DatagridView com as informações cadastradas dos prospects
        /// </summary>
        private void DataGridPossiveisClientes()
        {
            dgv_possivelcliente.DataSource = null;
            dgv_possivelcliente.DataSource = possiveisClientes;
        }

        /// <summary>
        /// Valida se todos os tados foram adicionados corretamente 
        /// </summary>
        /// <returns></returns>
        private bool ValidaPossivelCliente()
        {
            bool output = true;
            if (string.IsNullOrEmpty(txt_nomePossivelcliente.Text))
            {
                MessageBox.Show("Insira o Nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(masked_telPossivelCliente.Text))
            {
                MessageBox.Show("Insira o número do Telemóvel", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_emailPossivelcliente.Text))
            {
                MessageBox.Show("Insira o E-mail!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_motivo.Text))
            {
                MessageBox.Show("Insira o Motivo do contato!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            return output;
        }

        private void ContatoComCliente_Load(object sender, EventArgs e)
        {
            DataGridPossiveisClientes();
        }
    }
}
