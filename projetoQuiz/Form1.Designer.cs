namespace projetoQuiz
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonComecar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 50F);
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(286, 402);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "Foda";
            // 
            // buttonComecar
            // 
            this.buttonComecar.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonComecar.Font = new System.Drawing.Font("Showcard Gothic", 19.8F);
            this.buttonComecar.ForeColor = System.Drawing.Color.Violet;
            this.buttonComecar.Location = new System.Drawing.Point(714, 470);
            this.buttonComecar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonComecar.Name = "buttonComecar";
            this.buttonComecar.Size = new System.Drawing.Size(208, 56);
            this.buttonComecar.TabIndex = 1;
            this.buttonComecar.Text = "Começar";
            this.buttonComecar.UseVisualStyleBackColor = false;
            this.buttonComecar.Click += new System.EventHandler(this.buttonComecar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonFechar.Font = new System.Drawing.Font("Showcard Gothic", 19.8F);
            this.buttonFechar.ForeColor = System.Drawing.Color.Violet;
            this.buttonFechar.Location = new System.Drawing.Point(946, 470);
            this.buttonFechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(208, 56);
            this.buttonFechar.TabIndex = 1;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projetoQuiz.Properties.Resources.quiz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonComecar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Quiz Foda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonComecar;
        private System.Windows.Forms.Button buttonFechar;
    }
}

