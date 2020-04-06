namespace Operadores
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
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(49, 44);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(73, 41);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 1;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(52, 82);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(121, 23);
            this.btnPre.TabIndex = 2;
            this.btnPre.Text = "Incremento pré-fixado";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(191, 82);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(129, 23);
            this.btnPos.TabIndex = 3;
            this.btnPos.Text = "Incremento pós-fixado";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 238);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "Operador de Incremento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnPos;
    }
}

