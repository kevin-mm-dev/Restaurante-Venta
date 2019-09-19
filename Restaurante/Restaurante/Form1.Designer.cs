namespace Restaurante
{
    partial class frm_Inicial
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
            this.btn_Principal_Saludar = new System.Windows.Forms.Button();
            this.pnl_Principal_BarraNavegacion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Principal_BarraNavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Principal_Saludar
            // 
            this.btn_Principal_Saludar.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Principal_Saludar.Location = new System.Drawing.Point(914, 73);
            this.btn_Principal_Saludar.Name = "btn_Principal_Saludar";
            this.btn_Principal_Saludar.Size = new System.Drawing.Size(125, 38);
            this.btn_Principal_Saludar.TabIndex = 0;
            this.btn_Principal_Saludar.Text = "Saludar";
            this.btn_Principal_Saludar.UseVisualStyleBackColor = true;
            this.btn_Principal_Saludar.Click += new System.EventHandler(this.btn_Principal_Saludar_Click);
            // 
            // pnl_Principal_BarraNavegacion
            // 
            this.pnl_Principal_BarraNavegacion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_Principal_BarraNavegacion.Controls.Add(this.label1);
            this.pnl_Principal_BarraNavegacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Principal_BarraNavegacion.Location = new System.Drawing.Point(-1, -1);
            this.pnl_Principal_BarraNavegacion.Name = "pnl_Principal_BarraNavegacion";
            this.pnl_Principal_BarraNavegacion.Size = new System.Drawing.Size(1071, 39);
            this.pnl_Principal_BarraNavegacion.TabIndex = 1;
            this.pnl_Principal_BarraNavegacion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Principal_BarraNavegacion_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(56, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 56);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subtitulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Parametros:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Texto";
            // 
            // frm_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 585);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl_Principal_BarraNavegacion);
            this.Controls.Add(this.btn_Principal_Saludar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.pnl_Principal_BarraNavegacion.ResumeLayout(false);
            this.pnl_Principal_BarraNavegacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_Principal_Saludar;
        private System.Windows.Forms.Panel pnl_Principal_BarraNavegacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

