using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProjetoDPD.Model;
using ProjetoDPD.Controller;
using System.Windows.Forms;

namespace ProjetoDPD.Controller
{
    class ManipulaUsuarios
    {
    
        public void cadastrarUsuarios()
        {
            SqlConnection cn = new SqlConnection(Controller.conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pInserirUsuarios", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@NomeUsuarios", Usuarios.NomeUsuario);
                cmd.Parameters.AddWithValue("@EmailUsuarios", Usuarios.EmailUsuarios);
                cmd.Parameters.AddWithValue("@FoneUsuarios", Usuarios.FoneUsuarios);
                cmd.Parameters.AddWithValue("@FotoUsuarios", Usuarios.FotoUsuarios);
                cmd.Parameters.AddWithValue("@SenhaUsuarios", Usuarios.SenhaUsuarios);

                SqlParameter nv = cmd.Parameters.Add("@CodUsuario", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Usuário cadastrado com sucesso.",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                if (resposta == DialogResult.Yes)
                {
                    Usuarios.Retorno = "Sim";
                    return;
                }
                else
                {
                    Usuarios.Retorno = "Não";
                    return;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void deletarUsuarios()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarUsuarios", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codUsuario", Usuarios.CodUsuario);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário excluído com sucesso",
                    "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {
                MessageBox.Show("O Usuário não foi Excluído.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void alterarUsuarios()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarUsuarios", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@CodUsuario", Usuarios.CodUsuario);
                cmd.Parameters.AddWithValue("@NomeUsuarios", Usuarios.NomeUsuario);
                cmd.Parameters.AddWithValue("@EmailUsuarios", Usuarios.EmailUsuarios);
                cmd.Parameters.AddWithValue("@FoneUsuarios", Usuarios.FoneUsuarios);
                cmd.Parameters.AddWithValue("@FotoUsuarios", Usuarios.FotoUsuarios);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário Alterado com Sucesso", 
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception)
            {
                MessageBox.Show("O Usuário não foi Alterado.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        
        

        public void pesquisarCodigoUsuarios()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pBuscaCodigoUsuarios", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@CodUsuario", Usuarios.CodUsuario);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Usuarios.CodUsuario = Convert.ToInt32(arrayDados["CodUsuario"]);
                    Usuarios.NomeUsuario = arrayDados["NomeUsuarios"].ToString();
                    Usuarios.FoneUsuarios = arrayDados["FoneUsuarios"].ToString();
                    Usuarios.EmailUsuarios = arrayDados["EmailUsuarios"].ToString();
                    Usuarios.FotoUsuarios = (System.Array)arrayDados["FotoUsuarios"];
                    Usuarios.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("Informação não localizada", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Usuarios.Retorno = "Não";
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

