namespace MostrarPatas
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
            this.cboAnimais = new System.Windows.Forms.ComboBox();
            this.btnPatas = new System.Windows.Forms.Button();
            this.pctAnimais = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAnimais
            // 
            this.cboAnimais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnimais.FormattingEnabled = true;
            this.cboAnimais.Location = new System.Drawing.Point(12, 30);
            this.cboAnimais.Name = "cboAnimais";
            this.cboAnimais.Size = new System.Drawing.Size(345, 21);
            this.cboAnimais.Sorted = true;
            this.cboAnimais.TabIndex = 0;
            // 
            // btnPatas
            // 
            this.btnPatas.Location = new System.Drawing.Point(67, 57);
            this.btnPatas.Name = "btnPatas";
            this.btnPatas.Size = new System.Drawing.Size(219, 23);
            this.btnPatas.TabIndex = 1;
            this.btnPatas.Text = "Mostrar Patas";
            this.btnPatas.UseVisualStyleBackColor = true;
            this.btnPatas.Click += new System.EventHandler(this.btnPatas_Click);
            // 
            // pctAnimais
            // 
            this.pctAnimais.Location = new System.Drawing.Point(12, 104);
            this.pctAnimais.Name = "pctAnimais";
            this.pctAnimais.Size = new System.Drawing.Size(345, 187);
            this.pctAnimais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAnimais.TabIndex = 2;
            this.pctAnimais.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 303);
            this.Controls.Add(this.pctAnimais);
            this.Controls.Add(this.btnPatas);
            this.Controls.Add(this.cboAnimais);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Animais";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAnimais;
        private System.Windows.Forms.Button btnPatas;
        private System.Windows.Forms.PictureBox pctAnimais;
    }
}

