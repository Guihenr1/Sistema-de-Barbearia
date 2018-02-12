using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetoTransferencia;
using AcessoDados;
using System.Data;

namespace Negocio
{
    public class AgendaNegocio
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public AgendaColecao ConsultarPorCodigo(int Id)
        {
            try
            {
                AgendaColecao agendaColecao = new AgendaColecao();
                acessoDados.LimparParametros();
                acessoDados.AdicionaParametros("@IdCliente", Id);
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "uspAgendaPesquisarId");
                foreach (DataRow linha in dataTable.Rows)
                {
                    Agenda agenda = new Agenda();
                    agenda.Data = Convert.ToDateTime(linha["Data"]);
                    agenda.IdAgendamento = Convert.ToInt32(linha["IdAgendamento"]);
                    agenda.IdCliente = new Cliente();
                    agenda.IdCliente.IdCliente = Convert.ToInt32(linha["idCliente"]);
                    agenda.IdCliente.Nome = linha["Nome"].ToString();
                    agenda.agendaServicos = new AgendaServicos();
                    agenda.agendaServicos.IdServico = new Servicos();
                    agenda.agendaServicos.IdServico.Descricao = linha["Descricao"].ToString();
                    agenda.agendaServicos.IdServico.Valor = Convert.ToDecimal(linha["Valor"]);
                    agenda.AgendadoEm = Convert.ToDateTime(linha["AgendadoEm"]);
                    agenda.Atendido = Convert.ToBoolean(linha["Atendido"]);

                    agendaColecao.Add(agenda);
                }
                return agendaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AgendaColecao ConsultarPorNome(string Nome)
        {
            try
            {
                AgendaColecao agendaColecao = new AgendaColecao();
                acessoDados.LimparParametros();
                acessoDados.AdicionaParametros("@Nome", Nome);
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "uspAgendaPesquisarNome");
                foreach (DataRow linha in dataTable.Rows)
                {
                    Agenda agenda = new Agenda();
                    agenda.Data = Convert.ToDateTime(linha["Data"]);
                    agenda.IdAgendamento = Convert.ToInt32(linha["IdAgendamento"]);
                    agenda.IdCliente = new Cliente();
                    agenda.IdCliente.IdCliente = Convert.ToInt32(linha["idCliente"]);
                    agenda.IdCliente.Nome = linha["Nome"].ToString();
                    agenda.agendaServicos = new AgendaServicos();
                    agenda.agendaServicos.IdServico = new Servicos();
                    agenda.agendaServicos.IdServico.Descricao = linha["Descricao"].ToString();
                    agenda.agendaServicos.IdServico.Valor = Convert.ToDecimal(linha["Valor"]);
                    agenda.AgendadoEm = Convert.ToDateTime(linha["AgendadoEm"]);
                    agenda.Atendido = Convert.ToBoolean(linha["Atendido"]);

                    agendaColecao.Add(agenda);
                }
                return agendaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AgendaColecao ConsultarPorData(DateTime Data)
        {
            try
            {
                AgendaColecao agendaColecao = new AgendaColecao();
                acessoDados.LimparParametros();
                acessoDados.AdicionaParametros("@Data", Data);
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "uspAgendaPesquisarData");
                foreach (DataRow linha in dataTable.Rows)
                {
                    Agenda agenda = new Agenda();
                    agenda.Data = Convert.ToDateTime(linha["Data"]);
                    agenda.IdAgendamento = Convert.ToInt32(linha["IdAgendamento"]);
                    agenda.IdCliente = new Cliente();
                    agenda.IdCliente.IdCliente = Convert.ToInt32(linha["idCliente"]);
                    agenda.IdCliente.Nome = linha["Nome"].ToString();
                    agenda.agendaServicos = new AgendaServicos();
                    agenda.agendaServicos.IdServico = new Servicos();
                    agenda.agendaServicos.IdServico.Descricao = linha["Descricao"].ToString();
                    agenda.agendaServicos.IdServico.Valor = Convert.ToDecimal(linha["Valor"]);
                    agenda.AgendadoEm = Convert.ToDateTime(linha["AgendadoEm"]);
                    agenda.Atendido = Convert.ToBoolean(linha["Atendido"]);

                    agendaColecao.Add(agenda);
                }
                return agendaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ExcluirAgendamento(int Id)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionaParametros("@IdAgendamento", Id);
                string IdAgendamento = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "uspAgendaExcluir").ToString();
                return IdAgendamento;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ServicoAgendar(Agenda agenda)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionaParametros("@IdCliente", agenda.IdCliente.IdCliente);
                acessoDados.AdicionaParametros("@Data", agenda.Data);
                acessoDados.AdicionaParametros("@IdServico", agenda.agendaServicos.IdServico.IdServico);
                string IdAgendamento = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "uspServicoAgendar").ToString();
                return IdAgendamento;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string AgendaAlterar(Agenda agenda)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionaParametros("@IdAgendamento", agenda.IdAgendamento);
                acessoDados.AdicionaParametros("@Data", agenda.Data);
                acessoDados.AdicionaParametros("@Atendido", agenda.Atendido);
                acessoDados.AdicionaParametros("@IdServico", agenda.agendaServicos.IdServico.IdServico);
                string retorno = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "uspAgendaAlterar").ToString();
                return retorno;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
