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
    public partial class FrmClienteSelecionar : Form
    {
        acao1 acaoNaTela;
        public FrmClienteSelecionar(acao1 acao)
        {
            InitializeComponent();
            if(acao.Equals(acao1.Cliente))
            {
                acaoNaTela = acao1.Cliente;
                btExcluir.Enabled = false;
                Text = "Controle de Clientes";

                DataGridViewColumn IdCliente = new DataGridViewTextBoxColumn();
                IdCliente.Name = "IdCliente";
                IdCliente.HeaderText = "Id do Cliente";
                dgwPrincipal.Columns.Add(IdCliente);

                DataGridViewColumn Nome = new DataGridViewTextBoxColumn();
                Nome.Name = "Nome";
                dgwPrincipal.Columns.Add(Nome);

                DataGridViewColumn Telefone = new DataGridViewTextBoxColumn();
                Telefone.Name = "Telefone";
                dgwPrincipal.Columns.Add(Telefone);
            }
            else if(acao.Equals(acao1.Agenda))
            {
                acaoNaTela = acao1.Agenda;
                Text = "Controle de Agenda";
                lbPesquisa.Text = "Data Agenda";

                DataGridViewColumn Data = new DataGridViewColumn();
                Data.Name = "Data";
                dgwPrincipal.Columns.Add(Data);

                DataGridViewColumn IdAgendamento = new DataGridViewColumn();
                IdAgendamento.Name = "IdAgendamento";
                dgwPrincipal.Columns.Add(IdAgendamento);

                DataGridViewColumn IdCliente = new DataGridViewColumn();
                IdCliente.Name = "IdCliente";
                dgwPrincipal.Columns.Add(IdCliente);

                DataGridViewColumn Nome = new DataGridViewColumn();
                Nome.Name = "Nome";
                dgwPrincipal.Columns.Add(Nome);

                DataGridViewColumn Descricao = new DataGridViewColumn();
                Descricao.Name = "Descricao";
                dgwPrincipal.Columns.Add(Descricao);

                DataGridViewColumn Valor = new DataGridViewColumn();
                Valor.Name = "Valor";
                dgwPrincipal.Columns.Add(Valor);

                DataGridViewColumn AgendadoEm = new DataGridViewColumn();
                AgendadoEm.Name = "AgendadoEm";
                dgwPrincipal.Columns.Add(AgendadoEm);

                DataGridViewCheckBoxColumn Atendido = new DataGridViewCheckBoxColumn();
                Atendido.Name = "Atendido";
                dgwPrincipal.Columns.Add(Atendido);
            }
            dgwPrincipal.AutoGenerateColumns = false;
        }

        private void pesquisarCliente()
        {
            try
            {
                dgwPrincipal.Rows.Clear();
                int Codigo = Convert.ToInt32(txtPesquisar.Text);
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                ClienteColecao clienteColecao = new ClienteColecao();
                clienteColecao = clienteNegocio.ConsultarPorCodigo(Codigo);
                foreach (Cliente item in clienteColecao)
                {
                    dgwPrincipal.Rows.Add();
                    dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["IdCliente"].Value = item.IdCliente;
                    dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["Nome"].Value = item.Nome;
                    dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["Telefone"].Value = item.Telefone.Telefone;
                }
            }
            catch
            {
                dgwPrincipal.Rows.Clear();
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                ClienteColecao clienteColecao = new ClienteColecao();
                clienteColecao = clienteNegocio.ConsultarPorNome(txtPesquisar.Text);
                foreach (Cliente item in clienteColecao)
                {
                    dgwPrincipal.Rows.Add();
                    dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["IdCliente"].Value = item.IdCliente;
                    dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["Nome"].Value = item.Nome;
                    dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["Telefone"].Value = item.Telefone.Telefone;
                }
            }
        }

        private void PesquisarAgenda()
        {
            dgwPrincipal.Rows.Clear();
            int Codigo = Convert.ToInt32(txtPesquisar.Text);
            AgendaNegocio agendaNegocio = new AgendaNegocio();
            AgendaColecao agendaColecao = new AgendaColecao();
            agendaColecao = agendaNegocio.ConsultarPorCodigo(Codigo);
            foreach (Agenda item in agendaColecao)
            {
                dgwPrincipal.Rows.Add();
                dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["Data"].Value = item.Data;
                dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["IdAgendamento"].Value = item.IdAgendamento;
                dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["IdCliente"].Value = item.IdCliente.IdCliente;
                dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["Nome"].Value = item.IdCliente.Nome;
                dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["Descricao"].Value = item.agendaServicos.IdServico.Descricao;
                dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["Valor"].Value = item.agendaServicos.IdServico.Valor;
                dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["AgendadoEm"].Value = item.AgendadoEm;
                dgwPrincipal.Rows[dgwPrincipal.Rows.Count - 1].Cells["Atendido"].Value = item.Atendido;
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (acaoNaTela.Equals(acao1.Cliente))
            {
                pesquisarCliente();
            }  
            else if(acaoNaTela.Equals(acao1.Agenda))
            {
                PesquisarAgenda();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            FrmInserirCliente frmInserir = new FrmInserirCliente(acao1.Inserir, null, null);
            DialogResult resultado = frmInserir.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                dgwPrincipal.Rows.Clear();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (dgwPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado", "Alterar diz:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cliente clienteSelecionado = new Cliente();
            clienteSelecionado.IdCliente = Convert.ToInt32(dgwPrincipal.SelectedRows[0].Cells["IdCliente"].Value);
            clienteSelecionado.Nome = dgwPrincipal.SelectedRows[0].Cells["Nome"].Value.ToString();
            Contato clienteContato = new Contato();
            clienteContato.Telefone = dgwPrincipal.SelectedRows[0].Cells["Telefone"].Value.ToString();

            FrmInserirCliente frmInserirCliente = new FrmInserirCliente(acao1.Alterar, clienteSelecionado, clienteContato);
            DialogResult result = frmInserirCliente.ShowDialog();
            if(result == DialogResult.Yes)
            {
                dgwPrincipal.Rows.Clear();
            }
        }
    }
}
