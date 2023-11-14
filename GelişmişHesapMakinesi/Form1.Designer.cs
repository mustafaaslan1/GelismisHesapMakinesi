namespace GelişmişHesapMakinesi
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
            this.btnC = new System.Windows.Forms.Button();
            this.btnKarakterSil = new System.Windows.Forms.Button();
            this.btnÇarpma = new System.Windows.Forms.Button();
            this.btnÜs = new System.Windows.Forms.Button();
            this.btnFaktoriyel = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnTers = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnToplama = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnÇıkarma = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnVirgül = new System.Windows.Forms.Button();
            this.btnBölme = new System.Windows.Forms.Button();
            this.btnKök = new System.Windows.Forms.Button();
            this.btnEşittir = new System.Windows.Forms.Button();
            this.btnGeçmiş = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEkok = new System.Windows.Forms.Button();
            this.btnEbob = new System.Windows.Forms.Button();
            this.btnTaban = new System.Windows.Forms.Button();
            this.btnKüp = new System.Windows.Forms.Button();
            this.btnKare = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelişmişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasılKullanılırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnC.Location = new System.Drawing.Point(26, 36);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(148, 58);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.İslemler);
            // 
            // btnKarakterSil
            // 
            this.btnKarakterSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKarakterSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKarakterSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKarakterSil.Location = new System.Drawing.Point(180, 36);
            this.btnKarakterSil.Name = "btnKarakterSil";
            this.btnKarakterSil.Size = new System.Drawing.Size(71, 58);
            this.btnKarakterSil.TabIndex = 1;
            this.btnKarakterSil.Text = "<";
            this.btnKarakterSil.UseVisualStyleBackColor = false;
            this.btnKarakterSil.Click += new System.EventHandler(this.İslemler);
            // 
            // btnÇarpma
            // 
            this.btnÇarpma.BackColor = System.Drawing.Color.Orange;
            this.btnÇarpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇarpma.Location = new System.Drawing.Point(257, 36);
            this.btnÇarpma.Name = "btnÇarpma";
            this.btnÇarpma.Size = new System.Drawing.Size(71, 58);
            this.btnÇarpma.TabIndex = 1;
            this.btnÇarpma.Text = "*";
            this.btnÇarpma.UseVisualStyleBackColor = false;
            this.btnÇarpma.Click += new System.EventHandler(this.İslemler);
            // 
            // btnÜs
            // 
            this.btnÜs.BackColor = System.Drawing.SystemColors.Control;
            this.btnÜs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜs.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnÜs.Location = new System.Drawing.Point(118, 38);
            this.btnÜs.Name = "btnÜs";
            this.btnÜs.Size = new System.Drawing.Size(71, 55);
            this.btnÜs.TabIndex = 1;
            this.btnÜs.Text = "Üs";
            this.btnÜs.UseVisualStyleBackColor = false;
            this.btnÜs.Click += new System.EventHandler(this.İslemler);
            // 
            // btnFaktoriyel
            // 
            this.btnFaktoriyel.BackColor = System.Drawing.SystemColors.Control;
            this.btnFaktoriyel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaktoriyel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFaktoriyel.Location = new System.Drawing.Point(118, 99);
            this.btnFaktoriyel.Name = "btnFaktoriyel";
            this.btnFaktoriyel.Size = new System.Drawing.Size(71, 55);
            this.btnFaktoriyel.TabIndex = 1;
            this.btnFaktoriyel.Text = "n!";
            this.btnFaktoriyel.UseVisualStyleBackColor = false;
            this.btnFaktoriyel.Click += new System.EventHandler(this.İslemler);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn7.Location = new System.Drawing.Point(26, 97);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(71, 58);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Rakamlar);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn8.Location = new System.Drawing.Point(103, 97);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(71, 58);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Rakamlar);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.Location = new System.Drawing.Point(180, 97);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(71, 58);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Rakamlar);
            // 
            // btnTers
            // 
            this.btnTers.BackColor = System.Drawing.Color.Orange;
            this.btnTers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTers.Location = new System.Drawing.Point(257, 97);
            this.btnTers.Name = "btnTers";
            this.btnTers.Size = new System.Drawing.Size(71, 58);
            this.btnTers.TabIndex = 1;
            this.btnTers.Text = "±";
            this.btnTers.UseVisualStyleBackColor = false;
            this.btnTers.Click += new System.EventHandler(this.İslemler);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.SystemColors.Control;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMod.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMod.Location = new System.Drawing.Point(19, 36);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(71, 55);
            this.btnMod.TabIndex = 1;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.İslemler);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.SystemColors.Control;
            this.btnPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPi.Location = new System.Drawing.Point(19, 99);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(71, 55);
            this.btnPi.TabIndex = 1;
            this.btnPi.Text = "PI";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.İslemler);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.Location = new System.Drawing.Point(26, 161);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(71, 58);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Rakamlar);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.Location = new System.Drawing.Point(103, 161);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(71, 58);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Rakamlar);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.Location = new System.Drawing.Point(180, 161);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(71, 58);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Rakamlar);
            // 
            // btnToplama
            // 
            this.btnToplama.BackColor = System.Drawing.Color.Orange;
            this.btnToplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToplama.Location = new System.Drawing.Point(257, 161);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(71, 58);
            this.btnToplama.TabIndex = 1;
            this.btnToplama.Text = "+";
            this.btnToplama.UseVisualStyleBackColor = false;
            this.btnToplama.Click += new System.EventHandler(this.İslemler);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(27, 225);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(71, 58);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Rakamlar);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(103, 225);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(71, 58);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Rakamlar);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(180, 225);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(71, 58);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Rakamlar);
            // 
            // btnÇıkarma
            // 
            this.btnÇıkarma.BackColor = System.Drawing.Color.Orange;
            this.btnÇıkarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇıkarma.Location = new System.Drawing.Point(257, 225);
            this.btnÇıkarma.Name = "btnÇıkarma";
            this.btnÇıkarma.Size = new System.Drawing.Size(71, 58);
            this.btnÇıkarma.TabIndex = 1;
            this.btnÇıkarma.Text = "-";
            this.btnÇıkarma.UseVisualStyleBackColor = false;
            this.btnÇıkarma.Click += new System.EventHandler(this.İslemler);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn0.Location = new System.Drawing.Point(103, 289);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(71, 58);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Rakamlar);
            // 
            // btnVirgül
            // 
            this.btnVirgül.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVirgül.Location = new System.Drawing.Point(27, 289);
            this.btnVirgül.Name = "btnVirgül";
            this.btnVirgül.Size = new System.Drawing.Size(71, 58);
            this.btnVirgül.TabIndex = 1;
            this.btnVirgül.Text = ",";
            this.btnVirgül.UseVisualStyleBackColor = true;
            this.btnVirgül.Click += new System.EventHandler(this.btnVirgül_Click);
            // 
            // btnBölme
            // 
            this.btnBölme.BackColor = System.Drawing.Color.Orange;
            this.btnBölme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBölme.Location = new System.Drawing.Point(257, 289);
            this.btnBölme.Name = "btnBölme";
            this.btnBölme.Size = new System.Drawing.Size(71, 58);
            this.btnBölme.TabIndex = 1;
            this.btnBölme.Text = "/";
            this.btnBölme.UseVisualStyleBackColor = false;
            this.btnBölme.Click += new System.EventHandler(this.İslemler);
            // 
            // btnKök
            // 
            this.btnKök.BackColor = System.Drawing.SystemColors.Control;
            this.btnKök.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKök.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKök.Location = new System.Drawing.Point(19, 161);
            this.btnKök.Name = "btnKök";
            this.btnKök.Size = new System.Drawing.Size(71, 55);
            this.btnKök.TabIndex = 1;
            this.btnKök.Text = "√";
            this.btnKök.UseVisualStyleBackColor = false;
            this.btnKök.Click += new System.EventHandler(this.İslemler);
            // 
            // btnEşittir
            // 
            this.btnEşittir.BackColor = System.Drawing.Color.Orange;
            this.btnEşittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEşittir.Location = new System.Drawing.Point(180, 289);
            this.btnEşittir.Name = "btnEşittir";
            this.btnEşittir.Size = new System.Drawing.Size(71, 58);
            this.btnEşittir.TabIndex = 1;
            this.btnEşittir.Text = "=";
            this.btnEşittir.UseVisualStyleBackColor = false;
            this.btnEşittir.Click += new System.EventHandler(this.İslemler);
            // 
            // btnGeçmiş
            // 
            this.btnGeçmiş.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGeçmiş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeçmiş.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeçmiş.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGeçmiş.Image = ((System.Drawing.Image)(resources.GetObject("btnGeçmiş.Image")));
            this.btnGeçmiş.Location = new System.Drawing.Point(67, 563);
            this.btnGeçmiş.Name = "btnGeçmiş";
            this.btnGeçmiş.Size = new System.Drawing.Size(69, 65);
            this.btnGeçmiş.TabIndex = 2;
            this.btnGeçmiş.UseVisualStyleBackColor = false;
            this.btnGeçmiş.Click += new System.EventHandler(this.btnGeçmiş_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(548, 103);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Geçmiş Listesi";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(15, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 454);
            this.listBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(619, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 514);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 137);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(163, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBölme);
            this.groupBox3.Controls.Add(this.btnÇıkarma);
            this.groupBox3.Controls.Add(this.btnToplama);
            this.groupBox3.Controls.Add(this.btnVirgül);
            this.groupBox3.Controls.Add(this.btnEşittir);
            this.groupBox3.Controls.Add(this.btn3);
            this.groupBox3.Controls.Add(this.btnTers);
            this.groupBox3.Controls.Add(this.btn6);
            this.groupBox3.Controls.Add(this.btn2);
            this.groupBox3.Controls.Add(this.btn9);
            this.groupBox3.Controls.Add(this.btn5);
            this.groupBox3.Controls.Add(this.btnÇarpma);
            this.groupBox3.Controls.Add(this.btn0);
            this.groupBox3.Controls.Add(this.btn1);
            this.groupBox3.Controls.Add(this.btn8);
            this.groupBox3.Controls.Add(this.btn4);
            this.groupBox3.Controls.Add(this.btnKarakterSil);
            this.groupBox3.Controls.Add(this.btn7);
            this.groupBox3.Controls.Add(this.btnC);
            this.groupBox3.Location = new System.Drawing.Point(12, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 380);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEkok);
            this.groupBox4.Controls.Add(this.btnEbob);
            this.groupBox4.Controls.Add(this.btnTaban);
            this.groupBox4.Controls.Add(this.btnKüp);
            this.groupBox4.Controls.Add(this.btnKare);
            this.groupBox4.Controls.Add(this.btnKök);
            this.groupBox4.Controls.Add(this.btnÜs);
            this.groupBox4.Controls.Add(this.btnFaktoriyel);
            this.groupBox4.Controls.Add(this.btnPi);
            this.groupBox4.Controls.Add(this.btnMod);
            this.groupBox4.Location = new System.Drawing.Point(398, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 380);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // btnEkok
            // 
            this.btnEkok.BackColor = System.Drawing.SystemColors.Control;
            this.btnEkok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkok.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEkok.Location = new System.Drawing.Point(118, 292);
            this.btnEkok.Name = "btnEkok";
            this.btnEkok.Size = new System.Drawing.Size(71, 55);
            this.btnEkok.TabIndex = 2;
            this.btnEkok.Text = "EKOK";
            this.btnEkok.UseVisualStyleBackColor = false;
            this.btnEkok.Click += new System.EventHandler(this.İslemler);
            // 
            // btnEbob
            // 
            this.btnEbob.BackColor = System.Drawing.SystemColors.Control;
            this.btnEbob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEbob.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEbob.Location = new System.Drawing.Point(19, 292);
            this.btnEbob.Name = "btnEbob";
            this.btnEbob.Size = new System.Drawing.Size(71, 55);
            this.btnEbob.TabIndex = 2;
            this.btnEbob.Text = "EBOB";
            this.btnEbob.UseVisualStyleBackColor = false;
            this.btnEbob.Click += new System.EventHandler(this.İslemler);
            // 
            // btnTaban
            // 
            this.btnTaban.BackColor = System.Drawing.SystemColors.Control;
            this.btnTaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaban.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTaban.Location = new System.Drawing.Point(19, 228);
            this.btnTaban.Name = "btnTaban";
            this.btnTaban.Size = new System.Drawing.Size(71, 55);
            this.btnTaban.TabIndex = 2;
            this.btnTaban.Text = "1/x";
            this.btnTaban.UseVisualStyleBackColor = false;
            this.btnTaban.Click += new System.EventHandler(this.İslemler);
            // 
            // btnKüp
            // 
            this.btnKüp.BackColor = System.Drawing.SystemColors.Control;
            this.btnKüp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKüp.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKüp.Location = new System.Drawing.Point(118, 228);
            this.btnKüp.Name = "btnKüp";
            this.btnKüp.Size = new System.Drawing.Size(71, 55);
            this.btnKüp.TabIndex = 2;
            this.btnKüp.Text = "x³";
            this.btnKüp.UseVisualStyleBackColor = false;
            this.btnKüp.Click += new System.EventHandler(this.İslemler);
            // 
            // btnKare
            // 
            this.btnKare.BackColor = System.Drawing.SystemColors.Control;
            this.btnKare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKare.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKare.Location = new System.Drawing.Point(118, 161);
            this.btnKare.Name = "btnKare";
            this.btnKare.Size = new System.Drawing.Size(71, 55);
            this.btnKare.TabIndex = 2;
            this.btnKare.Text = "x²";
            this.btnKare.UseVisualStyleBackColor = false;
            this.btnKare.Click += new System.EventHandler(this.İslemler);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görünümToolStripMenuItem,
            this.nasılKullanılırToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem,
            this.gelişmişToolStripMenuItem});
            this.görünümToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("görünümToolStripMenuItem.Image")));
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.standartToolStripMenuItem.Text = "Standart";
            this.standartToolStripMenuItem.Click += new System.EventHandler(this.standartToolStripMenuItem_Click);
            // 
            // gelişmişToolStripMenuItem
            // 
            this.gelişmişToolStripMenuItem.Name = "gelişmişToolStripMenuItem";
            this.gelişmişToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.gelişmişToolStripMenuItem.Text = "Gelişmiş";
            this.gelişmişToolStripMenuItem.Click += new System.EventHandler(this.gelişmişToolStripMenuItem_Click);
            // 
            // nasılKullanılırToolStripMenuItem
            // 
            this.nasılKullanılırToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nasılKullanılırToolStripMenuItem.Image")));
            this.nasılKullanılırToolStripMenuItem.Name = "nasılKullanılırToolStripMenuItem";
            this.nasılKullanılırToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.nasılKullanılırToolStripMenuItem.Text = "Nasıl Kullanılır?";
            this.nasılKullanılırToolStripMenuItem.Click += new System.EventHandler(this.nasılKullanılırToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(142, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Geçmiş";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(884, 631);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGeçmiş);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnKarakterSil;
        private System.Windows.Forms.Button btnÇarpma;
        private System.Windows.Forms.Button btnÜs;
        private System.Windows.Forms.Button btnFaktoriyel;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnTers;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnÇıkarma;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnVirgül;
        private System.Windows.Forms.Button btnBölme;
        private System.Windows.Forms.Button btnKök;
        private System.Windows.Forms.Button btnEşittir;
        private System.Windows.Forms.Button btnGeçmiş;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nasılKullanılırToolStripMenuItem;
        private System.Windows.Forms.Button btnKare;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelişmişToolStripMenuItem;
        private System.Windows.Forms.Button btnKüp;
        private System.Windows.Forms.Button btnTaban;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkok;
        private System.Windows.Forms.Button btnEbob;
        private System.Windows.Forms.Label label5;
    }
}

