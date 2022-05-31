using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDPD.View
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarProduto telaCadastrar = new CadastrarProduto();
            telaCadastrar.ShowDialog();
        }

        private void gerenciarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarProduto telaCadastrar = new GerenciarProduto();
            telaCadastrar.ShowDialog();
        }

        private void realizarEncomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           CadastrarEncomenda telaCadastrar = new CadastrarEncomenda();
            telaCadastrar.ShowDialog();
        }

        private void gerenciarEncomendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerenciar_Encomendas telaCadastrar = new Gerenciar_Encomendas();
            telaCadastrar.ShowDialog();
        }

        private void visualizarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario telaCadastrar = new CadastroUsuario();
            telaCadastrar.ShowDialog();
        }

        private void visualizarPerfilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisualizarPerfil telaCadastrar = new VisualizarPerfil();
            telaCadastrar.ShowDialog();
        }
    }
}
