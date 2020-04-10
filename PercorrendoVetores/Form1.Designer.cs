namespace PercorrendoVetores
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
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btnVetor = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lstNumeros2 = new System.Windows.Forms.ListBox();
            this.lblFor = new System.Windows.Forms.Label();
            this.lblForEach = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(12, 51);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(140, 316);
            this.lstNumeros.TabIndex = 0;
            // 
            // btnVetor
            // 
            this.btnVetor.Location = new System.Drawing.Point(157, 8);
            this.btnVetor.Name = "btnVetor";
            this.btnVetor.Size = new System.Drawing.Size(140, 23);
            this.btnVetor.TabIndex = 1;
            this.btnVetor.Text = "Vetor";
            this.btnVetor.UseVisualStyleBackColor = true;
            this.btnVetor.Click += new System.EventHandler(this.btnVetor_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(67, 10);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(85, 20);
            this.txtNum.TabIndex = 2;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(12, 13);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(49, 13);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Numeros";
            // 
            // lstNumeros2
            // 
            this.lstNumeros2.FormattingEnabled = true;
            this.lstNumeros2.Location = new System.Drawing.Point(157, 51);
            this.lstNumeros2.Name = "lstNumeros2";
            this.lstNumeros2.Size = new System.Drawing.Size(140, 316);
            this.lstNumeros2.TabIndex = 4;
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFor.Location = new System.Drawing.Point(12, 35);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(118, 12);
            this.lblFor.TabIndex = 5;
            this.lblFor.Text = "Laço de Repetição For";
            // 
            // lblForEach
            // 
            this.lblForEach.AutoSize = true;
            this.lblForEach.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForEach.Location = new System.Drawing.Point(155, 35);
            this.lblForEach.Name = "lblForEach";
            this.lblForEach.Size = new System.Drawing.Size(142, 12);
            this.lblForEach.TabIndex = 6;
            this.lblForEach.Text = "Laço de Repetição Foreach";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 385);
            this.Controls.Add(this.lblForEach);
            this.Controls.Add(this.lblFor);
            this.Controls.Add(this.lstNumeros2);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnVetor);
            this.Controls.Add(this.lstNumeros);
            this.Name = "Form1";
            this.Text = "Vetores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btnVetor;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.ListBox lstNumeros2;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Label lblForEach;
    }
}

