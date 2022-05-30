using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoDPD.Controller;
using ProjetoDPD.Model;

namespace ProjetoDPD.View
{
    public partial class CadastrarEncomenda : Form
    {
        public CadastrarEncomenda()
        {
            InitializeComponent();
        }

        private void btnEncomendar_Click(object sender, EventArgs e)
        {
            if (tbxCodigo1.Text == "" || tbxValorTotal.Text == "" || tbxNomeCliente.Text == "")
            {
                MessageBox.Show("algum campo não está preenchido", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            Encomenda.NomeCliente = tbxNomeCliente.Text;
            Encomenda.NomeEncomenda1 = tbxNome1.Text;
            Encomenda.NomeEncomenda2 = tbxNome2.Text;
            Encomenda.NomeEncomenda3 = tbxNome3.Text;
            Encomenda.ValorTotal = tbxValorTotal.Text;
            Encomenda.CepCliente = tbxCepCliente.Text;
            Encomenda.Qtd1 = tbxQuantidade1.Text;
            Encomenda.Qtd2 = tbxQuantidade2.Text;
            Encomenda.Qtd3 = tbxQuantidade3.Text;



            ManipulaProduto manipulaTimes = new ManipulaProduto();
            manipulaTimes.RealizarEncomenda();
            if (Encomenda.Retorno == "Sim")

            {
                fechar();
            }
        }

        private void btnPesquisarProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                
                   
                

               

                if(tbxCodigo1.Text != "")
                {
                    Produto.CodProduto = Convert.ToInt32(tbxCodigo1.Text);


                    ManipulaProduto manipul = new ManipulaProduto();
                    manipul.mostrarProdutos();

                    

                    tbxNome1.Text = Produto.NomeProduto;
                    tbxDescricao1.Text = Produto.DescricaoProduto;
                    tbxValor1.Text = Produto.ValorProduto;
                }
                if (tbxCodigo2.Text != "")
                {
                    Produto.CodProduto = Convert.ToInt32(tbxCodigo2.Text);

                    ManipulaProduto manipul = new ManipulaProduto();
                    manipul.mostrarProdutos();

                    tbxNome2.Text = Produto.NomeProduto;
                    tbxDescricao2.Text = Produto.DescricaoProduto;
                    tbxValor2.Text = Produto.ValorProduto;

                }if(tbxCodigo3.Text != "")
                {
                    Produto.CodProduto = Convert.ToInt32(tbxCodigo3.Text);
                    ManipulaProduto manipul = new ManipulaProduto();
                    manipul.mostrarProdutos();

                    tbxNome3.Text = Produto.NomeProduto;
                    tbxDescricao3.Text = Produto.DescricaoProduto;
                    tbxValor3.Text = Produto.ValorProduto;
                }


                if (tbxCodigo1.Text == "")
                {
                    tbxCodigo1.Text = ".";
                    tbxValor1.Text = "0";
                    tbxQuantidade1.Text = "0";
                }


                if (tbxCodigo2.Text == "")
                {
                    tbxCodigo2.Text = ".";
                    tbxValor2.Text = "0";
                    tbxQuantidade2.Text = "0";
                }
                if (tbxCodigo3.Text == "")
                {
                    tbxCodigo3.Text = ".";
                    tbxValor3.Text = "0";
                    tbxQuantidade3.Text = "0";
                }


            


               

                
            }
            catch (Exception)
            {

            }
        }

        public void fechar()
        {
            this.Close();
        }

        private void tbxValorTotal_TextChanged(object sender, EventArgs e)
        {
            
            


        }

        private void tbxValorTotal_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var valor1 = Convert.ToDecimal(tbxValor1.Text);
            var valor2 = Convert.ToDecimal(tbxValor2.Text);
            var valor3 = Convert.ToDecimal(tbxValor3.Text);
            var qtd1 = Convert.ToDecimal(tbxQuantidade1.Text);
            var qtd2 = Convert.ToDecimal(tbxQuantidade2.Text);
            var qtd3 = Convert.ToDecimal(tbxQuantidade3.Text);

            var vv1 = valor1 * qtd1;
            var vv2 = valor2 * qtd2;
            var vv3 = valor3 * qtd3;
            var valorTotal = vv1 + vv2 + vv3;
            tbxValorTotal.Text = valorTotal.ToString();
        }
    }
}
