
using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;



namespace ClinicaVeterinaria
{
    public partial class GerirPaciente : Form
    {
        //GravarLer gravarler = new GravarLer();
        

        List<Responsavel> Responsaveis;

        int contaResponsavel;
               
        public GerirPaciente(List<Responsavel> responsaveis, int contaresponsavel)
        {
            InitializeComponent();
            Responsaveis = responsaveis;
            contaResponsavel = contaresponsavel;
            PreencheDataGrid();
        }

        /// <summary>
        /// Botão Guardar, adiciona todos dados do responsavel que foram inseridos à lista de responsáveis, depois de guardar os dados limpa as Texbox e as MaskedBbox para inserir novos dados 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_guadarresponsavel_Click(object sender, EventArgs e)
        {
            Responsavel responsavel;
            if(ValidaResponsavel())
            {
                responsavel = new Responsavel
                {
                    Id=contaResponsavel,
                    NomeResponsavel=txt_nomeResp.Text,
                    Apelido=txt_apelido.Text,
                    Email=txt_email.Text,
                    Telemovel = masked_telefoneResp.Text,
                    Nif = masked_nif.Text
                    
                };
                
                Responsaveis.Add(responsavel);
                contaResponsavel++;

                PreencheDataGrid();
                MessageBox.Show("Responsável registado com sucesso","Mensagem",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os dados corretamente!", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            txt_nomeResp.Text= string.Empty;
            txt_apelido.Text = string.Empty;
            txt_email.Text= string.Empty;
            masked_telefoneResp.Text=string.Empty;
            masked_nif.Text= string .Empty;

        }
        /// <summary>
        /// Preenche o DatagredView e mostra os dados que foram inseridos do responsável
        /// </summary>
        public void PreencheDataGrid()
        {
            dgv_dadosResponsavel.DataSource = null;
            dgv_dadosResponsavel.DataSource = Responsaveis;
           
        }
        
        /// <summary>
        /// Método de validação , verifica se todos os dados necessários foram devidamente preenchidos 
        /// </summary>
        /// <returns></returns>
        public bool ValidaResponsavel()
        {
            bool output = true;
            if(string.IsNullOrEmpty(txt_nomeResp.Text))
            {
                MessageBox.Show("Insira o Nome do responsável!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output= false;
            }
            if(string.IsNullOrEmpty(txt_apelido.Text))
            {
                MessageBox.Show("Insira o Apelido do responsável!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if(string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Insira o E-mail do responsável!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if(string.IsNullOrEmpty(masked_telefoneResp.Text))
            {
                MessageBox.Show("Insira o Telemóvel do responsável!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(masked_nif.Text))
            {
                MessageBox.Show("Insira o NIF do responsável!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
        /// <summary>
        /// Boão que abre o form para editar os dados 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editarresponsavel_Click(object sender, EventArgs e)
        {
            Responsavel responsaveleditar= (Responsavel)dgv_dadosResponsavel.SelectedRows[0].DataBoundItem;
            Responsavel editresponsavel = null;
            if(responsaveleditar != null)
            {
                foreach(Responsavel responsavel in Responsaveis)
                {
                    if(responsaveleditar.Id == responsavel.Id)
                    {
                        editresponsavel = responsavel;
                    }
                }
                
            }
            EditarResponsavel editarresponsavel = new EditarResponsavel(this, editresponsavel);
            editarresponsavel.Show();

        }

        
       
        /// <summary>
        /// Evento que permite visualidar o datagridvirew preenchido assim que abre a aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GerirPaciente_Load(object sender, EventArgs e)
        {
            PreencheDataGrid();
        }

        

        
    }
}
