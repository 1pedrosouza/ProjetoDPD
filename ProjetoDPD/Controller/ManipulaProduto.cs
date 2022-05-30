using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDPD.Model;
using ProjetoDPD.View;
using System.Windows.Forms;

namespace ProjetoDPD.Controller
{
    public class ManipulaProduto
    {
        public void cadastroProdutos()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pInserirProduto", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@NomeProduto", Produto.NomeProduto);
                cmd.Parameters.AddWithValue("@DecricaoProduto", Produto.DescricaoProduto);
                cmd.Parameters.AddWithValue("@ValorProduto", Produto.ValorProduto);
                cmd.Parameters.AddWithValue("@FotoProduto", Produto.FotoProduto);
               

                SqlParameter nv = cmd.Parameters.Add("@CodProduto", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Produto Cadastrado", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Produto.Retorno = "Sim";
                    return;
                }
                else
                {
                    Produto.Retorno = "não";
                    return;
                }

            }
            catch (Exception)
            {

                throw;
            }




        }

        public void pesquisarCodigoTimes()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pProcurarProduto", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodProduto", Produto.CodProduto);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Produto.CodProduto = Convert.ToInt32(arrayDados["CodProduto"]);
                    Produto.NomeProduto = arrayDados["NomeProduto"].ToString();
                    Produto.DescricaoProduto = arrayDados["DescricaoProduto"].ToString();
                    Produto.ValorProduto = arrayDados["ValorProduto"].ToString();
                    Produto.FotoProduto = (System.Array)arrayDados["FotoProduto"];
                    Produto.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("código não localizado", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Produto.Retorno = "Não";
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static BindingSource pesquisarNomeTimes()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pProcurarNomeProduto", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NomeProdutos", Produto.NomeProduto);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }

        public void mostrarProdutos()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pBuscarCodigooo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodTT", Produto.CodProduto);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Produto.CodProduto = Convert.ToInt32(arrayDados["CodProduto"]);
                    Produto.NomeProduto = arrayDados["NomeProduto"].ToString();
                    Produto.DescricaoProduto = arrayDados["DescricaoProduto"].ToString();
                    Produto.ValorProduto = arrayDados["ValorProduto"].ToString();
                
                    Produto.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("código não localizado", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Produto.Retorno = "Não";
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void RealizarEncomenda()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pInserirEncomenda", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Nome1", Encomenda.NomeEncomenda1);
                cmd.Parameters.AddWithValue("@Nome2", Encomenda.NomeEncomenda2);
                cmd.Parameters.AddWithValue("@Nome3", Encomenda.NomeEncomenda3);
                cmd.Parameters.AddWithValue("@ValorTotal", Encomenda.ValorTotal);
                cmd.Parameters.AddWithValue("@NomeCliente", Encomenda.NomeCliente);
                cmd.Parameters.AddWithValue("@Cep", Encomenda.CepCliente);
                cmd.Parameters.AddWithValue("@qtd1", Encomenda.Qtd1);
                cmd.Parameters.AddWithValue("@qtd2", Encomenda.Qtd2);
                cmd.Parameters.AddWithValue("@qtd3", Encomenda.Qtd3);


                SqlParameter nv = cmd.Parameters.Add("@CodEncomenda", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Encomenda Realizada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.OK)
                {
                    Produto.Retorno = "Sim";
                    return;
                }
               

            }
            catch (Exception)
            {

                throw;
            }



        }

        public static BindingSource MostrarEncomenda()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pProcurarNomeEncomenda", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodEncomenda", Encomenda.CodEncomenda);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }

    }
}
