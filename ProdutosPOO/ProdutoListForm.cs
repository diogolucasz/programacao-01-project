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
    public partial class ProdutoListForm : Form
    {
        #region Construtor

        //
        public ProdutoListForm()
        {
            InitializeComponent();
        }


        #endregion

        #region Propriedades

        //
        private long idProduto;

        public long IDProduto
        {
            get { return idProduto; }
            private set { idProduto = value; }
        }

        #endregion

        #region Eventos
        private void ProdutoListForm_Load(object sender, EventArgs e)
        {
            this.FormatarGrelha();
            this.CarregarGrelha();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelecionarProduto();
        }

        #endregion

        #region Metodos

        private void CarregarGrelha()
        {
            ProdutoCollection produtos = Produto.ObterLista();

            this.dataGridView.DataSource = produtos;
        }

        #endregion

        //
        private void FormatarGrelha()
        {
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ReadOnly = true;

            this.AddColuna(200, "ID Produto", "IDProduto", DataGridViewAutoSizeColumnMode.Fill);
            this.AddColuna(200, "Descrição", "Descricao", DataGridViewAutoSizeColumnMode.Fill);
            this.AddColuna(220, "Data Registo", "DataRegisto", DataGridViewAutoSizeColumnMode.Fill);
        }

        //
        private void AddColuna(int tamanho, string header, string campo, DataGridViewAutoSizeColumnMode modo)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();

            column.Width = tamanho;
            column.HeaderText = header;
            column.DataPropertyName = campo;
            column.AutoSizeMode = modo;

            this.dataGridView.Columns.Add(column);
        }

        //
        private void SelecionarProduto()
        {
            if (this.dataGridView.SelectedRows!= null &&
                this.dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataGridView.SelectedRows[0];
                if (row != null)
                {
                    this.IDProduto = (long)row.Cells[0].Value;
                    this.Close();
                }
            }
        }

    }
}
