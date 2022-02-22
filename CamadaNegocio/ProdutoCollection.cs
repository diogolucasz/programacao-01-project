using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class ProdutoCollection : List<Produto>
    {
        #region Contrutor

        public ProdutoCollection(DataTable dataTable)
        {
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.AsEnumerable())
                {
                    Produto produto = new Produto();

                    produto.IDProduto = dataRow.Field<long>("IDProduto");
                    produto.Descricao = dataRow.Field<string>("Descricao");
                    produto.DataRegisto = dataRow.Field<DateTime>("DataRegisto");

                    this.Add(produto);
                }
            }
        }

        #endregion
    }
}