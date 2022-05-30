
namespace ProjetoDPD.View
{
    partial class Gerenciar_Encomendas
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
            this.btnBuscarNomeProduto = new System.Windows.Forms.Button();
            this.tbxCodEncomenda = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarNomeProduto
            // 
            this.btnBuscarNomeProduto.Location = new System.Drawing.Point(456, 27);
            this.btnBuscarNomeProduto.Name = "btnBuscarNomeProduto";
            this.btnBuscarNomeProduto.Size = new System.Drawing.Size(115, 29);
            this.btnBuscarNomeProduto.TabIndex = 5;
            this.btnBuscarNomeProduto.Text = "Buscar";
            this.btnBuscarNomeProduto.UseVisualStyleBackColor = true;
            this.btnBuscarNomeProduto.Click += new System.EventHandler(this.btnBuscarNomeProduto_Click);
            // 
            // tbxCodEncomenda
            // 
            this.tbxCodEncomenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCodEncomenda.Location = new System.Drawing.Point(243, 27);
            this.tbxCodEncomenda.Name = "tbxCodEncomenda";
            this.tbxCodEncomenda.Size = new System.Drawing.Size(191, 29);
            this.tbxCodEncomenda.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(2, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(786, 137);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Produto1";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Produto2";
            this.Column6.Name = "Column6";
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Produto3";
            this.Column7.Name = "Column7";
            this.Column7.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NomeCliente";
            this.Column4.Name = "Column4";
            this.Column4.Width = 300;
            // 
            // Gerenciar_Encomendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarNomeProduto);
            this.Controls.Add(this.tbxCodEncomenda);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gerenciar_Encomendas";
            this.Text = "Gerenciar_Encomendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarNomeProduto;
        private System.Windows.Forms.TextBox tbxCodEncomenda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}