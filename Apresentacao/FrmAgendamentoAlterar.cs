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
    public partial class FrmAgendamentoAlterar : Form
    {
        public FrmAgendamentoAlterar(Agenda agenda)
        {
            InitializeComponent();
            lbIdAgenda.Text = Convert.ToString(agenda.IdAgendamento);
            if(agenda.Atendido == false)
            {
                cbAtendido.Text = "Não";
            }
            else if(agenda.Atendido == true)
            {
                cbAtendido.Text = "Sim";
            }
            dtpData.Value = agenda.Data;
            cbServico.Text = agenda.agendaServicos.IdServico.Descricao;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Agenda agendaAlterar = new Agenda();
            AgendaNegocio agendaNegocio = new AgendaNegocio();
            agendaAlterar.IdAgendamento = Convert.ToInt32(lbIdAgenda.Text);
            string Atendido = cbAtendido.Text;
            if (Atendido == "Não")
            {
                agendaAlterar.Atendido = false;
            }
            else if(Atendido == "Sim")
            {
                agendaAlterar.Atendido = true;
            }
            agendaAlterar.Data = dtpData.Value;
            agendaAlterar.agendaServicos = new AgendaServicos();
            agendaAlterar.agendaServicos.IdServico = new Servicos();
            if(cbServico.Text == "Cabelo")
            {
                agendaAlterar.agendaServicos.IdServico.IdServico = 1;
            }
            else if(cbServico.Text == "Barba")
            {
                agendaAlterar.agendaServicos.IdServico.IdServico = 2;
            }
            string retorno = agendaNegocio.AgendaAlterar(agendaAlterar);

            try
            {
                int Id = Convert.ToInt32(retorno);
                MessageBox.Show("Alteração realizada com sucesso", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show("Erro ao alterar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.No;
            }
        }
    }
}
