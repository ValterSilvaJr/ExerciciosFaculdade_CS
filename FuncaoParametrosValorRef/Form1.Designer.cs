namespace FuncaoParametrosValorRef
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
            this.btnValor = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.lblVarA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVarA = new System.Windows.Forms.TextBox();
            this.txtVarB = new System.Windows.Forms.TextBox();
            this.txtResA = new System.Windows.Forms.TextBox();
            this.txtResB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValor
            // 
            this.btnValor.Location = new System.Drawing.Point(39, 96);
            this.btnValor.Name = "btnValor";
            this.btnValor.Size = new System.Drawing.Size(90, 23);
            this.btnValor.TabIndex = 0;
            this.btnValor.Text = "Por Valor";
            this.btnValor.UseVisualStyleBackColor = true;
            this.btnValor.Click += new System.EventHandler(this.btnValor_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(140, 96);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(90, 23);
            this.btnRef.TabIndex = 1;
            this.btnRef.Text = "Por Referência";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // lblVarA
            // 
            this.lblVarA.AutoSize = true;
            this.lblVarA.Location = new System.Drawing.Point(36, 17);
            this.lblVarA.Name = "lblVarA";
            this.lblVarA.Size = new System.Drawing.Size(55, 13);
            this.lblVarA.TabIndex = 2;
            this.lblVarA.Text = "Variável A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Variável B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Variável A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Variável B";
            // 
            // txtVarA
            // 
            this.txtVarA.Location = new System.Drawing.Point(97, 14);
            this.txtVarA.Name = "txtVarA";
            this.txtVarA.Size = new System.Drawing.Size(130, 20);
            this.txtVarA.TabIndex = 6;
            // 
            // txtVarB
            // 
            this.txtVarB.Location = new System.Drawing.Point(97, 52);
            this.txtVarB.Name = "txtVarB";
            this.txtVarB.Size = new System.Drawing.Size(130, 20);
            this.txtVarB.TabIndex = 7;
            // 
            // txtResA
            // 
            this.txtResA.Location = new System.Drawing.Point(97, 142);
            this.txtResA.Name = "txtResA";
            this.txtResA.ReadOnly = true;
            this.txtResA.Size = new System.Drawing.Size(130, 20);
            this.txtResA.TabIndex = 8;
            // 
            // txtResB
            // 
            this.txtResB.Location = new System.Drawing.Point(97, 183);
            this.txtResB.Name = "txtResB";
            this.txtResB.ReadOnly = true;
            this.txtResB.Size = new System.Drawing.Size(130, 20);
            this.txtResB.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 220);
            this.Controls.Add(this.txtResB);
            this.Controls.Add(this.txtResA);
            this.Controls.Add(this.txtVarB);
            this.Controls.Add(this.txtVarA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVarA);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnValor);
            this.Name = "Form1";
            this.Text = "Valor / Referência";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValor;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Label lblVarA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVarA;
        private System.Windows.Forms.TextBox txtVarB;
        private System.Windows.Forms.TextBox txtResA;
        private System.Windows.Forms.TextBox txtResB;
    }
}

