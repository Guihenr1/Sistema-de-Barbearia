namespace Apresentacao
{
    partial class FrmAgendamentoAlterar
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
            this.lbIdAgendamento = new System.Windows.Forms.Label();
            this.lbIdAgenda = new System.Windows.Forms.Label();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.lbData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lbAtendido = new System.Windows.Forms.Label();
            this.cbAtendido = new System.Windows.Forms.ComboBox();
            this.lbServico = new System.Windows.Forms.Label();
            this.cbServico = new System.Windows.Forms.ComboBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIdAgendamento
            // 
            this.lbIdAgendamento.AutoSize = true;
            this.lbIdAgendamento.Location = new System.Drawing.Point(12, 9);
            this.lbIdAgendamento.Name = "lbIdAgendamento";
            this.lbIdAgendamento.Size = new System.Drawing.Size(76, 13);
            this.lbIdAgendamento.TabIndex = 0;
            this.lbIdAgendamento.Text = "Agendamento:";
            // 
            // lbIdAgenda
            // 
            this.lbIdAgenda.AutoSize = true;
            this.lbIdAgenda.Location = new System.Drawing.Point(94, 9);
            this.lbIdAgenda.Name = "lbIdAgenda";
            this.lbIdAgenda.Size = new System.Drawing.Size(13, 13);
            this.lbIdAgenda.TabIndex = 1;
            this.lbIdAgenda.Text = "--";
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.cbServico);
            this.gbDados.Controls.Add(this.lbServico);
            this.gbDados.Controls.Add(this.cbAtendido);
            this.gbDados.Controls.Add(this.lbAtendido);
            this.gbDados.Controls.Add(this.dtpData);
            this.gbDados.Controls.Add(this.lbData);
            this.gbDados.Location = new System.Drawing.Point(12, 28);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(345, 69);
            this.gbDados.TabIndex = 2;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(123, 18);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(30, 13);
            this.lbData.TabIndex = 2;
            this.lbData.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(126, 34);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(86, 20);
            this.dtpData.TabIndex = 3;
            // 
            // lbAtendido
            // 
            this.lbAtendido.AutoSize = true;
            this.lbAtendido.Location = new System.Drawing.Point(6, 18);
            this.lbAtendido.Name = "lbAtendido";
            this.lbAtendido.Size = new System.Drawing.Size(49, 13);
            this.lbAtendido.TabIndex = 0;
            this.lbAtendido.Text = "Atendido";
            // 
            // cbAtendido
            // 
            this.cbAtendido.FormattingEnabled = true;
            this.cbAtendido.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbAtendido.Location = new System.Drawing.Point(9, 34);
            this.cbAtendido.Name = "cbAtendido";
            this.cbAtendido.Size = new System.Drawing.Size(86, 21);
            this.cbAtendido.TabIndex = 1;
            // 
            // lbServico
            // 
            this.lbServico.AutoSize = true;
            this.lbServico.Location = new System.Drawing.Point(232, 18);
            this.lbServico.Name = "lbServico";
            this.lbServico.Size = new System.Drawing.Size(43, 13);
            this.lbServico.TabIndex = 4;
            this.lbServico.Text = "Serviço";
            // 
            // cbServico
            // 
            this.cbServico.FormattingEnabled = true;
            this.cbServico.Items.AddRange(new object[] {
            "Cabelo",
            "Barba"});
            this.cbServico.Location = new System.Drawing.Point(235, 33);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(81, 21);
            this.cbServico.TabIndex = 5;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(173, 112);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 3;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(254, 112);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FrmAgendamentoAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 147);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.lbIdAgenda);
            this.Controls.Add(this.lbIdAgendamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgendamentoAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Agendamento";
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdAgendamento;
        private System.Windows.Forms.Label lbIdAgenda;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.Label lbServico;
        private System.Windows.Forms.ComboBox cbAtendido;
        private System.Windows.Forms.Label lbAtendido;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
    }
}