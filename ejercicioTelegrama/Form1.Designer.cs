namespace ejercicioTelegrama
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textTelegrama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkUrgente = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTelegrama
            // 
            this.textTelegrama.Location = new System.Drawing.Point(89, 66);
            this.textTelegrama.Multiline = true;
            this.textTelegrama.Name = "textTelegrama";
            this.textTelegrama.Size = new System.Drawing.Size(616, 158);
            this.textTelegrama.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto";
            // 
            // chkUrgente
            // 
            this.chkUrgente.AutoSize = true;
            this.chkUrgente.Location = new System.Drawing.Point(89, 253);
            this.chkUrgente.Name = "chkUrgente";
            this.chkUrgente.Size = new System.Drawing.Size(84, 20);
            this.chkUrgente.TabIndex = 2;
            this.chkUrgente.Text = "Urgente?";
            this.chkUrgente.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Coste";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(158, 309);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Location = new System.Drawing.Point(479, 256);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(212, 72);
            this.btnCalcularPrecio.TabIndex = 6;
            this.btnCalcularPrecio.Text = "Calcular";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkUrgente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTelegrama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTelegrama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkUrgente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCalcularPrecio;
    }
}

