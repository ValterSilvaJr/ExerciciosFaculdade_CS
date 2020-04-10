namespace PercorrendoMatriz
{
    partial class Form1
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
            this.btnMatriz = new System.Windows.Forms.Button();
            this.lstMatriz = new System.Windows.Forms.ListBox();
            this.lblLinha = new System.Windows.Forms.Label();
            this.lblColunas = new System.Windows.Forms.Label();
            this.txtLinhas = new System.Windows.Forms.TextBox();
            this.txtColunas = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMatriz
            // 
            this.btnMatriz.Location = new System.Drawing.Point(12, 43);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(165, 26);
            this.btnMatriz.TabIndex = 0;
            this.btnMatriz.Text = "Matriz";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // lstMatriz
            // 
            this.lstMatriz.FormattingEnabled = true;
            this.lstMatriz.Location = new System.Drawing.Point(12, 114);
            this.lstMatriz.Name = "lstMatriz";
            this.lstMatriz.Size = new System.Drawing.Size(165, 303);
            this.lstMatriz.TabIndex = 1;
            // 
            // lblLinha
            // 
            this.lblLinha.AutoSize = true;
            this.lblLinha.Location = new System.Drawing.Point(9, 15);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(38, 13);
            this.lblLinha.TabIndex = 2;
            this.lblLinha.Text = "Linhas";
            // 
            // lblColunas
            // 
            this.lblColunas.AutoSize = true;
            this.lblColunas.Location = new System.Drawing.Point(94, 15);
            this.lblColunas.Name = "lblColunas";
            this.lblColunas.Size = new System.Drawing.Size(45, 13);
            this.lblColunas.TabIndex = 3;
            this.lblColunas.Text = "Colunas";
            // 
            // txtLinhas
            // 
            this.txtLinhas.Location = new System.Drawing.Point(49, 12);
            this.txtLinhas.Name = "txtLinhas";
            this.txtLinhas.Size = new System.Drawing.Size(39, 20);
            this.txtLinhas.TabIndex = 4;
            // 
            // txtColunas
            // 
            this.txtColunas.Location = new System.Drawing.Point(138, 12);
            this.txtColunas.Name = "txtColunas";
            this.txtColunas.Size = new System.Drawing.Size(39, 20);
            this.txtColunas.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(13, 76);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(165, 26);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 429);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtColunas);
            this.Controls.Add(this.txtLinhas);
            this.Controls.Add(this.lblColunas);
            this.Controls.Add(this.lblLinha);
            this.Controls.Add(this.lstMatriz);
            this.Controls.Add(this.btnMatriz);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.ListBox lstMatriz;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.Label lblColunas;
        private System.Windows.Forms.TextBox txtLinhas;
        private System.Windows.Forms.TextBox txtColunas;
        private System.Windows.Forms.Button btnLimpar;
    }
}

