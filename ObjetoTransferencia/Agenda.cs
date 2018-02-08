using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Agenda
    {
        public int IdAgendamento { get; set; }
        public Cliente IdCliente { get; set; }
        public DateTime Data { get; set; }
        public DateTime AgendadoEm { get; set; }
        public Boolean Atendido { get; set; }
        public AgendaServicos agendaServicos { get; set; }
    }
}
