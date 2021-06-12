
namespace CotacaoDolar
{
    partial class FrmCotacaoDolar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDolar = new System.Windows.Forms.Label();
            this.labelCompra = new System.Windows.Forms.Label();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.labelVenda = new System.Windows.Forms.Label();
            this.labelVariacao = new System.Windows.Forms.Label();
            this.lblCompra = new System.Windows.Forms.Label();
            this.lblVenda = new System.Windows.Forms.Label();
            this.lblVariacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDolar
            // 
            this.labelDolar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelDolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDolar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolar.Location = new System.Drawing.Point(3, 9);
            this.labelDolar.Name = "labelDolar";
            this.labelDolar.Size = new System.Drawing.Size(421, 69);
            this.labelDolar.TabIndex = 0;
            this.labelDolar.Text = "Dólar";
            this.labelDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCompra
            // 
            this.labelCompra.AutoSize = true;
            this.labelCompra.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompra.Location = new System.Drawing.Point(47, 96);
            this.labelCompra.Name = "labelCompra";
            this.labelCompra.Size = new System.Drawing.Size(97, 24);
            this.labelCompra.TabIndex = 1;
            this.labelCompra.Text = "Compra:";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(306, 227);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(101, 34);
            this.buttonPesquisar.TabIndex = 3;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // labelVenda
            // 
            this.labelVenda.AutoSize = true;
            this.labelVenda.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVenda.Location = new System.Drawing.Point(47, 139);
            this.labelVenda.Name = "labelVenda";
            this.labelVenda.Size = new System.Drawing.Size(79, 24);
            this.labelVenda.TabIndex = 4;
            this.labelVenda.Text = "Venda:";
            // 
            // labelVariacao
            // 
            this.labelVariacao.AutoSize = true;
            this.labelVariacao.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVariacao.Location = new System.Drawing.Point(47, 182);
            this.labelVariacao.Name = "labelVariacao";
            this.labelVariacao.Size = new System.Drawing.Size(103, 24);
            this.labelVariacao.TabIndex = 5;
            this.labelVariacao.Text = "Variação:";
            // 
            // lblCompra
            // 
            this.lblCompra.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompra.Location = new System.Drawing.Point(185, 96);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(79, 24);
            this.lblCompra.TabIndex = 6;
            this.lblCompra.Text = "0,0";
            this.lblCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVenda
            // 
            this.lblVenda.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.Location = new System.Drawing.Point(185, 139);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(79, 24);
            this.lblVenda.TabIndex = 7;
            this.lblVenda.Text = "0,0";
            this.lblVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVariacao
            // 
            this.lblVariacao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblVariacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVariacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariacao.Location = new System.Drawing.Point(185, 182);
            this.lblVariacao.Name = "lblVariacao";
            this.lblVariacao.Size = new System.Drawing.Size(79, 24);
            this.lblVariacao.TabIndex = 8;
            this.lblVariacao.Text = "0,0";
            this.lblVariacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 273);
            this.Controls.Add(this.lblVariacao);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.labelVariacao);
            this.Controls.Add(this.labelVenda);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.labelCompra);
            this.Controls.Add(this.labelDolar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCotacaoDolar";
            this.Text = "Cotação Dolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDolar;
        private System.Windows.Forms.Label labelCompra;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Label labelVenda;
        private System.Windows.Forms.Label labelVariacao;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Label lblVariacao;
    }
}

