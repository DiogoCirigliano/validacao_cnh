namespace prj37652_cnh
{
    partial class frm37652_cnh
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
            this.txtcnh = new System.Windows.Forms.TextBox();
            this.btnvalidar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcnh
            // 
            this.txtcnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnh.Location = new System.Drawing.Point(3, 29);
            this.txtcnh.MaxLength = 11;
            this.txtcnh.Multiline = true;
            this.txtcnh.Name = "txtcnh";
            this.txtcnh.Size = new System.Drawing.Size(210, 28);
            this.txtcnh.TabIndex = 0;
            this.txtcnh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcnh_KeyPress);
            // 
            // btnvalidar
            // 
            this.btnvalidar.Location = new System.Drawing.Point(135, 32);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(75, 23);
            this.btnvalidar.TabIndex = 1;
            this.btnvalidar.Text = "Validar";
            this.btnvalidar.UseVisualStyleBackColor = true;
            this.btnvalidar.Click += new System.EventHandler(this.btnvalidar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(7, 62);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite seu CNH";
            // 
            // frm37652_cnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(217, 81);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnvalidar);
            this.Controls.Add(this.txtcnh);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm37652_cnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcnh;
        private System.Windows.Forms.Button btnvalidar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
    }
}

