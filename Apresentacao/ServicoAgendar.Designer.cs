namespace Apresentacao
{
    partial class FrmServicoAgendar
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.dgwCliente = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lbCodigoNome = new System.Windows.Forms.Label();
            this.gbAgendamento = new System.Windows.Forms.GroupBox();
            this.cbServicos = new System.Windows.Forms.ComboBox();
            this.lbServico = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lbData = new System.Windows.Forms.Label();
            this.lValor = new System.Windows.Forms.Label();
            this.lbMostraValor = new System.Windows.Forms.Label();
            this.btAgendar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).BeginInit();
            this.gbAgendamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.dgwCliente);
            this.gbCliente.Controls.Add(this.txtPesquisar);
            this.gbCliente.Controls.Add(this.lbCodigoNome);
            this.gbCliente.Location = new System.Drawing.Point(12, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(410, 176);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Buscar Cliente";
            // 
            // dgwCliente
            // 
            this.dgwCliente.AllowUserToAddRows = false;
            this.dgwCliente.AllowUserToDeleteRows = false;
            this.dgwCliente.AllowUserToResizeColumns = false;
            this.dgwCliente.AllowUserToResizeRows = false;
            this.dgwCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.Nome,
            this.Telefone});
            this.dgwCliente.Location = new System.Drawing.Point(9, 68);
            this.dgwCliente.MultiSelect = false;
            this.dgwCliente.Name = "dgwCliente";
            this.dgwCliente.ReadOnly = true;
            this.dgwCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCliente.Size = new System.Drawing.Size(386, 99);
            this.dgwCliente.TabIndex = 3;
            this.dgwCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCliente_CellDoubleClick);
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "id do Cliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(9, 42);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(245, 20);
            this.txtPesquisar.TabIndex = 2;
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            // 
            // lbCodigoNome
            // 
            this.lbCodigoNome.AutoSize = true;
            this.lbCodigoNome.Location = new System.Drawing.Point(6, 24);
            this.lbCodigoNome.Name = "lbCodigoNome";
            this.lbCodigoNome.Size = new System.Drawing.Size(76, 13);
            this.lbCodigoNome.TabIndex = 1;
            this.lbCodigoNome.Text = "Codigo | Nome";
            // 
            // gbAgendamento
            // 
            this.gbAgendamento.Controls.Add(this.cbServicos);
            this.gbAgendamento.Controls.Add(this.lbServico);
            this.gbAgendamento.Controls.Add(this.dtpData);
            this.gbAgendamento.Controls.Add(this.lbData);
            this.gbAgendamento.Enabled = false;
            this.gbAgendamento.Location = new System.Drawing.Point(12, 194);
            this.gbAgendamento.Name = "gbAgendamento";
            this.gbAgendamento.Size = new System.Drawing.Size(194, 130);
            this.gbAgendamento.TabIndex = 1;
            this.gbAgendamento.TabStop = false;
            this.gbAgendamento.Text = "Dados do Agendamento";
            // 
            // cbServicos
            // 
            this.cbServicos.FormattingEnabled = true;
            this.cbServicos.Items.AddRange(new object[] {
            "Cabelo",
            "Barba"});
            this.cbServicos.Location = new System.Drawing.Point(9, 92);
            this.cbServicos.Name = "cbServicos";
            this.cbServicos.Size = new System.Drawing.Size(178, 21);
            this.cbServicos.TabIndex = 4;
            this.cbServicos.SelectedIndexChanged += new System.EventHandler(this.cbServicos_SelectedIndexChanged);
            // 
            // lbServico
            // 
            this.lbServico.AutoSize = true;
            this.lbServico.Location = new System.Drawing.Point(6, 76);
            this.lbServico.Name = "lbServico";
            this.lbServico.Size = new System.Drawing.Size(43, 13);
            this.lbServico.TabIndex = 3;
            this.lbServico.Text = "Serviço";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(9, 44);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(82, 20);
            this.dtpData.TabIndex = 2;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(6, 26);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(30, 13);
            this.lbData.TabIndex = 0;
            this.lbData.Text = "Data";
            // 
            // lValor
            // 
            this.lValor.AutoSize = true;
            this.lValor.Location = new System.Drawing.Point(251, 238);
            this.lValor.Name = "lValor";
            this.lValor.Size = new System.Drawing.Size(34, 13);
            this.lValor.TabIndex = 2;
            this.lValor.Text = "Valor:";
            // 
            // lbMostraValor
            // 
            this.lbMostraValor.AutoSize = true;
            this.lbMostraValor.Location = new System.Drawing.Point(291, 238);
            this.lbMostraValor.Name = "lbMostraValor";
            this.lbMostraValor.Size = new System.Drawing.Size(13, 13);
            this.lbMostraValor.TabIndex = 3;
            this.lbMostraValor.Text = "--";
            // 
            // btAgendar
            // 
            this.btAgendar.Enabled = false;
            this.btAgendar.Location = new System.Drawing.Point(244, 265);
            this.btAgendar.Name = "btAgendar";
            this.btAgendar.Size = new System.Drawing.Size(75, 23);
            this.btAgendar.TabIndex = 4;
            this.btAgendar.Text = "Agendar";
            this.btAgendar.UseVisualStyleBackColor = true;
            this.btAgendar.Click += new System.EventHandler(this.btAgendar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(325, 265);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FrmServicoAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 333);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAgendar);
            this.Controls.Add(this.lbMostraValor);
            this.Controls.Add(this.lValor);
            this.Controls.Add(this.gbAgendamento);
            this.Controls.Add(this.gbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmServicoAgendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Serviço";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).EndInit();
            this.gbAgendamento.ResumeLayout(false);
            this.gbAgendamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lbCodigoNome;
        private System.Windows.Forms.GroupBox gbAgendamento;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.ComboBox cbServicos;
        private System.Windows.Forms.Label lbServico;
        private System.Windows.Forms.Label lValor;
        private System.Windows.Forms.Label lbMostraValor;
        private System.Windows.Forms.Button btAgendar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DataGridView dgwCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
    }
}