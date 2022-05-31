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
using System.IO;

namespace ProjetoDPD.View
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        public void fecharCadastro()
        {
            this.Close();
        }

        private void CadastroUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                fecharCadastro();
            }
        }

        private void limparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }
        }

        private void btnCadastroUsu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsuCadastro.Text == "" || tbUsuSenha.Text == "" || tbUsuEmail.Text == "" || tbUsuFone.Text == "")
                {
                    MessageBox.Show("Por favor, insira as informações completas.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Usuarios.NomeUsuario = tbUsuCadastro.Text;
                Usuarios.EmailUsuarios = tbUsuEmail.Text;
                Usuarios.SenhaUsuarios = tbUsuSenha.Text;
                Usuarios.FoneUsuarios = tbUsuFone.Text;

                MemoryStream memoriaLogo = new MemoryStream();
                pbxFotoUsu.Image.Save(memoriaLogo, pbxFotoUsu.Image.RawFormat);
                Usuarios.FotoUsuarios = memoriaLogo.ToArray();
                
               

                ManipulaUsuarios manipulaUsuarios = new ManipulaUsuarios();
                manipulaUsuarios.cadastrarUsuarios();

                if (Usuarios.Retorno == "Sim")
                {
                    limparTela();
                    return;
                }
                else
                {
                    fecharCadastro();
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Escolha seu Logo (*.jpeg; *.jpg; *.png;) | *.jpeg; *.jpg; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxFotoUsu.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
