using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoDPD.Model;
using ProjetoDPD.Controller;

namespace ProjetoDPD.View
{
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Escolha seu logo (*.png; *.jpeg; *.jpg;) | *.png; *.jpeg; *.jpg;";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagemProduto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            if (tbxNomeProduto.Text == "" || tbxValorProduto.Text == "" || tbxDescricaoProduto.Text == "")
            {
                MessageBox.Show("algum campo não está preenchido", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            Produto.NomeProduto = tbxNomeProduto.Text;
            Produto.DescricaoProduto = tbxDescricaoProduto.Text;
            Produto.ValorProduto = tbxValorProduto.Text;
            MemoryStream memoryLogo = new MemoryStream();
            pictureBoxImagemProduto.Image.Save(memoryLogo, pictureBoxImagemProduto.Image.RawFormat);
            Produto.FotoProduto = memoryLogo.ToArray();


            ManipulaProduto manipulaTimes = new ManipulaProduto();
            manipulaTimes.cadastroProdutos();
            if (Produto.Retorno == "Sim")

            {
                fechar();
                    }
        }




        private void fechar()
        {
            this.Close();
        }
        
    }
}
