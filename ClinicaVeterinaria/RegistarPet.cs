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
    public partial class RegistarPet : Form
    {
        
        GravarLer gravarLer = new GravarLer();
        Responsavel _responsavel;
        List<Animal> Animais;
        List<Responsavel> _Responsaveis;
        
        public RegistarPet(List<Animal> animal,List<Responsavel> responsaveis)
        {
            InitializeComponent();
            Animais = animal;
            _Responsaveis = responsaveis;
            InitDatagrid();                            
            ComboBoxList();
        }
        /// <summary>
        /// Método que preenche o Combobox
        /// </summary>
        private void ComboBoxList()
        {
            comboBoxResponsavel.Text = "[Selecione]";
            comboBoxResponsavel.DataSource = _Responsaveis;
            comboBoxResponsavel.ValueMember = "DadosResponsavel";
             
        }

        /// <summary>
        /// Botão que regista os dados dos animais inserindo-os em uma lista, deppis de guardar limpa a texbox e a maskedbom para que possa inserir novos dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_registarpet_Click(object sender, EventArgs e)
        {
            Responsavel responsavel = new Responsavel();
            Animal novoAnimal;
            
            if(ValidaInformacao())
            {
                
                novoAnimal = new Animal
                {
                    
                    NomeAnimal = txt_nomeAnimal.Text,
                    Especie = txt_Especie.Text,
                    Porte = txt_Porte.Text,
                    Idade= Convert.ToInt32(txt_Idade.Text),
                    Raça= txt_raça.Text,
                    Observacoes= txt_observacoes.Text,
                };
                Animais.Add(novoAnimal);
                InitDatagrid();
                MessageBox.Show("Animal Registado com sucesso!","Mensagem ", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os dados corretamente!", "Erro", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            txt_Especie.Text = string.Empty;
            txt_Idade.Text= string.Empty;
            txt_nomeAnimal.Text=string.Empty;
            txt_Porte.Text=string.Empty;
            txt_raça.Text = string.Empty;
            txt_observacoes.Text = string.Empty;
        }
        /// <summary>
        /// Método que inicializa o datagriedview e apresenta as informações registadas
        /// </summary>
        public void InitDatagrid()
        {
            DGV_Animal.DataSource = null;
            DGV_Animal.DataSource=Animais;
        }
               
        /// <summary>
        /// Método que faz a validação para confirmar se os dados foram inseridos corretamente 
        /// </summary>
        /// <returns></returns>
        private bool ValidaInformacao()
        {
            bool output = true;
            if(string.IsNullOrEmpty(txt_nomeAnimal.Text))
            {
                MessageBox.Show("Insira nome do Animal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_Especie.Text))
            {
                MessageBox.Show("Insira a Espécie!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txt_Porte.Text))
            {
                MessageBox.Show("Insira o Porte!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;

            }
            if (string.IsNullOrEmpty(txt_Idade.Text))
            {
                MessageBox.Show("Insira a Idadel!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;

            }
            if (string.IsNullOrEmpty(txt_raça.Text))
            {
                MessageBox.Show("Insira a raça!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

          return output;
        }

        /// <summary>
        /// Boão que abre o form para editar os dados do animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editarAnimal_Click(object sender, EventArgs e)
        {
            Animal editarAnimal = (Animal)DGV_Animal.SelectedRows[0].DataBoundItem;
            Animal animalEditar = null;
            if(editarAnimal != null)
            {
                foreach(Animal animal in Animais)
                {
                    if(editarAnimal.NomeAnimal == editarAnimal.NomeAnimal)
                    {
                        animalEditar = animal;
                    }
                }
                
            }
            EditarDadosAnimal editarDadosAnimal = new EditarDadosAnimal(this, animalEditar);
            editarDadosAnimal.Show();
            
        }


        /// <summary>
        /// Evento que permite visualidar o datagridvirew preenchido assim que abre a aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistarPet_Load(object sender, EventArgs e)
        {
            InitDatagrid();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Animal excluiranimais =(Animal)DGV_Animal.SelectedRows[0].DataBoundItem;
            Animal excluir = null;
            if(excluiranimais !=null)
            {
                foreach(Animal animais in Animais)
                {
                    if(excluiranimais.NomeAnimal == excluiranimais.NomeAnimal)
                    {
                        excluir = animais;
                    }
                }
            }
            if(excluir !=null)
            {
                DialogResult resposta;
                resposta = MessageBox.Show($"Tem a certeza que pretende excluir {excluir.NomeAnimal}", "Excluir",
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (DialogResult.OK == resposta)
                {
                    Animais.Remove(excluir);
                    InitDatagrid();
                }
            }
        }
    }
}
