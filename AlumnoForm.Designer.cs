namespace programa1_practica_clase_alumno
{
    partial class AlumnoForm
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
            this.CapturarDesplegarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CapturarDesplegarButton
            // 
            this.CapturarDesplegarButton.Location = new System.Drawing.Point(95, 53);
            this.CapturarDesplegarButton.Name = "CapturarDesplegarButton";
            this.CapturarDesplegarButton.Size = new System.Drawing.Size(93, 46);
            this.CapturarDesplegarButton.TabIndex = 0;
            this.CapturarDesplegarButton.Text = "CAPTURAR";
            this.CapturarDesplegarButton.UseVisualStyleBackColor = true;
            this.CapturarDesplegarButton.Click += new System.EventHandler(this.CapturarDesplegarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(95, 115);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(93, 46);
            this.LimpiarButton.TabIndex = 1;
            this.LimpiarButton.Text = "LIMPIAR";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(95, 173);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(93, 46);
            this.SalirButton.TabIndex = 2;
            this.SalirButton.Text = "SALIR";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ResultadoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultadoTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ResultadoTextBox.Location = new System.Drawing.Point(252, 47);
            this.ResultadoTextBox.Multiline = true;
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.Size = new System.Drawing.Size(295, 199);
            this.ResultadoTextBox.TabIndex = 3;
            // 
            // AlumnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 328);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CapturarDesplegarButton);
            this.Name = "AlumnoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CapturarDesplegarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.TextBox ResultadoTextBox;
    }
}

