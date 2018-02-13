using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using System.Data;

namespace Negocio
{
    public class CaixaNegocio
    {
        AcessoDadosSqlServer acessoSql = new AcessoDadosSqlServer();
        public string CaixaPago(int IdCliente)
        {
            try
            {
                acessoSql.LimparParametros();
                acessoSql.AdicionaParametros("@IdCliente", IdCliente);
                string retorno = acessoSql.ExecutarManipulacao(CommandType.StoredProcedure, "uspCaixaPago").ToString();
                return retorno;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
