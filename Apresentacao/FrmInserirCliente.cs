using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocio;

namespace Apresentacao
{
    public partial class FrmInserirCliente : Form
    {
        acao1 acaoNaTela;
        public FrmInserirCliente(acao1 acao, Cliente cliente, Contato contato)
        {
            InitializeComponent();
            if(acao.Equals(acao1.Alterar))
            {
                acaoNaTela = acao1.Alterar;
                Text = "Alterar Cliente";
                txtCodigoOculto.Text = cliente.IdCliente.ToString();
                txtNome.Text = cliente.Nome;
                txtTelefone.Text = contato.Telefone.ToString();
            }
            else if (acao.Equals(acao1.Inserir))
            {
                acaoNaTela = acao1.Inserir;
                Text = "Inserir Cliente";
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (acaoNaTela.Equals(acao1.Inserir))
            {
                try
                {
                    Cliente clienteInserir = new Cliente();
                    ClienteNegocio clienteNegocio = new ClienteNegocio();
                    clienteInserir.Nome = txtNome.Text;
                    clienteInserir.Telefone = new Contato();
                    clienteInserir.Telefone.Telefone = txtTelefone.Text;
                    string Retorno = clienteNegocio.Inserir(clienteInserir, clienteInserir.Telefone);
                    int IdCliente = Convert.ToInt32(Retorno);
                    MessageBox.Show("Cliente inserido com sucesso. Codigo: " + IdCliente, "Inserir diz:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível inserir o cliente. Detalhes: " + ex.Message, "Erro ao Inseir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
            else if(acaoNaTela.Equals(acao1.Alterar))
            {
                try
                {
                    Cliente clienteAlterar = new Cliente();
                    ClienteNegocio clienteNegocio = new ClienteNegocio();
                    clienteAlterar.Nome = txtNome.Text;
                    clienteAlterar.Telefone = new Contato();
                    clienteAlterar.Telefone.Telefone = txtTelefone.Text;
                    clienteAlterar.IdCliente = Convert.ToInt32(txtCodigoOculto.Text);
                    string Retorno = clienteNegocio.Alterar(clienteAlterar, clienteAlterar.Telefone);
                    int IdCliente = Convert.ToInt32(Retorno);
                    MessageBox.Show("Cliente alterado com sucesso. Codigo: " + IdCliente, "Alterar diz:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.Yes;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Não foi possível alterar o cliente. Detalhes: " + ex.Message, "Erro ao Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
