namespace Restaurante
{
    partial class catalogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_F = new System.Windows.Forms.Label();
            this.lbl_H = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelCont = new System.Windows.Forms.Panel();
            this.salir = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Header.SuspendLayout();
            this.Contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.pictureBox1);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.button5);
            this.Menu.Controls.Add(this.button4);
            this.Menu.Controls.Add(this.button3);
            this.Menu.Controls.Add(this.button2);
            this.Menu.Controls.Add(this.button1);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(200, 729);
            this.Menu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu Principal";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(-3, 479);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 69);
            this.button5.TabIndex = 1;
            this.button5.Text = "Bebidas";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(-3, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 69);
            this.button4.TabIndex = 1;
            this.button4.Text = "Golosinas";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(-3, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 69);
            this.button3.TabIndex = 1;
            this.button3.Text = "Aperitivos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(-3, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "Platillos fuertes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-3, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Platillos de entrada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Restaurante.Properties.Resources.res;
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.res;
            this.pictureBox1.InitialImage = global::Restaurante.Properties.Resources.res;
            this.pictureBox1.Location = new System.Drawing.Point(-223, -62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 194);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Header
            // 
            this.Header.Controls.Add(this.salir);
            this.Header.Controls.Add(this.label2);
            this.Header.Controls.Add(this.lbl_F);
            this.Header.Controls.Add(this.lbl_H);
            this.Header.Controls.Add(this.button7);
            this.Header.Controls.Add(this.button6);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(200, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1144, 92);
            this.Header.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1066, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "User";
            // 
            // lbl_F
            // 
            this.lbl_F.AutoSize = true;
            this.lbl_F.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_F.Location = new System.Drawing.Point(815, 53);
            this.lbl_F.Name = "lbl_F";
            this.lbl_F.Size = new System.Drawing.Size(47, 20);
            this.lbl_F.TabIndex = 2;
            this.lbl_F.Text = "Fecha";
            // 
            // lbl_H
            // 
            this.lbl_H.AutoSize = true;
            this.lbl_H.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_H.Location = new System.Drawing.Point(762, 9);
            this.lbl_H.Name = "lbl_H";
            this.lbl_H.Size = new System.Drawing.Size(59, 36);
            this.lbl_H.TabIndex = 1;
            this.lbl_H.Text = "Hora";
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(424, 33);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(171, 40);
            this.button7.TabIndex = 0;
            this.button7.Text = "Generar Ventas";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(176, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 40);
            this.button6.TabIndex = 0;
            this.button6.Text = "Ventas";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Contenedor
            // 
            this.Contenedor.Controls.Add(this.PanelCont);
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(200, 92);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1144, 637);
            this.Contenedor.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // PanelCont
            // 
            this.PanelCont.Location = new System.Drawing.Point(15, 18);
            this.PanelCont.Name = "PanelCont";
            this.PanelCont.Size = new System.Drawing.Size(1117, 607);
            this.PanelCont.TabIndex = 0;
            // 
            // salir
            // 
            this.salir.AutoSize = true;
            this.salir.Location = new System.Drawing.Point(1105, 56);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(27, 13);
            this.salir.TabIndex = 4;
            this.salir.Text = "Salir";
            // 
            // catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 729);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Menu);
            this.Name = "catalogo";
            this.Text = "Catalogo";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Contenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_F;
        private System.Windows.Forms.Label lbl_H;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelCont;
        private System.Windows.Forms.Label salir;
    }
}