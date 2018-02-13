using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmCaixa : Form
    {
        public FrmCaixa(int IdCliente)
        {
            InitializeComponent();
            dgwPrincipal.AutoGenerateColumns = false;

            dgwPrincipal.Rows.Clear();
            AgendaNegocio agendaNegocio = new AgendaNegocio();
            AgendaColecao agendaColecao = new AgendaColecao();
            agendaColecao = agendaNegocio.ConsultarPorCodigo(IdCliente);
            foreach (Agenda item in agendaColecao)
            {
                dgwPrincipal.Rows.Add();
                dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["IdCliente"].Value = item.IdCliente.IdCliente;
                dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["Nome"].Value = item.IdCliente.Nome;
                dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["Descricao"].Value = item.agendaServicos.IdServico.Descricao;
                dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["Valor"].Value = item.agendaServicos.IdServico.Valor;
            }

            int valor = 0;

            foreach (DataGridViewRow row in dgwPrincipal.Rows)
            {
                valor += Convert.ToInt32(row.Cells["Valor"].Value);
            }
            txtValorTotal.Text = valor.ToString("###,###,##0.00");
            txtMostraValorFinal.Text = valor.ToString("###,###,##0.00");
        }

        private void btPago_Click(object sender, EventArgs e)
        {
            int IdCliente = Convert.ToInt32(dgwPrincipal.CurrentRow.Cells[0].Value);
            CaixaNegocio caixaNegocio = new CaixaNegocio();
            string retorno = caixaNegocio.CaixaPago(IdCliente);
            try
            {
                int Id = Convert.ToInt32(retorno);
                MessageBox.Show("Valor recebido", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show("Valor não recebido. Mais detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                decimal Desconto = Convert.ToDecimal(txtDesconto.Text);
                decimal valorFinal = Convert.ToDecimal(txtMostraValorFinal.Text);
                if(valorFinal > Desconto)
                {
                    valorFinal -= Desconto;
                    txtMostraValorFinal.Text = valorFinal.ToString("###,###,##0.00");
                }
                else if(valorFinal == Desconto)
                {
                    DialogResult dialogResult = MessageBox.Show("O valor do serviço será zerado. Deseja proseguir? ", "Alerta de valor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialogResult.Equals(DialogResult.Yes))
                    {
                        valorFinal -= Desconto;
                        txtMostraValorFinal.Text = valorFinal.ToString("###,###,##0.00");
                    }
                    else
                    {
                        return;
                    }
                }
                else if(valorFinal < Desconto)
                {
                    MessageBox.Show("Valor de desconto maior do que o valor de serviço", "Desconto inviável", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtMostraValorFinal.Text = txtValorTotal.Text;
            txtDesconto.Text = "";
        }
    }
}
