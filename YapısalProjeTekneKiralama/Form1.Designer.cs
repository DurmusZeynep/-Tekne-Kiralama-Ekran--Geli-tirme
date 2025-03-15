namespace YapısalProje._22295639
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxAy = new System.Windows.Forms.ComboBox();
            this.comboBoxUzunluk = new System.Windows.Forms.ComboBox();
            this.comboBoxUzunluk2 = new System.Windows.Forms.ComboBox();
            this.comboBoxAy2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.ForeColor = System.Drawing.Color.Teal;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GULET 16M",
            "GULET 15M",
            "GULET 14M",
            "MOTOR YAT 16M",
            "MOTOR YAT 15M",
            "MOTOR YAT 14M"});
            this.comboBox1.Location = new System.Drawing.Point(592, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(860, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(581, 119);
            this.listBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(35, 292);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(576, 30);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "GULET İÇİN HESAPLAMA İŞLEMİ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(838, 292);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(626, 30);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "MOTOR YAT İÇİN HESAPLAMA İŞLEMİ";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(276, 651);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxAy
            // 
            this.comboBoxAy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxAy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAy.FormattingEnabled = true;
            this.comboBoxAy.Items.AddRange(new object[] {
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül ",
            "Ekim"});
            this.comboBoxAy.Location = new System.Drawing.Point(419, 440);
            this.comboBoxAy.Name = "comboBoxAy";
            this.comboBoxAy.Size = new System.Drawing.Size(161, 24);
            this.comboBoxAy.TabIndex = 11;
            // 
            // comboBoxUzunluk
            // 
            this.comboBoxUzunluk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxUzunluk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxUzunluk.FormattingEnabled = true;
            this.comboBoxUzunluk.Items.AddRange(new object[] {
            "16M",
            "15M",
            "14M"});
            this.comboBoxUzunluk.Location = new System.Drawing.Point(419, 379);
            this.comboBoxUzunluk.Name = "comboBoxUzunluk";
            this.comboBoxUzunluk.Size = new System.Drawing.Size(161, 24);
            this.comboBoxUzunluk.TabIndex = 12;
            this.comboBoxUzunluk.SelectedIndexChanged += new System.EventHandler(this.comboBoxUzunluk_SelectedIndexChanged);
            // 
            // comboBoxUzunluk2
            // 
            this.comboBoxUzunluk2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxUzunluk2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxUzunluk2.FormattingEnabled = true;
            this.comboBoxUzunluk2.Items.AddRange(new object[] {
            "16M",
            "15M",
            "14M"});
            this.comboBoxUzunluk2.Location = new System.Drawing.Point(1219, 375);
            this.comboBoxUzunluk2.Name = "comboBoxUzunluk2";
            this.comboBoxUzunluk2.Size = new System.Drawing.Size(161, 24);
            this.comboBoxUzunluk2.TabIndex = 15;
            this.comboBoxUzunluk2.SelectedIndexChanged += new System.EventHandler(this.comboBoxUzunluk2_SelectedIndexChanged);
            // 
            // comboBoxAy2
            // 
            this.comboBoxAy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxAy2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAy2.FormattingEnabled = true;
            this.comboBoxAy2.Items.AddRange(new object[] {
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül ",
            "Ekim"});
            this.comboBoxAy2.Location = new System.Drawing.Point(1219, 436);
            this.comboBoxAy2.Name = "comboBoxAy2";
            this.comboBoxAy2.Size = new System.Drawing.Size(161, 24);
            this.comboBoxAy2.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(1013, 651);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 55);
            this.button3.TabIndex = 19;
            this.button3.Text = "HESAPLA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fiyat bilgisini almak istediğiniz tekne türünü seçiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Uzunluğu Seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kiralanacak ayı seçiniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(834, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Uzunluğu Seçiniz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(834, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Kiralanacak ayı seçiniz:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(32, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(326, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Kiralama için başlangiç tarihi seçiniz:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(31, 558);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Kiralama için bitiş tarihi seçiniz:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(834, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Kiralama için başlangiç tarihi seçiniz:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker1.Location = new System.Drawing.Point(419, 500);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker2.Location = new System.Drawing.Point(419, 556);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker3.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePicker3.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker3.Location = new System.Drawing.Point(1219, 498);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker3.TabIndex = 31;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker4.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePicker4.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker4.Location = new System.Drawing.Point(1219, 556);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker4.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(834, 556);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(282, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Kiralama için bitiş tarihi seçiniz:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(32, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Ücretler günübürlüktir.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1518, 731);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxAy2);
            this.Controls.Add(this.comboBoxUzunluk2);
            this.Controls.Add(this.comboBoxUzunluk);
            this.Controls.Add(this.comboBoxAy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Tekne Kiralama Ücreti Hesaplayıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxAy;
        private System.Windows.Forms.ComboBox comboBoxUzunluk;
        private System.Windows.Forms.ComboBox comboBoxUzunluk2;
        private System.Windows.Forms.ComboBox comboBoxAy2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

