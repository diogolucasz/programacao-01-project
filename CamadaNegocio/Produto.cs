using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class Produto
    {
        #region Construtores

        /// <summary>
        /// Construtor da classe Produto
        /// </summary>
        
        public Produto()
        {
            this.idProduto = 0;
            this.descricao = string.Empty;
            this.categoria = CategoriaEnum.NaoDefinido;
            this.preco = 0;
            this.dataRegisto = DateTime.Now;
            this.stock = 0;       
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Formação das propriedades da classe Produto atráves do modelo propfull
        /// </summary>

        //
        private long idProduto;

        public long IDProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }

        //
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        //
        private CategoriaEnum categoria;

        public CategoriaEnum Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        //
        private decimal preco;

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        //
        private DateTime dataRegisto;

        public DateTime DataRegisto
        {
            get { return dataRegisto; }
            set { dataRegisto = value; }
        }

        //
        private int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        #endregion

        #region Funções

        /// <summary>
        /// Função que "limpa" todos os campos para escolhas padrão
        /// </summary>
        public void Novo()
        {
            this.IDProduto = 0;
            this.Descricao = string.Empty;
            this.Categoria = CategoriaEnum.NaoDefinido;
            this.Preco = 0;
            this.DataRegisto = DateTime.Now;
            this.Stock = 0;
        }

        /// <summary>
        /// Função que envia os dados da CamadaDesign para a CamadaDados, caso receba algum erro vindo da CamadaDados remete o erro para a CamadaDesign 
        /// </summary>
        public bool Gravar(out string erro)
        {
            erro = string.Empty;

            bool ok = CamadaDados.Produto.Gravar(this.IDProduto, this.Descricao, (byte)this.Categoria, this.Preco, this.DataRegisto, this.Stock, out erro);

            return ok;
        }

        /// <summary>
        /// Requere os dados a partir do ID, de seguida atribui o dado a cada propriedade e no fim retorna para a CamadaGráfica o produto.
        /// </summary>
        public static Produto Obter(long iDProduto, out string erro)
        {
            Produto produto = null;
            erro = string.Empty;

            string descricao = string.Empty;
            byte categoria = 0;
            decimal preco = 0;
            DateTime dataRegisto = DateTime.Now;
            int stock = 0;

            bool ok = CamadaDados.Produto.Obter(iDProduto,
                                                ref descricao, ref categoria, ref preco, ref dataRegisto, ref stock,
                                                out erro);
            if (ok)
            {
                produto = new Produto();
                produto.IDProduto = iDProduto;
                produto.Descricao = descricao;
                produto.Categoria = (CategoriaEnum)categoria;
                produto.Preco = preco;
                produto.DataRegisto = dataRegisto;
                produto.Stock = stock;
            }

            return produto;
        }

        /// <summary>
        /// Obtêm lista minimizada e introduz os dados os dados na DataTable
        /// </summary>
        public static ProdutoCollection ObterLista()
        {
            DataTable dataTable = CamadaDados.Produto.ObterLista();

            ProdutoCollection produtos = new ProdutoCollection(dataTable);

            return produtos;
        }

        /// <summary>
        /// Função que envia o IDProduto para a camada de dados para eliminar um produto, caso receba algum erro vindo da CamadaDados remete o erro para a CamadaDesign
        /// </summary>
        public bool Eliminar(out string erro)
        {
            erro = string.Empty;

            bool ok = CamadaDados.Produto.Eliminar(this.IDProduto, out erro);

            return ok;
        }

        #endregion
    }
}
