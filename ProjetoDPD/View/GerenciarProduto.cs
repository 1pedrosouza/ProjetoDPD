using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoDPD.Model;
using ProjetoDPD.Controller;

namespace ProjetoDPD.View
{
    public partial class GerenciarProduto : Form
    {
        public GerenciarProduto()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarNomeProduto_Click(object sender, EventArgs e)
        {
            if (tbxNomeProduto.Text == "")
            {
                MessageBox.Show("Digite o nome de um produto para a busca", "Atenção");
                tbxNomeProduto.Focus();

                return;
            }

            Produto.NomeProduto = tbxNomeProduto.Text;

            dataGridView1.DataSource = ManipulaProduto.pesquisarNomeTimes();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            dataGridView1.Columns[5].HeaderCell.Value = "Código";
            dataGridView1.Columns[6].HeaderCell.Value = "Nome";
            dataGridView1.Columns[7].HeaderCell.Value = "Descrição";
            dataGridView1.Columns[8].HeaderCell.Value = "Valor";
            dataGridView1.Columns[9].HeaderCell.Value = "Foto";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {                     
        }
    }
}
