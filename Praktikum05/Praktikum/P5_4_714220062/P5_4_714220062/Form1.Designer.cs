namespace P5_4_714220062
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.JenisKelamin1 = new System.Windows.Forms.ComboBox();
            this.TanggalWaktu = new System.Windows.Forms.DateTimePicker();
            this.KelasGroupBox = new System.Windows.Forms.GroupBox();
            this.Komposer1 = new System.Windows.Forms.CheckBox();
            this.Vokal1 = new System.Windows.Forms.CheckBox();
            this.Drum1 = new System.Windows.Forms.CheckBox();
            this.Piano1 = new System.Windows.Forms.CheckBox();
            this.Konduktor1 = new System.Windows.Forms.CheckBox();
            this.Gitar1 = new System.Windows.Forms.CheckBox();
            this.Saxophone1 = new System.Windows.Forms.CheckBox();
            this.Biola1 = new System.Windows.Forms.CheckBox();
            this.GroupJadwalBox = new System.Windows.Forms.GroupBox();
            this.Minggu1 = new System.Windows.Forms.RadioButton();
            this.SabtuMinggu = new System.Windows.Forms.RadioButton();
            this.SelasaKamis = new System.Windows.Forms.RadioButton();
            this.SeninKamis = new System.Windows.Forms.RadioButton();
            this.tampilka1 = new System.Windows.Forms.Button();
            this.Selesai2 = new System.Windows.Forms.Button();
            this.KelasGroupBox.SuspendLayout();
            this.GroupJadwalBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kelamin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Lahir";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(307, 40);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 20);
            this.txtNama.TabIndex = 3;
            // 
            // JenisKelamin1
            // 
            this.JenisKelamin1.FormattingEnabled = true;
            this.JenisKelamin1.Items.AddRange(new object[] {
            "Pria ",
            "Wanita"});
            this.JenisKelamin1.Location = new System.Drawing.Point(307, 81);
            this.JenisKelamin1.Name = "JenisKelamin1";
            this.JenisKelamin1.Size = new System.Drawing.Size(200, 21);
            this.JenisKelamin1.TabIndex = 4;
            this.JenisKelamin1.Text = "Pilih Jenis Kelamin";
            // 
            // TanggalWaktu
            // 
            this.TanggalWaktu.Location = new System.Drawing.Point(307, 120);
            this.TanggalWaktu.Name = "TanggalWaktu";
            this.TanggalWaktu.Size = new System.Drawing.Size(200, 20);
            this.TanggalWaktu.TabIndex = 5;
            this.TanggalWaktu.ValueChanged += new System.EventHandler(this.TanggalWaktu_ValueChanged);
            // 
            // KelasGroupBox
            // 
            this.KelasGroupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KelasGroupBox.BackgroundImage")));
            this.KelasGroupBox.Controls.Add(this.Komposer1);
            this.KelasGroupBox.Controls.Add(this.Vokal1);
            this.KelasGroupBox.Controls.Add(this.Drum1);
            this.KelasGroupBox.Controls.Add(this.Piano1);
            this.KelasGroupBox.Controls.Add(this.Konduktor1);
            this.KelasGroupBox.Controls.Add(this.Gitar1);
            this.KelasGroupBox.Controls.Add(this.Saxophone1);
            this.KelasGroupBox.Controls.Add(this.Biola1);
            this.KelasGroupBox.Location = new System.Drawing.Point(72, 172);
            this.KelasGroupBox.Name = "KelasGroupBox";
            this.KelasGroupBox.Size = new System.Drawing.Size(297, 203);
            this.KelasGroupBox.TabIndex = 6;
            this.KelasGroupBox.TabStop = false;
            this.KelasGroupBox.Text = "Pilihan Kelas";
            this.KelasGroupBox.Enter += new System.EventHandler(this.KelasGroupBox_Enter);
            // 
            // Komposer1
            // 
            this.Komposer1.AutoSize = true;
            this.Komposer1.Location = new System.Drawing.Point(186, 162);
            this.Komposer1.Name = "Komposer1";
            this.Komposer1.Size = new System.Drawing.Size(73, 17);
            this.Komposer1.TabIndex = 7;
            this.Komposer1.Text = "Komposer";
            this.Komposer1.UseVisualStyleBackColor = true;
            // 
            // Vokal1
            // 
            this.Vokal1.AutoSize = true;
            this.Vokal1.Location = new System.Drawing.Point(186, 115);
            this.Vokal1.Name = "Vokal1";
            this.Vokal1.Size = new System.Drawing.Size(53, 17);
            this.Vokal1.TabIndex = 6;
            this.Vokal1.Text = "Vokal";
            this.Vokal1.UseVisualStyleBackColor = true;
            // 
            // Drum1
            // 
            this.Drum1.AutoSize = true;
            this.Drum1.Location = new System.Drawing.Point(186, 68);
            this.Drum1.Name = "Drum1";
            this.Drum1.Size = new System.Drawing.Size(51, 17);
            this.Drum1.TabIndex = 5;
            this.Drum1.Text = "Drum";
            this.Drum1.UseVisualStyleBackColor = true;
            // 
            // Piano1
            // 
            this.Piano1.AutoSize = true;
            this.Piano1.Location = new System.Drawing.Point(186, 20);
            this.Piano1.Name = "Piano1";
            this.Piano1.Size = new System.Drawing.Size(53, 17);
            this.Piano1.TabIndex = 4;
            this.Piano1.Text = "Piano";
            this.Piano1.UseVisualStyleBackColor = true;
            // 
            // Konduktor1
            // 
            this.Konduktor1.AutoSize = true;
            this.Konduktor1.Location = new System.Drawing.Point(6, 162);
            this.Konduktor1.Name = "Konduktor1";
            this.Konduktor1.Size = new System.Drawing.Size(75, 17);
            this.Konduktor1.TabIndex = 3;
            this.Konduktor1.Text = "Konduktor";
            this.Konduktor1.UseVisualStyleBackColor = true;
            // 
            // Gitar1
            // 
            this.Gitar1.AutoSize = true;
            this.Gitar1.Location = new System.Drawing.Point(7, 115);
            this.Gitar1.Name = "Gitar1";
            this.Gitar1.Size = new System.Drawing.Size(48, 17);
            this.Gitar1.TabIndex = 2;
            this.Gitar1.Text = "Gitar";
            this.Gitar1.UseVisualStyleBackColor = true;
            // 
            // Saxophone1
            // 
            this.Saxophone1.AutoSize = true;
            this.Saxophone1.Location = new System.Drawing.Point(6, 68);
            this.Saxophone1.Name = "Saxophone1";
            this.Saxophone1.Size = new System.Drawing.Size(80, 17);
            this.Saxophone1.TabIndex = 1;
            this.Saxophone1.Text = "Saxophone";
            this.Saxophone1.UseVisualStyleBackColor = true;
            this.Saxophone1.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Biola1
            // 
            this.Biola1.AutoSize = true;
            this.Biola1.Location = new System.Drawing.Point(7, 21);
            this.Biola1.Name = "Biola1";
            this.Biola1.Size = new System.Drawing.Size(49, 17);
            this.Biola1.TabIndex = 0;
            this.Biola1.Text = "Biola";
            this.Biola1.UseVisualStyleBackColor = true;
            // 
            // GroupJadwalBox
            // 
            this.GroupJadwalBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GroupJadwalBox.BackgroundImage")));
            this.GroupJadwalBox.Controls.Add(this.Minggu1);
            this.GroupJadwalBox.Controls.Add(this.SabtuMinggu);
            this.GroupJadwalBox.Controls.Add(this.SelasaKamis);
            this.GroupJadwalBox.Controls.Add(this.SeninKamis);
            this.GroupJadwalBox.Location = new System.Drawing.Point(448, 172);
            this.GroupJadwalBox.Name = "GroupJadwalBox";
            this.GroupJadwalBox.Size = new System.Drawing.Size(281, 203);
            this.GroupJadwalBox.TabIndex = 7;
            this.GroupJadwalBox.TabStop = false;
            this.GroupJadwalBox.Text = "Pilihan Jadwal";
            // 
            // Minggu1
            // 
            this.Minggu1.AutoSize = true;
            this.Minggu1.Location = new System.Drawing.Point(6, 161);
            this.Minggu1.Name = "Minggu1";
            this.Minggu1.Size = new System.Drawing.Size(126, 17);
            this.Minggu1.TabIndex = 3;
            this.Minggu1.TabStop = true;
            this.Minggu1.Text = "Minggu, 13.00- 17.00";
            this.Minggu1.UseVisualStyleBackColor = true;
            // 
            // SabtuMinggu
            // 
            this.SabtuMinggu.AutoSize = true;
            this.SabtuMinggu.Location = new System.Drawing.Point(6, 114);
            this.SabtuMinggu.Name = "SabtuMinggu";
            this.SabtuMinggu.Size = new System.Drawing.Size(160, 17);
            this.SabtuMinggu.TabIndex = 2;
            this.SabtuMinggu.TabStop = true;
            this.SabtuMinggu.Text = "Sabtu & Minggu, 09.00- 11.00";
            this.SabtuMinggu.UseVisualStyleBackColor = true;
            // 
            // SelasaKamis
            // 
            this.SelasaKamis.AutoSize = true;
            this.SelasaKamis.Location = new System.Drawing.Point(6, 67);
            this.SelasaKamis.Name = "SelasaKamis";
            this.SelasaKamis.Size = new System.Drawing.Size(154, 17);
            this.SelasaKamis.TabIndex = 1;
            this.SelasaKamis.TabStop = true;
            this.SelasaKamis.Text = "Selasa & Kamis, 14.00-16.00";
            this.SelasaKamis.UseVisualStyleBackColor = true;
            // 
            // SeninKamis
            // 
            this.SeninKamis.AutoSize = true;
            this.SeninKamis.Location = new System.Drawing.Point(6, 20);
            this.SeninKamis.Name = "SeninKamis";
            this.SeninKamis.Size = new System.Drawing.Size(149, 17);
            this.SeninKamis.TabIndex = 0;
            this.SeninKamis.TabStop = true;
            this.SeninKamis.Text = "Senin & Kamis, 14.00-16.00";
            this.SeninKamis.UseVisualStyleBackColor = true;
            // 
            // tampilka1
            // 
            this.tampilka1.Location = new System.Drawing.Point(287, 404);
            this.tampilka1.Name = "tampilka1";
            this.tampilka1.Size = new System.Drawing.Size(75, 23);
            this.tampilka1.TabIndex = 8;
            this.tampilka1.Text = "Tampilkan";
            this.tampilka1.UseVisualStyleBackColor = true;
            this.tampilka1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Selesai2
            // 
            this.Selesai2.Location = new System.Drawing.Point(405, 404);
            this.Selesai2.Name = "Selesai2";
            this.Selesai2.Size = new System.Drawing.Size(75, 23);
            this.Selesai2.TabIndex = 9;
            this.Selesai2.Text = "Selesai";
            this.Selesai2.UseVisualStyleBackColor = true;
            this.Selesai2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Selesai2);
            this.Controls.Add(this.tampilka1);
            this.Controls.Add(this.GroupJadwalBox);
            this.Controls.Add(this.KelasGroupBox);
            this.Controls.Add(this.TanggalWaktu);
            this.Controls.Add(this.JenisKelamin1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FORM PENDAFTARAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KelasGroupBox.ResumeLayout(false);
            this.KelasGroupBox.PerformLayout();
            this.GroupJadwalBox.ResumeLayout(false);
            this.GroupJadwalBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox JenisKelamin1;
        private System.Windows.Forms.DateTimePicker TanggalWaktu;
        private System.Windows.Forms.GroupBox KelasGroupBox;
        private System.Windows.Forms.CheckBox Komposer1;
        private System.Windows.Forms.CheckBox Vokal1;
        private System.Windows.Forms.CheckBox Drum1;
        private System.Windows.Forms.CheckBox Piano1;
        private System.Windows.Forms.CheckBox Konduktor1;
        private System.Windows.Forms.CheckBox Gitar1;
        private System.Windows.Forms.CheckBox Saxophone1;
        private System.Windows.Forms.CheckBox Biola1;
        private System.Windows.Forms.GroupBox GroupJadwalBox;
        private System.Windows.Forms.RadioButton Minggu1;
        private System.Windows.Forms.RadioButton SabtuMinggu;
        private System.Windows.Forms.RadioButton SelasaKamis;
        private System.Windows.Forms.RadioButton SeninKamis;
        private System.Windows.Forms.Button tampilka1;
        private System.Windows.Forms.Button Selesai2;
    }
}

