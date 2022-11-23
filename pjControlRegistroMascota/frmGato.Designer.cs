namespace pjControlRegistroMascota
{
    partial class frmGato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGato));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreG = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblColorG = new System.Windows.Forms.Label();
            this.lblEdadG = new System.Windows.Forms.Label();
            this.lblCostoG = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Gato";
            // 
            // lblNombreG
            // 
            this.lblNombreG.AutoSize = true;
            this.lblNombreG.Location = new System.Drawing.Point(86, 96);
            this.lblNombreG.Name = "lblNombreG";
            this.lblNombreG.Size = new System.Drawing.Size(98, 15);
            this.lblNombreG.TabIndex = 1;
            this.lblNombreG.Text = "Nombre del Gato";
            this.lblNombreG.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "negro",
            "gris",
            "crema",
            "chocolate",
            "rojo",
            "canela",
            "azul"});
            this.comboBox1.Location = new System.Drawing.Point(86, 208);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            // 
            // lblColorG
            // 
            this.lblColorG.AutoSize = true;
            this.lblColorG.Location = new System.Drawing.Point(86, 180);
            this.lblColorG.Name = "lblColorG";
            this.lblColorG.Size = new System.Drawing.Size(78, 15);
            this.lblColorG.TabIndex = 4;
            this.lblColorG.Text = "Color de pelo";
            // 
            // lblEdadG
            // 
            this.lblEdadG.AutoSize = true;
            this.lblEdadG.Location = new System.Drawing.Point(86, 270);
            this.lblEdadG.Name = "lblEdadG";
            this.lblEdadG.Size = new System.Drawing.Size(33, 15);
            this.lblEdadG.TabIndex = 5;
            this.lblEdadG.Text = "Edad";
            // 
            // lblCostoG
            // 
            this.lblCostoG.AutoSize = true;
            this.lblCostoG.Location = new System.Drawing.Point(86, 347);
            this.lblCostoG.Name = "lblCostoG";
            this.lblCostoG.Size = new System.Drawing.Size(38, 15);
            this.lblCostoG.TabIndex = 6;
            this.lblCostoG.Text = "Costo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 374);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1 años",
            "2 años",
            "3 años",
            "4 años",
            "5 años",
            "6 años",
            "7 años",
            "8 años",
            "9 años",
            "10 años",
            "11 aos",
            "12 años",
            "13 años",
            "14 años"});
            this.comboBox2.Location = new System.Drawing.Point(86, 301);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmPerro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblCostoG);
            this.Controls.Add(this.lblEdadG);
            this.Controls.Add(this.lblColorG);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblNombreG);
            this.Controls.Add(this.label1);
            this.Name = "frmPerro";
            this.Text = "frmPerro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblNombreG;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label lblColorG;
        private Label lblEdadG;
        private Label lblCostoG;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
    }
}