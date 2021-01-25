namespace BurgerKing
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEt = new System.Windows.Forms.Label();
            this.lblTavuk = new System.Windows.Forms.Label();
            this.lblKampanya = new System.Windows.Forms.Label();
            this.lblBoyut = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTatli = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lstSiparis = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BurgerKing.Properties.Resources.burger;
            this.pictureBox1.Location = new System.Drawing.Point(16, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblEt
            // 
            this.lblEt.AutoSize = true;
            this.lblEt.Location = new System.Drawing.Point(37, 285);
            this.lblEt.Name = "lblEt";
            this.lblEt.Size = new System.Drawing.Size(80, 15);
            this.lblEt.TabIndex = 1;
            this.lblEt.Text = "Et Ürünleri:";
            // 
            // lblTavuk
            // 
            this.lblTavuk.AutoSize = true;
            this.lblTavuk.Location = new System.Drawing.Point(37, 310);
            this.lblTavuk.Name = "lblTavuk";
            this.lblTavuk.Size = new System.Drawing.Size(104, 15);
            this.lblTavuk.TabIndex = 1;
            this.lblTavuk.Text = "Tavuk Ürünleri:";
            // 
            // lblKampanya
            // 
            this.lblKampanya.AutoSize = true;
            this.lblKampanya.Location = new System.Drawing.Point(37, 338);
            this.lblKampanya.Name = "lblKampanya";
            this.lblKampanya.Size = new System.Drawing.Size(95, 15);
            this.lblKampanya.TabIndex = 1;
            this.lblKampanya.Text = "Kampanyalar:";
            // 
            // lblBoyut
            // 
            this.lblBoyut.AutoSize = true;
            this.lblBoyut.Location = new System.Drawing.Point(37, 365);
            this.lblBoyut.Name = "lblBoyut";
            this.lblBoyut.Size = new System.Drawing.Size(46, 15);
            this.lblBoyut.TabIndex = 1;
            this.lblBoyut.Text = "Boyut:";
            this.lblBoyut.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(40, 424);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra Soslar";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(147, 57);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(95, 19);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Ranch Sos";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(147, 32);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(69, 19);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Hardal";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(19, 57);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(107, 19);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Barbüke Sos";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Acı Sos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "ketcap ve mayonez her üründe bulunmaktadır!";
            // 
            // lblTatli
            // 
            this.lblTatli.AutoSize = true;
            this.lblTatli.Location = new System.Drawing.Point(37, 540);
            this.lblTatli.Name = "lblTatli";
            this.lblTatli.Size = new System.Drawing.Size(73, 15);
            this.lblTatli.TabIndex = 3;
            this.lblTatli.Text = "TATLILAR:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(37, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 30);
            this.label7.TabIndex = 4;
            this.label7.Text = "Orta:Menü fiyatı\r\nKing:Menü fiyatı+5.00";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(71, 571);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(39, 15);
            this.lblAdet.TabIndex = 5;
            this.lblAdet.Text = "Adet:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(119, 569);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 21);
            this.numericUpDown1.TabIndex = 6;
            // 
            // lstSiparis
            // 
            this.lstSiparis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSiparis.FormattingEnabled = true;
            this.lstSiparis.ItemHeight = 15;
            this.lstSiparis.Location = new System.Drawing.Point(526, 14);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(325, 409);
            this.lstSiparis.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Siparis Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(729, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "HESAPLA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 282);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(167, 311);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(217, 23);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(167, 338);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(217, 23);
            this.comboBox3.TabIndex = 10;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(167, 367);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 19);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Orta";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(237, 367);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 19);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "King";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(270, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "sos adet fiyatı:1.25";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(119, 540);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(217, 23);
            this.comboBox4.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(615, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "siparisi temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 602);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstSiparis);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTatli);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBoyut);
            this.Controls.Add(this.lblKampanya);
            this.Controls.Add(this.lblTavuk);
            this.Controls.Add(this.lblEt);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEt;
        private System.Windows.Forms.Label lblTavuk;
        private System.Windows.Forms.Label lblKampanya;
        private System.Windows.Forms.Label lblBoyut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblTatli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox lstSiparis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button3;
    }
}

