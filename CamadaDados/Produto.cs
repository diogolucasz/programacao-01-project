using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados
{
    public class Produto
    {
        #region Funções

        //
        public static bool Gravar(long idProduto,
                                  string descricao, byte categoria, decimal preco, DateTime dataRegisto, int stock,
                                  out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                SqlConnection sqlConnection = ConexaoDB.Open();

                SqlCommand sqlCommand = new SqlCommand("GravarProduto", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("IDProduto", System.Data.SqlDbType.BigInt);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = idProduto;

                sqlParameter = sqlCommand.Parameters.Add("Descricao", System.Data.SqlDbType.NVarChar, 100);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = descricao;

                sqlParameter = sqlCommand.Parameters.Add("Categoria", System.Data.SqlDbType.TinyInt);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = categoria;

                sqlParameter = sqlCommand.Parameters.Add("Preco", System.Data.SqlDbType.Decimal);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = preco;

                sqlParameter = sqlCommand.Parameters.Add("DataRegisto", System.Data.SqlDbType.DateTime);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = dataRegisto;

                sqlParameter = sqlCommand.Parameters.Add("Stock", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = stock;

                sqlCommand.ExecuteNonQuery();

                sqlParameter = null;
                sqlCommand.Dispose();
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                erro = ex.Message;
                ok = false;
            }
            return ok;
        }


        //
        public static DataTable ObterLista()
        {
            DataTable dataTable = null;
            try
            {
                SqlConnection sqlConnection = ConexaoDB.Open();
           
                SqlCommand sqlCommand = new SqlCommand("ListarProduto", sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult);

                dataTable = new DataTable();
                dataTable.Load(dataReader);

                sqlCommand.Dispose();
                sqlConnection.Close();
            }
            catch (Exception)
            {           
            }
            return dataTable;
        }

        //
        public static bool Obter(long iDProduto,
                                 ref string descricao, ref byte categoria, ref decimal preco, ref DateTime dataRegisto, ref int stock,
                                 out string erro)
        {
            bool ok = false;
            erro = string.Empty;

            try
            {
                SqlConnection sqlConnection = ConexaoDB.Open();

                SqlCommand sqlCommand = new SqlCommand("ObterProduto", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("IDProduto", System.Data.SqlDbType.BigInt);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = iDProduto;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    if (!sqlDataReader.IsDBNull(1))
                    {
                        descricao = sqlDataReader.GetString(1);
                    }
                    if (!sqlDataReader.IsDBNull(2))
                    {
                        categoria = sqlDataReader.GetByte(2);
                    }
                    if (!sqlDataReader.IsDBNull(3))
                    {
                        preco = sqlDataReader.GetDecimal(3);
                    }
                    if (!sqlDataReader.IsDBNull(4))
                    {
                        dataRegisto = sqlDataReader.GetDateTime(4);
                    }
                    if (!sqlDataReader.IsDBNull(5))
                    {
                        stock = sqlDataReader.GetInt32(5);
                    }
                    ok = true;
                }

                sqlParameter = null;
                sqlCommand.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
                ok = false;
            }
            return ok;
        }


        //
        public static bool Eliminar(long idProduto,
                                    out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                SqlConnection sqlConnection = ConexaoDB.Open();

                SqlCommand sqlCommand = new SqlCommand("EliminarProduto", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("IDProduto", System.Data.SqlDbType.BigInt);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = idProduto;

                sqlCommand.ExecuteNonQuery();

                sqlParameter = null;
                sqlCommand.Dispose();
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                erro = ex.Message;
                ok = false;
            }
            return ok;
        }


        #endregion
    }
}
