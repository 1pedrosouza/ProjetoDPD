
namespace ProjetoDPD.View
{
    partial class VisualizarPerfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExcluirUsu = new System.Windows.Forms.Button();
            this.btnAlterarUsu = new System.Windows.Forms.Button();
            this.tbExibirNome = new System.Windows.Forms.TextBox();
            this.tbExibirEmail = new System.Windows.Forms.TextBox();
            this.tbExibirFone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxExibirLogo = new System.Windows.Forms.PictureBox();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbECodigoUsu = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.openFileDialogFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExibirLogo)).BeginInit();
            this.gbUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluirUsu
            // 
            this.btnExcluirUsu.BackColor = System.Drawing.Color.DarkRed;
            this.btnExcluirUsu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirUsu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirUsu.Location = new System.Drawing.Point(296, 316);
            this.btnExcluirUsu.Name = "btnExcluirUsu";
            this.btnExcluirUsu.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirUsu.TabIndex = 0;
            this.btnExcluirUsu.Text = "EXCLUIR";
            this.btnExcluirUsu.UseVisualStyleBackColor = false;
            this.btnExcluirUsu.Click += new System.EventHandler(this.btnExcluirUsu_Click);
            // 
            // btnAlterarUsu
            // 
            this.btnAlterarUsu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterarUsu.Location = new System.Drawing.Point(206, 316);
            this.btnAlterarUsu.Name = "btnAlterarUsu";
            this.btnAlterarUsu.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarUsu.TabIndex = 1;
            this.btnAlterarUsu.Text = "Alterar";
            this.btnAlterarUsu.UseVisualStyleBackColor = true;
            this.btnAlterarUsu.Click += new System.EventHandler(this.btnAlterarUsu_Click);
            // 
            // tbExibirNome
            // 
            this.tbExibirNome.Location = new System.Drawing.Point(37, 37);
            this.tbExibirNome.Name = "tbExibirNome";
            this.tbExibirNome.Size = new System.Drawing.Size(283, 23);
            this.tbExibirNome.TabIndex = 2;
            // 
            // tbExibirEmail
            // 
            this.tbExibirEmail.Location = new System.Drawing.Point(37, 94);
            this.tbExibirEmail.Name = "tbExibirEmail";
            this.tbExibirEmail.Size = new System.Drawing.Size(190, 23);
            this.tbExibirEmail.TabIndex = 3;
            // 
            // tbExibirFone
            // 
            this.tbExibirFone.Location = new System.Drawing.Point(37, 147);
            this.tbExibirFone.Name = "tbExibirFone";
            this.tbExibirFone.Size = new System.Drawing.Size(154, 23);
            this.tbExibirFone.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefone";
            // 
            // pbxExibirLogo
            // 
            this.pbxExibirLogo.Location = new System.Drawing.Point(37, 176);
            this.pbxExibirLogo.Name = "pbxExibirLogo";
            this.pbxExibirLogo.Size = new System.Drawing.Size(142, 134);
            this.pbxExibirLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxExibirLogo.TabIndex = 8;
            this.pbxExibirLogo.TabStop = false;
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.button1);
            this.gbUsuario.Controls.Add(this.label1);
            this.gbUsuario.Controls.Add(this.btnExcluirUsu);
            this.gbUsuario.Controls.Add(this.btnAlterarUsu);
            this.gbUsuario.Controls.Add(this.pbxExibirLogo);
            this.gbUsuario.Controls.Add(this.tbExibirNome);
            this.gbUsuario.Controls.Add(this.tbExibirFone);
            this.gbUsuario.Controls.Add(this.label3);
            this.gbUsuario.Controls.Add(this.label2);
            this.gbUsuario.Controls.Add(this.tbExibirEmail);
            this.gbUsuario.Location = new System.Drawing.Point(47, 82);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(386, 356);
            this.gbUsuario.TabIndex = 9;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Informações do Usuário";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(63, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Alterar Foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Insira o Código de Usuário";
            // 
            // tbECodigoUsu
            // 
            this.tbECodigoUsu.Location = new System.Drawing.Point(302, 39);
            this.tbECodigoUsu.Name = "tbECodigoUsu";
            this.tbECodigoUsu.Size = new System.Drawing.Size(100, 23);
            this.tbECodigoUsu.TabIndex = 11;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(408, 39);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(33, 23);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "IR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // openFileDialogFoto
            // 
            this.openFileDialogFoto.FileName = "openFileDialog1";
            // 
            // VisualizarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tbECodigoUsu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbUsuario);
            this.Name = "VisualizarPerfil";
            this.Text = "Meu Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.pbxExibirLogo)).EndInit();
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirUsu;
        private System.Windows.Forms.Button btnAlterarUsu;
        private System.Windows.Forms.TextBox tbExibirNome;
        private System.Windows.Forms.TextBox tbExibirEmail;
        private System.Windows.Forms.TextBox tbExibirFone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxExibirLogo;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbECodigoUsu;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialogFoto;
    }
}