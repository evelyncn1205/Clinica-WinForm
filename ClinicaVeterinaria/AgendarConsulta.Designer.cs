namespace ClinicaVeterinaria
{
    partial class AgendarConsulta
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_medico = new System.Windows.Forms.ComboBox();
            this.cbo_animal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_agendarconsulta = new System.Windows.Forms.Button();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_dataConsulta = new System.Windows.Forms.DateTimePicker();
            this.dgv_agenda = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbo_hora = new System.Windows.Forms.ComboBox();
            this.txt_idconsulta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_tipoconsulta = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agenda)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha o médico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(48, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Animal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(549, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Escolha a data:";
            // 
            // cbo_medico
            // 
            this.cbo_medico.FormattingEnabled = true;
            this.cbo_medico.Location = new System.Drawing.Point(190, 109);
            this.cbo_medico.Name = "cbo_medico";
            this.cbo_medico.Size = new System.Drawing.Size(208, 23);
            this.cbo_medico.TabIndex = 1;
            // 
            // cbo_animal
            // 
            this.cbo_animal.FormattingEnabled = true;
            this.cbo_animal.Location = new System.Drawing.Point(190, 169);
            this.cbo_animal.Name = "cbo_animal";
            this.cbo_animal.Size = new System.Drawing.Size(208, 23);
            this.cbo_animal.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(48, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo da Consulta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(551, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Observações:";
            // 
            // btn_agendarconsulta
            // 
            this.btn_agendarconsulta.FlatAppearance.BorderSize = 0;
            this.btn_agendarconsulta.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agendarconsulta.ForeColor = System.Drawing.Color.Teal;
            this.btn_agendarconsulta.Location = new System.Drawing.Point(388, 288);
            this.btn_agendarconsulta.Name = "btn_agendarconsulta";
            this.btn_agendarconsulta.Size = new System.Drawing.Size(208, 60);
            this.btn_agendarconsulta.TabIndex = 7;
            this.btn_agendarconsulta.Text = "Agendar Consulta";
            this.btn_agendarconsulta.UseVisualStyleBackColor = true;
            this.btn_agendarconsulta.Click += new System.EventHandler(this.btn_agendarconsulta_Click);
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(661, 190);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(265, 60);
            this.txt_obs.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(605, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hora:";
            // 
            // dtp_dataConsulta
            // 
            this.dtp_dataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataConsulta.Location = new System.Drawing.Point(676, 50);
            this.dtp_dataConsulta.Name = "dtp_dataConsulta";
            this.dtp_dataConsulta.Size = new System.Drawing.Size(177, 23);
            this.dtp_dataConsulta.TabIndex = 4;
            // 
            // dgv_agenda
            // 
            this.dgv_agenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_agenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agenda.Location = new System.Drawing.Point(109, 34);
            this.dgv_agenda.Name = "dgv_agenda";
            this.dgv_agenda.RowTemplate.Height = 25;
            this.dgv_agenda.Size = new System.Drawing.Size(750, 235);
            this.dgv_agenda.TabIndex = 18;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(979, 398);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.cbo_hora);
            this.tabPage1.Controls.Add(this.btn_agendarconsulta);
            this.tabPage1.Controls.Add(this.txt_idconsulta);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbo_tipoconsulta);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dtp_dataConsulta);
            this.tabPage1.Controls.Add(this.cbo_medico);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cbo_animal);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_obs);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(971, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agendar Consulta";
            // 
            // cbo_hora
            // 
            this.cbo_hora.FormattingEnabled = true;
            this.cbo_hora.Location = new System.Drawing.Point(676, 115);
            this.cbo_hora.MaxDropDownItems = 5;
            this.cbo_hora.Name = "cbo_hora";
            this.cbo_hora.Size = new System.Drawing.Size(121, 23);
            this.cbo_hora.TabIndex = 25;
            this.cbo_hora.SelectedIndexChanged += new System.EventHandler(this.cbo_hora_SelectedIndexChanged);
            // 
            // txt_idconsulta
            // 
            this.txt_idconsulta.Enabled = false;
            this.txt_idconsulta.Location = new System.Drawing.Point(190, 47);
            this.txt_idconsulta.Name = "txt_idconsulta";
            this.txt_idconsulta.Size = new System.Drawing.Size(100, 23);
            this.txt_idconsulta.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(127, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "lD:";
            // 
            // cbo_tipoconsulta
            // 
            this.cbo_tipoconsulta.FormattingEnabled = true;
            this.cbo_tipoconsulta.Location = new System.Drawing.Point(193, 241);
            this.cbo_tipoconsulta.Name = "cbo_tipoconsulta";
            this.cbo_tipoconsulta.Size = new System.Drawing.Size(208, 23);
            this.cbo_tipoconsulta.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.btn_cancelar);
            this.tabPage2.Controls.Add(this.dgv_agenda);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(971, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agenda Completa";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.Teal;
            this.btn_cancelar.Location = new System.Drawing.Point(362, 293);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(210, 60);
            this.btn_cancelar.TabIndex = 19;
            this.btn_cancelar.Text = "Cancelar Consulta";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 103);
            this.panel1.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(349, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(299, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Copyrights © 2023, All rights Reserved By Evelyn Nunes";
            // 
            // AgendarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1017, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgendarConsulta";
            this.Text = "AgendarConsulta";
            this.Load += new System.EventHandler(this.AgendarConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agenda)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox cbo_medico;
        private ComboBox cbo_animal;
        private Label label5;
        private Label label6;
        private Button btn_agendarconsulta;
        private TextBox txt_obs;
        private Label label7;
        private DateTimePicker dtp_dataConsulta;
        private DataGridView dgv_agenda;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cbo_tipoconsulta;
        private Button btn_cancelar;
        private TextBox txt_idconsulta;
        private Label label3;
        private Panel panel1;
        private ComboBox cbo_hora;
        private Label label11;
    }
}