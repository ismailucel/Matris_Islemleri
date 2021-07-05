namespace Odev2_Soru2
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
            this.txtMatrixA = new System.Windows.Forms.TextBox();
            this.txtMatrixB = new System.Windows.Forms.TextBox();
            this.txtMatrixC = new System.Windows.Forms.TextBox();
            this.lblMatrixA = new System.Windows.Forms.Label();
            this.lblMatrixB = new System.Windows.Forms.Label();
            this.lblMatrixC = new System.Windows.Forms.Label();
            this.btnOlusturA = new System.Windows.Forms.Button();
            this.btnOlusturB = new System.Windows.Forms.Button();
            this.txtSatırA = new System.Windows.Forms.TextBox();
            this.txtSatırB = new System.Windows.Forms.TextBox();
            this.txtSütunA = new System.Windows.Forms.TextBox();
            this.txtSütunB = new System.Windows.Forms.TextBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblCols = new System.Windows.Forms.Label();
            this.btnBBirim = new System.Windows.Forms.Button();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbtnTers = new System.Windows.Forms.RadioButton();
            this.rdbtnİz = new System.Windows.Forms.RadioButton();
            this.rdbtnTranspoze = new System.Windows.Forms.RadioButton();
            this.rdbtnCıkarma = new System.Windows.Forms.RadioButton();
            this.rdbtnTopla = new System.Windows.Forms.RadioButton();
            this.rdbtnCarp = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.grpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMatrixA
            // 
            this.txtMatrixA.Location = new System.Drawing.Point(9, 32);
            this.txtMatrixA.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatrixA.Multiline = true;
            this.txtMatrixA.Name = "txtMatrixA";
            this.txtMatrixA.ReadOnly = true;
            this.txtMatrixA.Size = new System.Drawing.Size(285, 288);
            this.txtMatrixA.TabIndex = 4;
            // 
            // txtMatrixB
            // 
            this.txtMatrixB.Location = new System.Drawing.Point(298, 32);
            this.txtMatrixB.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatrixB.Multiline = true;
            this.txtMatrixB.Name = "txtMatrixB";
            this.txtMatrixB.ReadOnly = true;
            this.txtMatrixB.Size = new System.Drawing.Size(271, 288);
            this.txtMatrixB.TabIndex = 5;
            // 
            // txtMatrixC
            // 
            this.txtMatrixC.Location = new System.Drawing.Point(573, 32);
            this.txtMatrixC.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatrixC.Multiline = true;
            this.txtMatrixC.Name = "txtMatrixC";
            this.txtMatrixC.ReadOnly = true;
            this.txtMatrixC.Size = new System.Drawing.Size(305, 288);
            this.txtMatrixC.TabIndex = 6;
            // 
            // lblMatrixA
            // 
            this.lblMatrixA.AutoSize = true;
            this.lblMatrixA.Location = new System.Drawing.Point(6, 17);
            this.lblMatrixA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatrixA.Name = "lblMatrixA";
            this.lblMatrixA.Size = new System.Drawing.Size(48, 13);
            this.lblMatrixA.TabIndex = 3;
            this.lblMatrixA.Text = "Matris A:";
            // 
            // lblMatrixB
            // 
            this.lblMatrixB.AutoSize = true;
            this.lblMatrixB.Location = new System.Drawing.Point(295, 17);
            this.lblMatrixB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatrixB.Name = "lblMatrixB";
            this.lblMatrixB.Size = new System.Drawing.Size(48, 13);
            this.lblMatrixB.TabIndex = 4;
            this.lblMatrixB.Text = "Matris B:";
            // 
            // lblMatrixC
            // 
            this.lblMatrixC.AutoSize = true;
            this.lblMatrixC.Location = new System.Drawing.Point(579, 17);
            this.lblMatrixC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatrixC.Name = "lblMatrixC";
            this.lblMatrixC.Size = new System.Drawing.Size(48, 13);
            this.lblMatrixC.TabIndex = 5;
            this.lblMatrixC.Text = "Matris C:";
            // 
            // btnOlusturA
            // 
            this.btnOlusturA.Location = new System.Drawing.Point(9, 334);
            this.btnOlusturA.Margin = new System.Windows.Forms.Padding(2);
            this.btnOlusturA.Name = "btnOlusturA";
            this.btnOlusturA.Size = new System.Drawing.Size(96, 22);
            this.btnOlusturA.TabIndex = 6;
            this.btnOlusturA.Text = "Matris A Oluştur";
            this.btnOlusturA.UseVisualStyleBackColor = true;
            this.btnOlusturA.Click += new System.EventHandler(this.btnOlusturA_Click);
            // 
            // btnOlusturB
            // 
            this.btnOlusturB.Location = new System.Drawing.Point(8, 360);
            this.btnOlusturB.Margin = new System.Windows.Forms.Padding(2);
            this.btnOlusturB.Name = "btnOlusturB";
            this.btnOlusturB.Size = new System.Drawing.Size(96, 23);
            this.btnOlusturB.TabIndex = 7;
            this.btnOlusturB.Text = "Matris B Oluştur";
            this.btnOlusturB.UseVisualStyleBackColor = true;
            this.btnOlusturB.Click += new System.EventHandler(this.btnOlusturB_Click);
            // 
            // txtSatırA
            // 
            this.txtSatırA.Location = new System.Drawing.Point(138, 334);
            this.txtSatırA.Margin = new System.Windows.Forms.Padding(2);
            this.txtSatırA.Name = "txtSatırA";
            this.txtSatırA.Size = new System.Drawing.Size(77, 20);
            this.txtSatırA.TabIndex = 0;
            this.txtSatırA.Text = "3";
            this.txtSatırA.TextChanged += new System.EventHandler(this.txtSatırA_TextChanged);
            // 
            // txtSatırB
            // 
            this.txtSatırB.Location = new System.Drawing.Point(138, 360);
            this.txtSatırB.Margin = new System.Windows.Forms.Padding(2);
            this.txtSatırB.Name = "txtSatırB";
            this.txtSatırB.Size = new System.Drawing.Size(77, 20);
            this.txtSatırB.TabIndex = 2;
            this.txtSatırB.Text = "3";
            this.txtSatırB.TextChanged += new System.EventHandler(this.txtSatırB_TextChanged);
            // 
            // txtSütunA
            // 
            this.txtSütunA.Location = new System.Drawing.Point(241, 334);
            this.txtSütunA.Margin = new System.Windows.Forms.Padding(2);
            this.txtSütunA.Name = "txtSütunA";
            this.txtSütunA.Size = new System.Drawing.Size(77, 20);
            this.txtSütunA.TabIndex = 1;
            this.txtSütunA.Text = "3";
            this.txtSütunA.TextChanged += new System.EventHandler(this.txtSütunA_TextChanged);
            // 
            // txtSütunB
            // 
            this.txtSütunB.Location = new System.Drawing.Point(241, 360);
            this.txtSütunB.Margin = new System.Windows.Forms.Padding(2);
            this.txtSütunB.Name = "txtSütunB";
            this.txtSütunB.Size = new System.Drawing.Size(77, 20);
            this.txtSütunB.TabIndex = 3;
            this.txtSütunB.Text = "3";
            this.txtSütunB.TextChanged += new System.EventHandler(this.txtSütunB_TextChanged);
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(144, 385);
            this.lblRows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(39, 13);
            this.lblRows.TabIndex = 12;
            this.lblRows.Text = "Satırlar";
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(247, 385);
            this.lblCols.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(46, 13);
            this.lblCols.TabIndex = 13;
            this.lblCols.Text = "Sütunlar";
            // 
            // btnBBirim
            // 
            this.btnBBirim.Location = new System.Drawing.Point(341, 357);
            this.btnBBirim.Margin = new System.Windows.Forms.Padding(2);
            this.btnBBirim.Name = "btnBBirim";
            this.btnBBirim.Size = new System.Drawing.Size(94, 23);
            this.btnBBirim.TabIndex = 14;
            this.btnBBirim.Text = "Birim Matris Yap";
            this.btnBBirim.UseVisualStyleBackColor = true;
            this.btnBBirim.Click += new System.EventHandler(this.btnBBirim_Click);
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.button2);
            this.grpOperations.Controls.Add(this.button1);
            this.grpOperations.Controls.Add(this.rdbtnTers);
            this.grpOperations.Controls.Add(this.rdbtnİz);
            this.grpOperations.Controls.Add(this.rdbtnTranspoze);
            this.grpOperations.Controls.Add(this.rdbtnCıkarma);
            this.grpOperations.Controls.Add(this.rdbtnTopla);
            this.grpOperations.Controls.Add(this.rdbtnCarp);
            this.grpOperations.Location = new System.Drawing.Point(14, 412);
            this.grpOperations.Margin = new System.Windows.Forms.Padding(2);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Padding = new System.Windows.Forms.Padding(2);
            this.grpOperations.Size = new System.Drawing.Size(421, 118);
            this.grpOperations.TabIndex = 15;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "İşlem Seç:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Okuma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Yazdırma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbtnTers
            // 
            this.rdbtnTers.AutoSize = true;
            this.rdbtnTers.Location = new System.Drawing.Point(98, 61);
            this.rdbtnTers.Name = "rdbtnTers";
            this.rdbtnTers.Size = new System.Drawing.Size(74, 17);
            this.rdbtnTers.TabIndex = 19;
            this.rdbtnTers.TabStop = true;
            this.rdbtnTers.Text = "Tersi Alma";
            this.rdbtnTers.UseVisualStyleBackColor = true;
            // 
            // rdbtnİz
            // 
            this.rdbtnİz.AutoSize = true;
            this.rdbtnİz.Location = new System.Drawing.Point(8, 61);
            this.rdbtnİz.Name = "rdbtnİz";
            this.rdbtnİz.Size = new System.Drawing.Size(67, 17);
            this.rdbtnİz.TabIndex = 19;
            this.rdbtnİz.TabStop = true;
            this.rdbtnİz.Text = "İzi Bulma";
            this.rdbtnİz.UseVisualStyleBackColor = true;
            // 
            // rdbtnTranspoze
            // 
            this.rdbtnTranspoze.AutoSize = true;
            this.rdbtnTranspoze.Location = new System.Drawing.Point(258, 21);
            this.rdbtnTranspoze.Name = "rdbtnTranspoze";
            this.rdbtnTranspoze.Size = new System.Drawing.Size(75, 17);
            this.rdbtnTranspoze.TabIndex = 20;
            this.rdbtnTranspoze.TabStop = true;
            this.rdbtnTranspoze.Text = "Transpoze";
            this.rdbtnTranspoze.UseVisualStyleBackColor = true;
            // 
            // rdbtnCıkarma
            // 
            this.rdbtnCıkarma.AutoSize = true;
            this.rdbtnCıkarma.Location = new System.Drawing.Point(174, 21);
            this.rdbtnCıkarma.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnCıkarma.Name = "rdbtnCıkarma";
            this.rdbtnCıkarma.Size = new System.Drawing.Size(63, 17);
            this.rdbtnCıkarma.TabIndex = 2;
            this.rdbtnCıkarma.Text = "Çıkarma";
            this.rdbtnCıkarma.UseVisualStyleBackColor = true;
            // 
            // rdbtnTopla
            // 
            this.rdbtnTopla.AutoSize = true;
            this.rdbtnTopla.Location = new System.Drawing.Point(98, 21);
            this.rdbtnTopla.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnTopla.Name = "rdbtnTopla";
            this.rdbtnTopla.Size = new System.Drawing.Size(52, 17);
            this.rdbtnTopla.TabIndex = 1;
            this.rdbtnTopla.Text = "Topla";
            this.rdbtnTopla.UseVisualStyleBackColor = true;
            // 
            // rdbtnCarp
            // 
            this.rdbtnCarp.AutoSize = true;
            this.rdbtnCarp.Checked = true;
            this.rdbtnCarp.Location = new System.Drawing.Point(8, 21);
            this.rdbtnCarp.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnCarp.Name = "rdbtnCarp";
            this.rdbtnCarp.Size = new System.Drawing.Size(61, 17);
            this.rdbtnCarp.TabIndex = 0;
            this.rdbtnCarp.TabStop = true;
            this.rdbtnCarp.Text = "Çarpma";
            this.rdbtnCarp.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(14, 534);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(2);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(55, 24);
            this.btnHesapla.TabIndex = 16;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(274, 534);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 24);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Matris Sil";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(393, 534);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 24);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(469, 345);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(727, 398);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox2.Location = new System.Drawing.Point(8, 662);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(440, 81);
            this.richTextBox2.TabIndex = 24;
            this.richTextBox2.Text = "Çarpma, Toplama, Çıkarma işlemleri için iki matrisi de; transpoze, izi bulma ve t" +
    "ersi alma işlemleri için sadece A matrisini oluşturmanız yeterlidir.";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox3.Location = new System.Drawing.Point(8, 563);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(439, 93);
            this.richTextBox3.TabIndex = 23;
            this.richTextBox3.Text = "Yaptığınız işlemin text dosyasına kaydedilmesini istiyorsanız Hesapla butonuna ba" +
    "stıktan sonra Yazdırma butonuna tıklamanız gerekir. Ardından okuma butonu ile te" +
    "xt dosyasını görüntüleyebilirsiniz.";
            // 
            // frmMatrixCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1232, 808);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.btnBBirim);
            this.Controls.Add(this.lblCols);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.txtSütunB);
            this.Controls.Add(this.txtSütunA);
            this.Controls.Add(this.txtSatırB);
            this.Controls.Add(this.txtSatırA);
            this.Controls.Add(this.btnOlusturB);
            this.Controls.Add(this.btnOlusturA);
            this.Controls.Add(this.lblMatrixC);
            this.Controls.Add(this.lblMatrixB);
            this.Controls.Add(this.lblMatrixA);
            this.Controls.Add(this.txtMatrixC);
            this.Controls.Add(this.txtMatrixB);
            this.Controls.Add(this.txtMatrixA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Matris Hesaplayıcı";
            this.Text = "Matris Hesaplayıcı";
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatrixA;
        private System.Windows.Forms.TextBox txtMatrixB;
        private System.Windows.Forms.TextBox txtMatrixC;
        private System.Windows.Forms.Label lblMatrixA;
        private System.Windows.Forms.Label lblMatrixB;
        private System.Windows.Forms.Label lblMatrixC;
        private System.Windows.Forms.Button btnOlusturA;
        private System.Windows.Forms.Button btnOlusturB;
        private System.Windows.Forms.TextBox txtSatırA;
        private System.Windows.Forms.TextBox txtSatırB;
        private System.Windows.Forms.TextBox txtSütunA;
        private System.Windows.Forms.TextBox txtSütunB;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.Button btnBBirim;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.RadioButton rdbtnCıkarma;
        private System.Windows.Forms.RadioButton rdbtnTopla;
        private System.Windows.Forms.RadioButton rdbtnCarp;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdbtnTers;
        private System.Windows.Forms.RadioButton rdbtnİz;
        private System.Windows.Forms.RadioButton rdbtnTranspoze;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}

