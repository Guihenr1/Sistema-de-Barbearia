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
            if(acao.Equals(acao1.Agenda))
            {
                acaoNaTela = acao1.Agenda;
                Text = "Controle de Agenda";
                lbPesquisa.Text = "Data Agenda";

                DataGridViewColumn IdAgendamento = new DataGridViewTextBoxColumn();
                IdAgendamento.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                IdAgendamento.DataPropertyName = "Agenda.IdAgendamento";
                IdAgendamento.Name = "IdAgendamento";
                dgwPrincipal.Columns.Add(IdAgendamento);

                DataGridViewColumn IdCliente = new DataGridViewTextBoxColumn();
                IdCliente.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                IdCliente.DataPropertyName = "Agenda.IdCliente.IdCliente";
                IdCliente.Width = 60;
                IdCliente.Name = "IdCliente";
                dgwPrincipal.Columns.Add(IdCliente);

                DataGridViewColumn Nome = new DataGridViewTextBoxColumn();
                Nome.DataPropertyName = "agenda.IdCliente.Nome";
                Nome.Name = "Nome";
                dgwPrincipal.Columns.Add(Nome);

                DataGridViewColumn Descricao = new DataGridViewTextBoxColumn();
                Descricao.DataPropertyName = "Agenda.agendaServicos.IdServico.Descricao";
                Descricao.Name = "Descricao";
                dgwPrincipal.Columns.Add(Descricao);

                DataGridViewColumn Valor = new DataGridViewTextBoxColumn();
                Valor.DataPropertyName = "Agenda.agendaServicos.IdServico.Valor";
                Valor.Width = 60;
                Valor.Name = "Valor";
                dgwPrincipal.Columns.Add(Valor);

                DataGridViewColumn Data = new DataGridViewTextBoxColumn();
                Data.DataPropertyName = "Agenda.Data";
                Data.Name = "Data";
                Data.DefaultCellStyle.Format = "dd/MM/yyyy";
                dgwPrincipal.Columns.Add(Data);

                DataGridViewColumn AgendadoEm = new DataGridViewTextBoxColumn();
                AgendadoEm.DataPropertyName = "Agenda.AgendadoEm";
                AgendadoEm.DefaultCellStyle.Format = "dd/MM/yyyy";
                AgendadoEm.Name = "AgendadoEm";
                dgwPrincipal.Columns.Add(AgendadoEm);

                DataGridViewCheckBoxColumn Atendido = new DataGridViewCheckBoxColumn();
                Atendido.DataPropertyName = "Agenda.Atendido";
                Atendido.Name = "Atendido";
                Atendido.Width = 60;
                dgwPrincipal.Columns.Add(Atendido);

                txtPesquisar.Size = new Size(312, 20);
                btPesquisar.Location = new Point(414, 4);
                dtpData.Visible = true;
                btBuscarData.Visible = true;
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
            try
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
            catch
            {
                dgwPrincipal.Rows.Clear();
                AgendaNegocio agendaNegocio = new AgendaNegocio();
                AgendaColecao agendaColecao = new AgendaColecao();
                agendaColecao = agendaNegocio.ConsultarPorNome(txtPesquisar.Text);
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
            if(acaoNaTela.Equals(acao1.Cliente))
            {
                FrmInserirCliente frmInserir = new FrmInserirCliente(acao1.Inserir, null, null);
                DialogResult resultado = frmInserir.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    dgwPrincipal.Rows.Clear();
                }
            }
            else if(acaoNaTela.Equals(acao1.Agenda))
            {
                FrmServicoAgendar frmServicoAgendar = new FrmServicoAgendar();                
                DialogResult resultado = frmServicoAgendar.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    dgwPrincipal.Rows.Clear();
                }
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (dgwPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado", "Alterar diz:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(acaoNaTela.Equals(acao1.Cliente))
            {
                Cliente clienteSelecionado = new Cliente();
                clienteSelecionado.IdCliente = Convert.ToInt32(dgwPrincipal.SelectedRows[0].Cells["IdCliente"].Value);
                clienteSelecionado.Nome = dgwPrincipal.SelectedRows[0].Cells["Nome"].Value.ToString();
                Contato clienteContato = new Contato();
                clienteContato.Telefone = dgwPrincipal.SelectedRows[0].Cells["Telefone"].Value.ToString();

                FrmInserirCliente frmInserirCliente = new FrmInserirCliente(acao1.Alterar, clienteSelecionado, clienteContato);
                DialogResult result = frmInserirCliente.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    dgwPrincipal.Rows.Clear();
                }
            }
            else if(acaoNaTela.Equals(acao1.Agenda))
            {
                Agenda agenda = new Agenda();
                agenda.IdAgendamento = Convert.ToInt32(dgwPrincipal.CurrentRow.Cells[0].Value);
                agenda.Data = Convert.ToDateTime(dgwPrincipal.CurrentRow.Cells[5].Value);
                agenda.Atendido = Convert.ToBoolean(dgwPrincipal.CurrentRow.Cells[7].Value);
                agenda.agendaServicos = new AgendaServicos();
                agenda.agendaServicos.IdServico = new Servicos();
                agenda.agendaServicos.IdServico.Descricao = dgwPrincipal.CurrentRow.Cells[3].Value.ToString();
                FrmAgendamentoAlterar frmAgendamentoAlterar = new FrmAgendamentoAlterar(agenda);
                DialogResult dialogResult = frmAgendamentoAlterar.ShowDialog();
                if(dialogResult == DialogResult.Yes)
                {
                    dgwPrincipal.Rows.Clear();
                }
            }
        }

        private void btBuscarData_Click(object sender, EventArgs e)
        {
            dgwPrincipal.Rows.Clear();
            AgendaNegocio agendaNegocio = new AgendaNegocio();
            AgendaColecao agendaColecao = new AgendaColecao();
            agendaColecao = agendaNegocio.ConsultarPorData(dtpData.Value);
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgwPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum agendamento selecionado", "Excluir diz:");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Tem certeza?", "Excluir diz:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            int Codigo = Convert.ToInt32(dgwPrincipal.CurrentRow.Cells[0].Value);
            AgendaNegocio agendaNegocio = new AgendaNegocio();
            string retorno = agendaNegocio.ExcluirAgendamento(Codigo);

            try
            {
                int IdAgendamento = Convert.ToInt32(retorno);
                MessageBox.Show("Agendamento excluido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PesquisarAgenda();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir. Detalhes: " + retorno, "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
