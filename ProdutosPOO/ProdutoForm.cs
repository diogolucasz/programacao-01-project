using CamadaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdutosPOO
{
    public partial class ProdutoForm : Form
    {
        #region Construtores

        //
        public ProdutoForm()
        {
            InitializeComponent();
            this.CarregarDados();
        }

        #endregion

        #region Eventos  

        //
        private void idTextBox_KeyUp(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Enter)
            {
                this.CarregarProduto();
            }
        }

        //
        private void listaButton_Click(object sender, EventArgs e)
        {
            this.MostrarLista();
        }

        //
        private void novoButton_Click(object sender, EventArgs e)
        {
            this.Novo();
        }

        //
        private void gravarButton_Click(object sender, EventArgs e)
        {
            this.Gravar();
        }

        //
        private void eliminarButton_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        //
        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Sair();
        }

        //
        private void tabelaDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncoesGlobais.ChamaLista();
        }

        //
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncoesGlobais.ChamaSobre();
        }

        //
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Sair();
        }

        //
        private void stockUpDown_ValueChanged(object sender, EventArgs e)
        {       
            if (this.stockUpDown.Value <= 10)
            {
                this.erroStockLabel.Visible = true;
                this.erroStockLabel.Text = Properties.Resources.MESSAGE_ERRO_STOCKLABEL;
            }
            else
            {
                this.erroStockLabel.Visible = false;
            }
        }
        #endregion

        #region Funções

        //
        private void MostrarLista()
        {
            ProdutoListaForm produtoListaForm  = new ProdutoListaForm();

            produtoListaForm.ShowDialog();

            if (produtoListaForm.IDProduto > 0)
            {
                string erro = string.Empty;
                Produto produto = Produto.Obter(produtoListaForm.IDProduto, out erro);

                if (produto != null)
                {
                    this.MostrarProduto(produto);
                }
            }
        }

        //
        private void Novo()
        {
            Produto produto = new Produto();

            produto.Novo();

            this.MostrarProduto(produto); 
        }

        //
        private void MostrarProduto(Produto produto)
        {
            if (produto == null)
            {
                return;
            }

            this.idTextBox.Text = produto.IDProduto.ToString();
            this.descricaoTextBox.Text = produto.Descricao;
            this.categoriaComboBox.SelectedIndex = (int)produto.Categoria;
            this.precoTextBox.Text = produto.Preco.ToString();
            this.dataRegistoTextBox.Text = produto.DataRegisto.ToString();
            this.stockUpDown.Value = produto.Stock;
        }

        //
        private void Gravar()
        {
            string erro = string.Empty;

            if (this.ValidaDados())
            {
                Produto produto = this.ObterProduto();

                bool ok = produto.Gravar(out erro);

                if (MessageBox.Show(Properties.Resources.MESSAGE_GRAVAR_MSG, Properties.Resources.MESSAGE_GRAVAR_INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ok)
                    {
                        MessageBox.Show(Properties.Resources.MESSAGE_GRAVAR_SUCESSO);
                        this.Novo();
                    }
                    else
                    {
                        MessageBox.Show(Properties.Resources.MESSAGE_GRAVAR_ERRO, erro);
                    }

                }
            }
        }

        //
        private Produto ObterProduto()
        {
            Produto produto = new Produto();

            produto.IDProduto = long.Parse(this.idTextBox.Text);
            produto.Descricao = this.descricaoTextBox.Text;
            produto.Categoria = (CategoriaEnum)this.categoriaComboBox.SelectedIndex;
            produto.Preco = decimal.Parse(this.precoTextBox.Text);
            produto.DataRegisto = DateTime.Now;
            produto.Stock = (int)this.stockUpDown.Value;

            return produto;
        }

        //
        private bool ValidaDados()
        {
            bool ok = true;

            long idProduto;        
            string descricao = this.descricaoTextBox.Text;
            decimal preco;

            if (!long.TryParse(this.idTextBox.Text, out idProduto))
            {
                this.errorProvider.SetError(this.idTextBox, Properties.Resources.MESSAGE_V_ID_INVALIDO);
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(descricao) && descricao.Length < 10)
            {
                this.errorProvider.SetError(this.descricaoTextBox, Properties.Resources.MESSAGE_V_DESCRICAO_INVALIDO);
                ok = false;
            }
            if (!decimal.TryParse(this.precoTextBox.Text, out preco))
            {
                this.errorProvider.SetError(this.precoTextBox, Properties.Resources.MESSAGE_V_DESCRICAO_INVALIDO);
                ok = false;
            }
          
            return ok;      
        }

        //
        private void Eliminar()
        {
            string erro = string.Empty;

            if (this.ValidaID())
            {
                Produto produto = this.ObterID();

                bool ok = produto.Eliminar(out erro);

                if (MessageBox.Show(Properties.Resources.MESSAGE_ELIMINAR_MSG, Properties.Resources.MESSAGE_ELIMINAR_INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ok)
                    {
                        MessageBox.Show(Properties.Resources.MESSAGE_ELIMINAR_SUCESSO);
                        this.Novo();
                    }
                    else
                    {
                        MessageBox.Show(string.Format(Properties.Resources.MESSAGE_ELIMINAR_ERRO, erro));
                    }
                }
            }      
        }

        private Produto ObterID()
        {
            Produto produto = new Produto();

            produto.IDProduto = long.Parse(this.idTextBox.Text);

            return produto;
        }

        private bool ValidaID()
        {
            bool ok = true;

            long idProduto;

            if (!long.TryParse(this.idTextBox.Text, out idProduto))
            {
                this.errorProvider.SetError(this.idTextBox, Properties.Resources.MESSAGE_V_ID_INVALIDO);
                ok = false;
            }

            return ok;
        }

        //
        private void Sair()
        {
            this.Close();
            Application.Exit();
        }

        //
        private void CarregarDados()
        {
            Dictionary<CategoriaEnum, string> categoria = new Dictionary<CategoriaEnum, string>();

            categoria.Add(CategoriaEnum.NaoDefinido, "");
            categoria.Add(CategoriaEnum.Móvel, "Móvel");
            categoria.Add(CategoriaEnum.Sofa, "Sofa");
            categoria.Add(CategoriaEnum.Iluminação, "Iluminação");
            categoria.Add(CategoriaEnum.Textil, "Textil");
            categoria.Add(CategoriaEnum.Cozinha, "Cozinha");
            categoria.Add(CategoriaEnum.Exterior, "Exterior");

            this.categoriaComboBox.Enabled = false;

            this.categoriaComboBox.DisplayMember = "Value";
            this.categoriaComboBox.ValueMember = "Key";

            this.categoriaComboBox.DataSource = categoria.ToList();

            this.categoriaComboBox.Enabled = true;
        }

        //
        private void CarregarProduto()
        {
            string erro = string.Empty;
            string idProdutoTxt = this.idTextBox.Text;
            long iDProduto = 0;

            if (long.TryParse(idProdutoTxt, out iDProduto))
            {
                Produto produto = Produto.Obter(iDProduto, out erro);
                if (produto == null)
                {
                    MessageBox.Show(Properties.Resources.MESSAGE_ID_NA);
                }
                else
                {
                    this.MostrarProduto(produto);
                }
            }
        }

        #endregion
    }
}