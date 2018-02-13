using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Caixa
    {
        public Agenda IdAgendamento { get; set; }
        public bool Pago { get; set; }
        public int IdCliente { get; set; }
    }
}
