using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteSelecionar frmClienteSelecionar = new FrmClienteSelecionar(acao1.Cliente);
            frmClienteSelecionar.MdiParent = this;
            frmClienteSelecionar.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteSelecionar frmClienteSelecionar = new FrmClienteSelecionar(acao1.Agenda);
            frmClienteSelecionar.MdiParent = this;
            frmClienteSelecionar.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
