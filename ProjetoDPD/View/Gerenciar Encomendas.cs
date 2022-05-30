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
    public partial class Gerenciar_Encomendas : Form
    {
        public Gerenciar_Encomendas()
        {
            InitializeComponent();
        }

        private void btnBuscarNomeProduto_Click(object sender, EventArgs e)
        {
            if (tbxCodEncomenda.Text == "")
            {
                MessageBox.Show("Digite o nome de um produto para a busca", "Atenção");
                tbxCodEncomenda.Focus();

                return;
            }

            Encomenda.CodEncomenda = Convert.ToInt32(tbxCodEncomenda.Text);

            dataGridView1.DataSource = ManipulaProduto.MostrarEncomenda();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            dataGridView1.Columns[5].HeaderCell.Value = "Código";
            dataGridView1.Columns[6].HeaderCell.Value = "Produto1";
            dataGridView1.Columns[7].HeaderCell.Value = "Produto2";
            dataGridView1.Columns[8].HeaderCell.Value = "Produto3";
            dataGridView1.Columns[9].HeaderCell.Value = "ValorFinal";

          

        }
    }
}
