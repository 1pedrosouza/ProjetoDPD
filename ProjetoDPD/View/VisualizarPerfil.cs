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
using System.IO;

namespace ProjetoDPD.View
{
    public partial class VisualizarPerfil : Form
    {
        public VisualizarPerfil()
        {
            InitializeComponent();
        }
        public void fecharCadastroJ()
        {
            this.Close();
        }
        public void limparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }
        }

        private void btnAlterarUsu_Click(object sender, EventArgs e)
        {
            if (tbECodigoUsu.Text == "")
            {
                MessageBox.Show("Digite um Código Válido", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                tbECodigoUsu.Text = string.Empty;
                tbExibirNome.Text = string.Empty;
                tbExibirEmail.Text = string.Empty;
                tbExibirFone.Text = string.Empty;
                pbxExibirLogo.Image = null;
                return;
            }
            var resposta = MessageBox.Show("Deseja fazer alterações no usuário de código " + tbECodigoUsu.Text + "?", "Atenção"
            , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Usuarios.CodUsuario = Convert.ToInt32(tbECodigoUsu.Text);
                Usuarios.NomeUsuario = tbExibirNome.Text;
                Usuarios.FoneUsuarios = tbExibirFone.Text;
                Usuarios.EmailUsuarios = tbExibirEmail.Text;
                MemoryStream memoriaLogo = new MemoryStream();
                pbxExibirLogo.Image.Save(memoriaLogo, pbxExibirLogo.Image.RawFormat);
                Usuarios.FotoUsuarios = memoriaLogo.ToArray();



                ManipulaUsuarios manipulaUsuarios = new ManipulaUsuarios();
                manipulaUsuarios.alterarUsuarios();

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbECodigoUsu.Text == "")
                {
                    MessageBox.Show("Digite um valor válido.");
                    return;
                }
                else
                {
                    Usuarios.CodUsuario = Convert.ToInt32(tbECodigoUsu.Text);
                }

                ManipulaUsuarios manipula = new ManipulaUsuarios();
                manipula.pesquisarCodigoUsuarios();

                tbECodigoUsu.Text = Usuarios.CodUsuario.ToString();
                tbExibirEmail.Text = Usuarios.EmailUsuarios;
                tbExibirFone.Text = Usuarios.FoneUsuarios;
                tbExibirNome.Text = Usuarios.NomeUsuario;
                MemoryStream ms = new MemoryStream((byte[])Usuarios.FotoUsuarios);
                pbxExibirLogo.Image = Image.FromStream(ms);

            }

            catch (Exception)
            {

            }
        }

        private void btnExcluirUsu_Click(object sender, EventArgs e)
        {
            if (tbECodigoUsu.Text == "")
            {
                MessageBox.Show("Digite um Número");
            }

            var resposta = MessageBox.Show("Deseja excluir o jogador de número " + tbECodigoUsu.Text + "?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (resposta == DialogResult.Yes)
            {
                Usuarios.CodUsuario = Convert.ToInt32(tbECodigoUsu.Text);

                ManipulaUsuarios manipulaUsuarios = new ManipulaUsuarios();
                manipulaUsuarios.deletarUsuarios();

            }

            tbECodigoUsu.Text = string.Empty;
            tbExibirFone.Text = string.Empty;
            tbExibirNome.Text = string.Empty;
            tbExibirEmail.Text = string.Empty;
            pbxExibirLogo.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogFoto.Filter = "Escolha seu Logo (*.jpeg; *.jpg; *.png;) | *.jpeg; *.jpg; *.png";
            if (openFileDialogFoto.ShowDialog() == DialogResult.OK)
            {
                pbxExibirLogo.Image = Image.FromFile(openFileDialogFoto.FileName);
            }
        }
    }
}

    


