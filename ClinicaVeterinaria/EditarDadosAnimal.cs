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
    public partial class EditarDadosAnimal : Form
    {
        Animal _animalEditar;
        List<Animal> Animais;
        RegistarPet _formregistarPet;
        public EditarDadosAnimal(RegistarPet formregistarPet, Animal animalEditar )
        {
            InitializeComponent();
            _animalEditar = animalEditar;
            _formregistarPet = formregistarPet;
            txt_especie.Text=animalEditar.Especie.ToString();
            txt_idade.Text= animalEditar.Idade.ToString();
            txt_nomeanimal.Text = animalEditar.NomeAnimal.ToString();
            txt_porte.Text = animalEditar.Porte.ToString();
            txt_raca.Text = animalEditar.Raça.ToString();
            txt_obs.Text = animalEditar.Observacoes.ToString();
        }
        /// <summary>
        ///  Botão que fecha o form editar animal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bto_fechar_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
        /// <summary>
        /// Botão que confirma e grava as edições feitas e atualiza os dados na datagridview no form registar pet 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_animalEditado_Click(object sender, EventArgs e)
        {
            if(ValidaInformacao2())
            {
                _animalEditar.NomeAnimal= txt_nomeanimal.Text;
                _animalEditar.Especie= txt_especie.Text;
                _animalEditar.Raça= txt_raca.Text;
                _animalEditar.Idade = int.Parse(txt_idade.Text);
                _animalEditar.Porte = txt_porte.Text;
                _animalEditar.Observacoes = txt_obs.Text;
                _formregistarPet.InitDatagrid();
                this.Close();
            }
        }
        /// <summary>
        ///  Método que faz a validação para confirmar se os dados foram inseridos corretamente 
        /// </summary>
        /// <returns></returns>
        private bool ValidaInformacao2()
        {
            bool output = true;
            if (string.IsNullOrEmpty(txt_nomeanimal.Text))
            {
                MessageBox.Show("Insira nome do Animal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            if (string.IsNullOrEmpty(txt_especie.Text))
            {
                MessageBox.Show("Insira a Espécie!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;

            }
            if (string.IsNullOrEmpty(txt_porte.Text))
            {
                MessageBox.Show("Insira o Porte!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;

            }
            if (string.IsNullOrEmpty(txt_idade.Text))
            {
                MessageBox.Show("Insira a Idadel!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;

            }
            if (string.IsNullOrEmpty(txt_raca.Text))
            {
                MessageBox.Show("Insira a raça!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
    }

}
