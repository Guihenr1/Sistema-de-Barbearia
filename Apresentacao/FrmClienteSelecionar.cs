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
        acao1 acao;
        public FrmClienteSelecionar(acao1 acao)
        {
            InitializeComponent();
            if(acao.Equals(acao1.Cliente))
            {
                btExcluir.Enabled = false;
                Text = "Controle de Clientes";
            }
            else if(acao.Equals(acao1.Agenda))
            {
                Text = "Controle de Agenda";
                lbPesquisa.Text = "Data Agenda";
            }
            dgwPrincipal.AutoGenerateColumns = false;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
