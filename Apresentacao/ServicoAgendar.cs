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
    public partial class FrmServicoAgendar : Form
    {
        public FrmServicoAgendar()
        {
            InitializeComponent();
            dgwCliente.AutoGenerateColumns = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbServicos.SelectedIndex == 0)
            {
                lbMostraValor.Text = "";
                lbMostraValor.Text = "R$:30,00";
            }
            else if(cbServicos.SelectedIndex == 1)
            {
                lbMostraValor.Text = "";
                lbMostraValor.Text = "R$:40,00";
            }
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    dgwCliente.Rows.Clear();
                    int Codigo = Convert.ToInt32(txtPesquisar.Text);
                    ClienteNegocio clienteNegocio = new ClienteNegocio();
                    ClienteColecao clienteColecao = new ClienteColecao();
                    clienteColecao = clienteNegocio.ConsultarPorCodigo(Codigo);
                    foreach (Cliente item in clienteColecao)
                    {
                        dgwCliente.Rows.Add();
                        dgwCliente.Rows[dgwCliente.Rows.Count - 1].Cells["IdCliente"].Value = item.IdCliente;
                        dgwCliente.Rows[dgwCliente.Rows.Count - 1].Cells["Nome"].Value = item.Nome;
                        dgwCliente.Rows[dgwCliente.Rows.Count - 1].Cells["Telefone"].Value = item.Telefone.Telefone;
                    }
                }
                catch
                {
                    dgwCliente.Rows.Clear();
                    ClienteNegocio clienteNegocio = new ClienteNegocio();
                    ClienteColecao clienteColecao = new ClienteColecao();
                    clienteColecao = clienteNegocio.ConsultarPorNome(txtPesquisar.Text);
                    foreach (Cliente item in clienteColecao)
                    {
                        dgwCliente.Rows.Add();
                        dgwCliente.Rows[dgwCliente.Rows.Count - 1].Cells["IdCliente"].Value = item.IdCliente;
                        dgwCliente.Rows[dgwCliente.Rows.Count - 1].Cells["Nome"].Value = item.Nome;
                        dgwCliente.Rows[dgwCliente.Rows.Count - 1].Cells["Telefone"].Value = item.Telefone.Telefone;
                    }
                }
            }
        }

        private void dgwCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gbAgendamento.Enabled = true;
            btAgendar.Enabled = true;
        }

        private void btAgendar_Click(object sender, EventArgs e)
        {
            AgendaNegocio agendaNegocio = new AgendaNegocio();
            Agenda agenda = new Agenda();
            int Codigo = Convert.ToInt32(dgwCliente.CurrentRow.Cells[0].Value);
            agenda.IdCliente = new Cliente();
            agenda.IdCliente.IdCliente = Codigo;
            agenda.Data = dtpData.Value;
            agenda.agendaServicos = new AgendaServicos();
            agenda.agendaServicos.IdServico = new Servicos();
            if (cbServicos.Text == "Cabelo")
                agenda.agendaServicos.IdServico.IdServico = 1;
            else if (cbServicos.Text == "Barba")
                agenda.agendaServicos.IdServico.IdServico = 2;
            string IdAgendamento = agendaNegocio.ServicoAgendar(agenda);
            try
            {
                int Id = Convert.ToInt32(IdAgendamento);
                MessageBox.Show("Agendamento Realizado. Id do agendamento: " + Id, "Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Yes;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao agendar. Detalhes: " + IdAgendamento, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }
        }
    }
}
