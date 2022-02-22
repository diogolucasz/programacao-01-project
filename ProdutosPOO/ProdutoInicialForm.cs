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
    public partial class ProdutoInicialForm : Form
    {
        #region Construtor
        public ProdutoInicialForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos
        private void listaButton_Click(object sender, EventArgs e)
        {
            FuncoesGlobais.ChamaLista();
        }


        private void manutencaoButton_Click(object sender, EventArgs e)
        {
            FuncoesGlobais.ChamaManutencao();
        }


        private void sobreButton_Click(object sender, EventArgs e)
        {
            FuncoesGlobais.ChamaSobre();
        }

        #endregion
    }
}
