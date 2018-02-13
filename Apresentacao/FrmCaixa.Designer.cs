namespace Apresentacao
{
    partial class FrmCaixa
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
            this.gbAgenda = new System.Windows.Forms.GroupBox();
            this.dgwPrincipal = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCaixa = new System.Windows.Forms.GroupBox();
            this.lbValorFinal = new System.Windows.Forms.Label();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btPago = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lbCifrao = new System.Windows.Forms.Label();
            this.lbCifraoDesc = new System.Windows.Forms.Label();
            this.lbCifraoValorTotla = new System.Windows.Forms.Label();
            this.txtMostraValorFinal = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.gbAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).BeginInit();
            this.gbCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAgenda
            // 
            this.gbAgenda.Controls.Add(this.dgwPrincipal);
            this.gbAgenda.Location = new System.Drawing.Point(12, 12);
            this.gbAgenda.Name = "gbAgenda";
            this.gbAgenda.Size = new System.Drawing.Size(482, 165);
            this.gbAgenda.TabIndex = 0;
            this.gbAgenda.TabStop = false;
            this.gbAgenda.Text = "Agendamento(s)";
            // 
            // dgwPrincipal
            // 
            this.dgwPrincipal.AllowUserToAddRows = false;
            this.dgwPrincipal.AllowUserToDeleteRows = false;
            this.dgwPrincipal.AllowUserToResizeColumns = false;
            this.dgwPrincipal.AllowUserToResizeRows = false;
            this.dgwPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.Nome,
            this.Descricao,
            this.Valor});
            this.dgwPrincipal.Location = new System.Drawing.Point(3, 16);
            this.dgwPrincipal.Name = "dgwPrincipal";
            this.dgwPrincipal.ReadOnly = true;
            this.dgwPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPrincipal.Size = new System.Drawing.Size(466, 143);
            this.dgwPrincipal.TabIndex = 0;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Id do Cliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // gbCaixa
            // 
            this.gbCaixa.Controls.Add(this.btLimpar);
            this.gbCaixa.Controls.Add(this.txtMostraValorFinal);
            this.gbCaixa.Controls.Add(this.lbCifraoValorTotla);
            this.gbCaixa.Controls.Add(this.lbCifraoDesc);
            this.gbCaixa.Controls.Add(this.lbCifrao);
            this.gbCaixa.Controls.Add(this.txtValorTotal);
            this.gbCaixa.Controls.Add(this.lbValorFinal);
            this.gbCaixa.Controls.Add(this.txtDesconto);
            this.gbCaixa.Controls.Add(this.lbDesconto);
            this.gbCaixa.Controls.Add(this.lbValor);
            this.gbCaixa.Location = new System.Drawing.Point(15, 183);
            this.gbCaixa.Name = "gbCaixa";
            this.gbCaixa.Size = new System.Drawing.Size(257, 115);
            this.gbCaixa.TabIndex = 1;
            this.gbCaixa.TabStop = false;
            this.gbCaixa.Text = "Caixa";
            // 
            // lbValorFinal
            // 
            this.lbValorFinal.AutoSize = true;
            this.lbValorFinal.Location = new System.Drawing.Point(6, 83);
            this.lbValorFinal.Name = "lbValorFinal";
            this.lbValorFinal.Size = new System.Drawing.Size(59, 13);
            this.lbValorFinal.TabIndex = 4;
            this.lbValorFinal.Text = "Valor Final:";
            // 
            // lbDesconto
            // 
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Location = new System.Drawing.Point(6, 54);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(56, 13);
            this.lbDesconto.TabIndex = 2;
            this.lbDesconto.Text = "Desconto:";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(6, 26);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(61, 13);
            this.lbValor.TabIndex = 0;
            this.lbValor.Text = "Valor Total:";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(393, 227);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btPago
            // 
            this.btPago.Location = new System.Drawing.Point(312, 227);
            this.btPago.Name = "btPago";
            this.btPago.Size = new System.Drawing.Size(75, 23);
            this.btPago.TabIndex = 3;
            this.btPago.Text = "Pago";
            this.btPago.UseVisualStyleBackColor = true;
            this.btPago.Click += new System.EventHandler(this.btPago_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(95, 23);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(56, 20);
            this.txtValorTotal.TabIndex = 6;
            // 
            // lbCifrao
            // 
            this.lbCifrao.AutoSize = true;
            this.lbCifrao.Location = new System.Drawing.Point(70, 26);
            this.lbCifrao.Name = "lbCifrao";
            this.lbCifrao.Size = new System.Drawing.Size(24, 13);
            this.lbCifrao.TabIndex = 7;
            this.lbCifrao.Text = "R$:";
            // 
            // lbCifraoDesc
            // 
            this.lbCifraoDesc.AutoSize = true;
            this.lbCifraoDesc.Location = new System.Drawing.Point(70, 54);
            this.lbCifraoDesc.Name = "lbCifraoDesc";
            this.lbCifraoDesc.Size = new System.Drawing.Size(24, 13);
            this.lbCifraoDesc.TabIndex = 8;
            this.lbCifraoDesc.Text = "R$:";
            // 
            // lbCifraoValorTotla
            // 
            this.lbCifraoValorTotla.AutoSize = true;
            this.lbCifraoValorTotla.Location = new System.Drawing.Point(71, 83);
            this.lbCifraoValorTotla.Name = "lbCifraoValorTotla";
            this.lbCifraoValorTotla.Size = new System.Drawing.Size(24, 13);
            this.lbCifraoValorTotla.TabIndex = 9;
            this.lbCifraoValorTotla.Text = "R$:";
            // 
            // txtMostraValorFinal
            // 
            this.txtMostraValorFinal.Location = new System.Drawing.Point(95, 80);
            this.txtMostraValorFinal.Name = "txtMostraValorFinal";
            this.txtMostraValorFinal.ReadOnly = true;
            this.txtMostraValorFinal.Size = new System.Drawing.Size(56, 20);
            this.txtMostraValorFinal.TabIndex = 10;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(157, 49);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(47, 23);
            this.btLimpar.TabIndex = 11;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(95, 51);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(56, 20);
            this.txtDesconto.TabIndex = 3;
            this.txtDesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesconto_KeyDown);
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 310);
            this.Controls.Add(this.btPago);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.gbCaixa);
            this.Controls.Add(this.gbAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.gbAgenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).EndInit();
            this.gbCaixa.ResumeLayout(false);
            this.gbCaixa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAgenda;
        private System.Windows.Forms.DataGridView dgwPrincipal;
        private System.Windows.Forms.GroupBox gbCaixa;
        private System.Windows.Forms.Label lbValorFinal;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtMostraValorFinal;
        private System.Windows.Forms.Label lbCifraoValorTotla;
        private System.Windows.Forms.Label lbCifraoDesc;
        private System.Windows.Forms.Label lbCifrao;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.TextBox txtDesconto;
    }
}