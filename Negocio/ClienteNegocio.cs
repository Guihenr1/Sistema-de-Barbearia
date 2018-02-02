using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocio
{
    public class ClienteNegocio
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Cliente cliente, Contato contato)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionaParametros("@Nome", cliente.Nome);
                acessoDados.AdicionaParametros("@Telefone", contato.Telefone);

                string IdCliente = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString();

                return IdCliente;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string InserirTelAdd(Cliente cliente, Contato contato)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionaParametros("@IdCliente", cliente.IdCliente);
                acessoDados.AdicionaParametros("@Telefone", contato.Telefone);

                string IdCliente = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserirNovoContato").ToString();

                return IdCliente;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Cliente cliente, Contato contato)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionaParametros("@IdCliente", cliente.IdCliente);
                acessoDados.AdicionaParametros("@Nome", cliente.Nome);
                acessoDados.AdicionaParametros("@Telefone", contato.Telefone);
                string IdCliente = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteAlterar").ToString();

                return IdCliente;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public ClienteColecao ConsultarPorCodigo(int Id)
        {
            try
            {
                ClienteColecao clienteColecao = new ClienteColecao();
                acessoDados.LimparParametros();
                acessoDados.AdicionaParametros("@IdCliente", Id);
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarCodigo");
                foreach (DataRow linha in dataTable.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Convert.ToInt32(linha["IdCliente"]);
                    cliente.Nome = Convert.ToString(linha["Nome"]);
                    cliente.Telefone = new Contato();
                    cliente.Telefone.Telefone = Convert.ToString(linha["Telefone"]);

                    clienteColecao.Add(cliente);
                }
                return clienteColecao;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ClienteColecao ConsultarPorNome(string Nome)
        {
            try
            {
                ClienteColecao clienteColecao = new ClienteColecao();
                acessoDados.LimparParametros();
                acessoDados.AdicionaParametros("@Nome", Nome);
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarNome");
                foreach (DataRow linha in dataTable.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Convert.ToInt32(linha["IdCliente"]);
                    cliente.Nome = Convert.ToString(linha["Nome"]);

                    cliente.Telefone = new Contato();
                    cliente.Telefone.Telefone = Convert.ToString(linha["Telefone"]);

                    clienteColecao.Add(cliente);
                }
                return clienteColecao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
