namespace hamurgerci_otomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ortaboyut = new System.Windows.Forms.RadioButton();
            this.buyukboyut = new System.Windows.Forms.RadioButton();
            this.kingboyut = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkivircik = new System.Windows.Forms.CheckBox();
            this.chhardal = new System.Windows.Forms.CheckBox();
            this.chpeynir = new System.Windows.Forms.CheckBox();
            this.chacisos = new System.Windows.Forms.CheckBox();
            this.chtursu = new System.Windows.Forms.CheckBox();
            this.chdomates = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "cesit1",
            "cesit2",
            "cesit3"});
            this.comboBox1.Location = new System.Drawing.Point(45, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BOYUT:";
            // 
            // ortaboyut
            // 
            this.ortaboyut.AutoSize = true;
            this.ortaboyut.Location = new System.Drawing.Point(66, 235);
            this.ortaboyut.Name = "ortaboyut";
            this.ortaboyut.Size = new System.Drawing.Size(45, 17);
            this.ortaboyut.TabIndex = 4;
            this.ortaboyut.TabStop = true;
            this.ortaboyut.Text = "Orta";
            this.ortaboyut.UseVisualStyleBackColor = true;
            // 
            // buyukboyut
            // 
            this.buyukboyut.AutoSize = true;
            this.buyukboyut.Location = new System.Drawing.Point(134, 235);
            this.buyukboyut.Name = "buyukboyut";
            this.buyukboyut.Size = new System.Drawing.Size(55, 17);
            this.buyukboyut.TabIndex = 5;
            this.buyukboyut.TabStop = true;
            this.buyukboyut.Text = "Büyük";
            this.buyukboyut.UseVisualStyleBackColor = true;
            // 
            // kingboyut
            // 
            this.kingboyut.AutoSize = true;
            this.kingboyut.Location = new System.Drawing.Point(210, 233);
            this.kingboyut.Name = "kingboyut";
            this.kingboyut.Size = new System.Drawing.Size(46, 17);
            this.kingboyut.TabIndex = 6;
            this.kingboyut.TabStop = true;
            this.kingboyut.Text = "King";
            this.kingboyut.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkivircik);
            this.groupBox1.Controls.Add(this.chhardal);
            this.groupBox1.Controls.Add(this.chpeynir);
            this.groupBox1.Controls.Add(this.chacisos);
            this.groupBox1.Controls.Add(this.chtursu);
            this.groupBox1.Controls.Add(this.chdomates);
            this.groupBox1.Location = new System.Drawing.Point(0, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 117);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekstralar";
            // 
            // chkivircik
            // 
            this.chkivircik.AutoSize = true;
            this.chkivircik.Location = new System.Drawing.Point(134, 94);
            this.chkivircik.Name = "chkivircik";
            this.chkivircik.Size = new System.Drawing.Size(60, 17);
            this.chkivircik.TabIndex = 5;
            this.chkivircik.Text = "Kıvırcık";
            this.chkivircik.UseVisualStyleBackColor = true;
            // 
            // chhardal
            // 
            this.chhardal.AutoSize = true;
            this.chhardal.Location = new System.Drawing.Point(134, 58);
            this.chhardal.Name = "chhardal";
            this.chhardal.Size = new System.Drawing.Size(57, 17);
            this.chhardal.TabIndex = 4;
            this.chhardal.Text = "Hardal";
            this.chhardal.UseVisualStyleBackColor = true;
            // 
            // chpeynir
            // 
            this.chpeynir.AutoSize = true;
            this.chpeynir.Location = new System.Drawing.Point(134, 19);
            this.chpeynir.Name = "chpeynir";
            this.chpeynir.Size = new System.Drawing.Size(55, 17);
            this.chpeynir.TabIndex = 3;
            this.chpeynir.Text = "Peynir";
            this.chpeynir.UseVisualStyleBackColor = true;
            // 
            // chacisos
            // 
            this.chacisos.AutoSize = true;
            this.chacisos.Location = new System.Drawing.Point(6, 94);
            this.chacisos.Name = "chacisos";
            this.chacisos.Size = new System.Drawing.Size(62, 17);
            this.chacisos.TabIndex = 2;
            this.chacisos.Text = "Acı Sos";
            this.chacisos.UseVisualStyleBackColor = true;
            // 
            // chtursu
            // 
            this.chtursu.AutoSize = true;
            this.chtursu.Location = new System.Drawing.Point(6, 58);
            this.chtursu.Name = "chtursu";
            this.chtursu.Size = new System.Drawing.Size(53, 17);
            this.chtursu.TabIndex = 1;
            this.chtursu.Text = "Turşu";
            this.chtursu.UseVisualStyleBackColor = true;
            // 
            // chdomates
            // 
            this.chdomates.AutoSize = true;
            this.chdomates.Location = new System.Drawing.Point(6, 19);
            this.chdomates.Name = "chdomates";
            this.chdomates.Size = new System.Drawing.Size(68, 17);
            this.chdomates.TabIndex = 0;
            this.chdomates.Text = "Domates";
            this.chdomates.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ADET:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(68, 390);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "AD SOYAD:";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(297, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(346, 470);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "AdSoyad";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Menu";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Seçili Bilgiyi Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(471, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 34);
            this.button3.TabIndex = 15;
            this.button3.Text = "Tümünü Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(641, 513);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kingboyut);
            this.Controls.Add(this.buyukboyut);
            this.Controls.Add(this.ortaboyut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Sipariş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ortaboyut;
        private System.Windows.Forms.RadioButton buyukboyut;
        private System.Windows.Forms.RadioButton kingboyut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkivircik;
        private System.Windows.Forms.CheckBox chhardal;
        private System.Windows.Forms.CheckBox chpeynir;
        private System.Windows.Forms.CheckBox chacisos;
        private System.Windows.Forms.CheckBox chtursu;
        private System.Windows.Forms.CheckBox chdomates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

