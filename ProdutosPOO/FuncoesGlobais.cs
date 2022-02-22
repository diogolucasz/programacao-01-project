using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdutosPOO
{
    public class FuncoesGlobais
    { 
        internal static void ChamaLista()
        {
            ProdutoListaForm produtoListaForm = new ProdutoListaForm();
            produtoListaForm.Show();
        }

        internal static void ChamaManutencao()
        {
            ProdutoForm produtoForm = new ProdutoForm();
            produtoForm.Show();
        }

        internal static void ChamaSobre()
        {
            ProdutoAboutBox produtoAboutBox = new ProdutoAboutBox();
            produtoAboutBox.Show();
        }
    }
}
