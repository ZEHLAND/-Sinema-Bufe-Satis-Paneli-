namespace WindowsFormsApp13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Textmisir = new System.Windows.Forms.TextBox();
            this.Textsu = new System.Windows.Forms.TextBox();
            this.Textcay = new System.Windows.Forms.TextBox();
            this.Textbilet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Texttoplam = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Textkasa = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.Textbilet);
            this.groupBox1.Controls.Add(this.Textcay);
            this.groupBox1.Controls.Add(this.Textsu);
            this.groupBox1.Controls.Add(this.Textmisir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(29, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN MİKTARI";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Snow;
            this.groupBox2.Location = new System.Drawing.Point(327, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 306);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FİYAT TABLOSU";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.Textkasa);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.Texttoplam);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(637, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 306);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KASA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MISIR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(43, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "SU:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ÇAY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "BİLET:";
            // 
            // Textmisir
            // 
            this.Textmisir.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Textmisir.ForeColor = System.Drawing.SystemColors.Info;
            this.Textmisir.Location = new System.Drawing.Point(89, 42);
            this.Textmisir.Name = "Textmisir";
            this.Textmisir.Size = new System.Drawing.Size(146, 36);
            this.Textmisir.TabIndex = 0;
            // 
            // Textsu
            // 
            this.Textsu.BackColor = System.Drawing.SystemColors.MenuText;
            this.Textsu.ForeColor = System.Drawing.SystemColors.Info;
            this.Textsu.Location = new System.Drawing.Point(89, 98);
            this.Textsu.Name = "Textsu";
            this.Textsu.Size = new System.Drawing.Size(146, 36);
            this.Textsu.TabIndex = 4;
            // 
            // Textcay
            // 
            this.Textcay.BackColor = System.Drawing.SystemColors.MenuText;
            this.Textcay.ForeColor = System.Drawing.SystemColors.Info;
            this.Textcay.Location = new System.Drawing.Point(89, 147);
            this.Textcay.Name = "Textcay";
            this.Textcay.Size = new System.Drawing.Size(146, 36);
            this.Textcay.TabIndex = 5;
            // 
            // Textbilet
            // 
            this.Textbilet.BackColor = System.Drawing.SystemColors.MenuText;
            this.Textbilet.ForeColor = System.Drawing.SystemColors.Info;
            this.Textbilet.Location = new System.Drawing.Point(89, 211);
            this.Textbilet.Name = "Textbilet";
            this.Textbilet.Size = new System.Drawing.Size(146, 36);
            this.Textbilet.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(76, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "MISIR: 4 $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(86, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "SU : 1 $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(82, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "ÇAY: 4 $";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(75, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "BİLET: 8 $";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(57, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "TOPLAM : ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(-5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 185);
            this.panel1.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Jokerman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(547, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(340, 55);
            this.label10.TabIndex = 0;
            this.label10.Text = "SİNEMA && BÜFE ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(49, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 228);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Texttoplam
            // 
            this.Texttoplam.AutoSize = true;
            this.Texttoplam.BackColor = System.Drawing.Color.Black;
            this.Texttoplam.ForeColor = System.Drawing.Color.White;
            this.Texttoplam.Location = new System.Drawing.Point(166, 96);
            this.Texttoplam.Name = "Texttoplam";
            this.Texttoplam.Size = new System.Drawing.Size(52, 28);
            this.Texttoplam.TabIndex = 4;
            this.Texttoplam.Text = "00 $";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(73, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 28);
            this.label12.TabIndex = 5;
            this.label12.Text = "KASA:";
            // 
            // Textkasa
            // 
            this.Textkasa.AutoSize = true;
            this.Textkasa.BackColor = System.Drawing.Color.Black;
            this.Textkasa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Textkasa.Location = new System.Drawing.Point(151, 252);
            this.Textkasa.Name = "Textkasa";
            this.Textkasa.Size = new System.Drawing.Size(38, 28);
            this.Textkasa.TabIndex = 6;
            this.Textkasa.Text = "00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(589, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(257, 47);
            this.label14.TabIndex = 2;
            this.label14.Text = "SATIŞ PANELİ";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(61, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "SIFIRLA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(950, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Textbilet;
        private System.Windows.Forms.TextBox Textcay;
        private System.Windows.Forms.TextBox Textsu;
        private System.Windows.Forms.TextBox Textmisir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Textkasa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Texttoplam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
    }
}

