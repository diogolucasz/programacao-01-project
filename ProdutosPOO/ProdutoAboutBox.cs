using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdutosPOO
{
    partial class ProdutoAboutBox : Form
    {
        #region Construtores

        //
        public ProdutoAboutBox()
        {
            InitializeComponent();
            this.Text = Properties.Resources.MESSAGE_ABOUT_FORM;
            this.numeroLabel.Text = Properties.Resources.MESSAGE_ABOUT_NUMERO;
            this.nomeLabel.Text = Properties.Resources.MESSAGE_ABOUT_NOME;
            this.descricaoTextBox.Text = Properties.Resources.MESSAGE_ABOUT_DESCRICAO;
        }

        #endregion

        #region Eventos

        //
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
