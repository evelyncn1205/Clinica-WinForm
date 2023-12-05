namespace ClinicaVeterinaria
{
    partial class RegistoMedicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_guardarMedico = new System.Windows.Forms.Button();
            this.btn_editarMedico = new System.Windows.Forms.Button();
            this.txt_idmedico = new System.Windows.Forms.TextBox();
            this.txt_apelidomedico = new System.Windows.Forms.TextBox();
            this.txt_nomemedico = new System.Windows.Forms.TextBox();
            this.txt_moradamedico = new System.Windows.Forms.TextBox();
            this.masked_TelMedico = new System.Windows.Forms.MaskedTextBox();
            this.DGV_Medico = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedNifmedico = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sala = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Medico)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(30, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(14, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apelido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(512, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nif:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(470, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Morada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(447, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telemóvel:";
            // 
            // btn_guardarMedico
            // 
            this.btn_guardarMedico.FlatAppearance.BorderSize = 0;
            this.btn_guardarMedico.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_guardarMedico.ForeColor = System.Drawing.Color.Teal;
            this.btn_guardarMedico.Location = new System.Drawing.Point(279, 405);
            this.btn_guardarMedico.Name = "btn_guardarMedico";
            this.btn_guardarMedico.Size = new System.Drawing.Size(128, 51);
            this.btn_guardarMedico.TabIndex = 7;
            this.btn_guardarMedico.Text = "Guardar";
            this.btn_guardarMedico.UseVisualStyleBackColor = true;
            this.btn_guardarMedico.Click += new System.EventHandler(this.btn_guardarMedico_Click);
            // 
            // btn_editarMedico
            // 
            this.btn_editarMedico.FlatAppearance.BorderSize = 0;
            this.btn_editarMedico.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_editarMedico.ForeColor = System.Drawing.Color.Teal;
            this.btn_editarMedico.Location = new System.Drawing.Point(613, 405);
            this.btn_editarMedico.Name = "btn_editarMedico";
            this.btn_editarMedico.Size = new System.Drawing.Size(128, 51);
            this.btn_editarMedico.TabIndex = 8;
            this.btn_editarMedico.Text = "Editar";
            this.btn_editarMedico.UseVisualStyleBackColor = true;
            this.btn_editarMedico.Click += new System.EventHandler(this.btn_editarMedico_Click);
            // 
            // txt_idmedico
            // 
            this.txt_idmedico.Enabled = false;
            this.txt_idmedico.Location = new System.Drawing.Point(114, 24);
            this.txt_idmedico.Name = "txt_idmedico";
            this.txt_idmedico.Size = new System.Drawing.Size(100, 23);
            this.txt_idmedico.TabIndex = 9;
            // 
            // txt_apelidomedico
            // 
            this.txt_apelidomedico.Location = new System.Drawing.Point(114, 189);
            this.txt_apelidomedico.Name = "txt_apelidomedico";
            this.txt_apelidomedico.Size = new System.Drawing.Size(270, 23);
            this.txt_apelidomedico.TabIndex = 10;
            // 
            // txt_nomemedico
            // 
            this.txt_nomemedico.Location = new System.Drawing.Point(114, 131);
            this.txt_nomemedico.Name = "txt_nomemedico";
            this.txt_nomemedico.Size = new System.Drawing.Size(270, 23);
            this.txt_nomemedico.TabIndex = 11;
            // 
            // txt_moradamedico
            // 
            this.txt_moradamedico.Location = new System.Drawing.Point(560, 126);
            this.txt_moradamedico.Multiline = true;
            this.txt_moradamedico.Name = "txt_moradamedico";
            this.txt_moradamedico.Size = new System.Drawing.Size(306, 83);
            this.txt_moradamedico.TabIndex = 14;
            // 
            // masked_TelMedico
            // 
            this.masked_TelMedico.Location = new System.Drawing.Point(560, 75);
            this.masked_TelMedico.Mask = "(000)0000-00000";
            this.masked_TelMedico.Name = "masked_TelMedico";
            this.masked_TelMedico.Size = new System.Drawing.Size(122, 23);
            this.masked_TelMedico.TabIndex = 16;
            // 
            // DGV_Medico
            // 
            this.DGV_Medico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Medico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Medico.Location = new System.Drawing.Point(114, 232);
            this.DGV_Medico.Name = "DGV_Medico";
            this.DGV_Medico.RowTemplate.Height = 25;
            this.DGV_Medico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Medico.Size = new System.Drawing.Size(757, 141);
            this.DGV_Medico.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 96);
            this.panel1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(342, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(333, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Copyrights © 2023, All rights Reserved By Evelyn Nunes";
            // 
            // maskedNifmedico
            // 
            this.maskedNifmedico.Location = new System.Drawing.Point(560, 20);
            this.maskedNifmedico.Mask = "000000000";
            this.maskedNifmedico.Name = "maskedNifmedico";
            this.maskedNifmedico.Size = new System.Drawing.Size(181, 23);
            this.maskedNifmedico.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(42, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sala:";
            // 
            // txt_sala
            // 
            this.txt_sala.Location = new System.Drawing.Point(114, 75);
            this.txt_sala.Name = "txt_sala";
            this.txt_sala.Size = new System.Drawing.Size(86, 23);
            this.txt_sala.TabIndex = 21;
            // 
            // RegistoMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1033, 558);
            this.Controls.Add(this.txt_sala);
            this.Controls.Add(this.btn_editarMedico);
            this.Controls.Add(this.btn_guardarMedico);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskedNifmedico);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_Medico);
            this.Controls.Add(this.masked_TelMedico);
            this.Controls.Add(this.txt_moradamedico);
            this.Controls.Add(this.txt_nomemedico);
            this.Controls.Add(this.txt_apelidomedico);
            this.Controls.Add(this.txt_idmedico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistoMedicos";
            this.Text = "RegistoMedicos";
            this.Load += new System.EventHandler(this.RegistoMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Medico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_guardarMedico;
        private Button btn_editarMedico;
        private TextBox txt_idmedico;
        private TextBox txt_apelidomedico;
        private TextBox txt_nomemedico;
        private TextBox txt_moradamedico;
        private MaskedTextBox masked_TelMedico;
        private DataGridView DGV_Medico;
        private Panel panel1;
        private MaskedTextBox maskedNifmedico;
        private Label label7;
        private Label label8;
        private TextBox txt_sala;
    }
}