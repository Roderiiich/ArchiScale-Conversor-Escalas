namespace ConversorEscalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCentimetros = new System.Windows.Forms.CheckBox();
            this.cbMetros = new System.Windows.Forms.CheckBox();
            this.txt150 = new System.Windows.Forms.TextBox();
            this.txt1100 = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMetro1 = new System.Windows.Forms.Label();
            this.lblCent2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCent1 = new System.Windows.Forms.Label();
            this.lblMetro2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONVERSOR A ESCALAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escala 1:50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SandyBrown;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Escala 1:100";
            // 
            // cbCentimetros
            // 
            this.cbCentimetros.AutoSize = true;
            this.cbCentimetros.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCentimetros.Location = new System.Drawing.Point(49, 71);
            this.cbCentimetros.Name = "cbCentimetros";
            this.cbCentimetros.Size = new System.Drawing.Size(123, 25);
            this.cbCentimetros.TabIndex = 3;
            this.cbCentimetros.Text = "Centímetros ";
            this.cbCentimetros.UseVisualStyleBackColor = true;
            this.cbCentimetros.CheckedChanged += new System.EventHandler(this.cbCentimetros_CheckedChanged);
            // 
            // cbMetros
            // 
            this.cbMetros.AutoSize = true;
            this.cbMetros.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMetros.Location = new System.Drawing.Point(326, 71);
            this.cbMetros.Name = "cbMetros";
            this.cbMetros.Size = new System.Drawing.Size(82, 25);
            this.cbMetros.TabIndex = 4;
            this.cbMetros.Text = "Metros";
            this.cbMetros.UseVisualStyleBackColor = true;
            this.cbMetros.CheckedChanged += new System.EventHandler(this.cbMetros_CheckedChanged);
            // 
            // txt150
            // 
            this.txt150.Cursor = System.Windows.Forms.Cursors.No;
            this.txt150.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt150.Location = new System.Drawing.Point(177, 419);
            this.txt150.Name = "txt150";
            this.txt150.ReadOnly = true;
            this.txt150.Size = new System.Drawing.Size(108, 27);
            this.txt150.TabIndex = 3;
            this.txt150.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt1100
            // 
            this.txt1100.Cursor = System.Windows.Forms.Cursors.No;
            this.txt1100.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1100.Location = new System.Drawing.Point(185, 460);
            this.txt1100.Name = "txt1100";
            this.txt1100.ReadOnly = true;
            this.txt1100.Size = new System.Drawing.Size(100, 27);
            this.txt1100.TabIndex = 4;
            this.txt1100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(186, 121);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 33);
            this.txtValor.TabIndex = 0;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PapayaWhip;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(174, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(200, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMetro1
            // 
            this.lblMetro1.AutoSize = true;
            this.lblMetro1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetro1.Location = new System.Drawing.Point(287, 422);
            this.lblMetro1.Name = "lblMetro1";
            this.lblMetro1.Size = new System.Drawing.Size(67, 20);
            this.lblMetro1.TabIndex = 11;
            this.lblMetro1.Text = "Metro(s)";
            this.lblMetro1.Visible = false;
            // 
            // lblCent2
            // 
            this.lblCent2.AutoSize = true;
            this.lblCent2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCent2.Location = new System.Drawing.Point(287, 464);
            this.lblCent2.Name = "lblCent2";
            this.lblCent2.Size = new System.Drawing.Size(101, 20);
            this.lblCent2.TabIndex = 12;
            this.lblCent2.Text = "Centímetro(s)";
            this.lblCent2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 605);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "by Roderich";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblCent1
            // 
            this.lblCent1.AutoSize = true;
            this.lblCent1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCent1.Location = new System.Drawing.Point(287, 423);
            this.lblCent1.Name = "lblCent1";
            this.lblCent1.Size = new System.Drawing.Size(101, 20);
            this.lblCent1.TabIndex = 15;
            this.lblCent1.Text = "Centímetro(s)";
            this.lblCent1.Visible = false;
            // 
            // lblMetro2
            // 
            this.lblMetro2.AutoSize = true;
            this.lblMetro2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetro2.Location = new System.Drawing.Point(289, 464);
            this.lblMetro2.Name = "lblMetro2";
            this.lblMetro2.Size = new System.Drawing.Size(67, 20);
            this.lblMetro2.TabIndex = 16;
            this.lblMetro2.Text = "Metro(s)";
            this.lblMetro2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(473, 627);
            this.Controls.Add(this.lblMetro2);
            this.Controls.Add(this.lblCent1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCent2);
            this.Controls.Add(this.lblMetro1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txt1100);
            this.Controls.Add(this.txt150);
            this.Controls.Add(this.cbMetros);
            this.Controls.Add(this.cbCentimetros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor a Escalas (by Roderich)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbCentimetros;
        private System.Windows.Forms.CheckBox cbMetros;
        private System.Windows.Forms.TextBox txt150;
        private System.Windows.Forms.TextBox txt1100;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMetro1;
        private System.Windows.Forms.Label lblCent2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCent1;
        private System.Windows.Forms.Label lblMetro2;
    }
}

