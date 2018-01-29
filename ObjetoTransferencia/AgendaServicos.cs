using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class AgendaServicos
    {
        public int IdAgendamentoServicos { get; set; }
        public Agenda IdAgendamento { get; set; }
        public Servicos IdServico { get; set; }
    }
}
