namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbNIM = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.miAlamat = new System.Windows.Forms.TextBox();
            this.tbThnAkademik = new System.Windows.Forms.TextBox();
            this.tbSemester = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.rbCewe = new System.Windows.Forms.RadioButton();
            this.cbPROGRAMSTUDI = new System.Windows.Forms.ComboBox();
            this.tbMataKuliah = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kurikulumMerdeka = new System.Windows.Forms.RadioButton();
            this.kurikulum2013 = new System.Windows.Forms.RadioButton();
            this.kurikulum2006 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mataManagement = new System.Windows.Forms.CheckBox();
            this.mataSistemO = new System.Windows.Forms.CheckBox();
            this.matajaringanK = new System.Windows.Forms.CheckBox();
            this.mataPengantarL = new System.Windows.Forms.CheckBox();
            this.mataPenKewarganegaraan = new System.Windows.Forms.CheckBox();
            this.mataPenAgama = new System.Windows.Forms.CheckBox();
            this.mataFisika = new System.Windows.Forms.CheckBox();
            this.mataPemrog4 = new System.Windows.Forms.CheckBox();
            this.mataPemrog3 = new System.Windows.Forms.CheckBox();
            this.mataPemrog2 = new System.Windows.Forms.CheckBox();
            this.mataPemrog1 = new System.Windows.Forms.CheckBox();
            this.mataMatematika = new System.Windows.Forms.CheckBox();
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNIM
            // 
            this.tbNIM.Location = new System.Drawing.Point(175, 21);
            this.tbNIM.Name = "tbNIM";
            this.tbNIM.Size = new System.Drawing.Size(167, 20);
            this.tbNIM.TabIndex = 0;
            this.tbNIM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(175, 88);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(167, 20);
            this.tbNama.TabIndex = 1;
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged);
            // 
            // miAlamat
            // 
            this.miAlamat.Location = new System.Drawing.Point(175, 169);
            this.miAlamat.Multiline = true;
            this.miAlamat.Name = "miAlamat";
            this.miAlamat.Size = new System.Drawing.Size(167, 91);
            this.miAlamat.TabIndex = 2;
            this.miAlamat.TextChanged += new System.EventHandler(this.txAlamat);
            // 
            // tbThnAkademik
            // 
            this.tbThnAkademik.Location = new System.Drawing.Point(530, 162);
            this.tbThnAkademik.Name = "tbThnAkademik";
            this.tbThnAkademik.Size = new System.Drawing.Size(165, 20);
            this.tbThnAkademik.TabIndex = 3;
            this.tbThnAkademik.TextChanged += new System.EventHandler(this.tbThnAkademik_TextChanged);
            // 
            // tbSemester
            // 
            this.tbSemester.Location = new System.Drawing.Point(530, 92);
            this.tbSemester.Name = "tbSemester";
            this.tbSemester.Size = new System.Drawing.Size(165, 20);
            this.tbSemester.TabIndex = 4;
            this.tbSemester.TextChanged += new System.EventHandler(this.tbSemester_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tahun Akademik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Semester";
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Location = new System.Drawing.Point(175, 133);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(64, 17);
            this.rbLaki.TabIndex = 10;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki-laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // rbCewe
            // 
            this.rbCewe.AutoSize = true;
            this.rbCewe.Location = new System.Drawing.Point(263, 133);
            this.rbCewe.Name = "rbCewe";
            this.rbCewe.Size = new System.Drawing.Size(79, 17);
            this.rbCewe.TabIndex = 11;
            this.rbCewe.TabStop = true;
            this.rbCewe.Text = "Perempuan";
            this.rbCewe.UseVisualStyleBackColor = true;
            // 
            // cbPROGRAMSTUDI
            // 
            this.cbPROGRAMSTUDI.FormattingEnabled = true;
            this.cbPROGRAMSTUDI.Items.AddRange(new object[] {
            "D4 Teknik Informatika",
            "D3 Teknik Informatika",
            "D4 Manajemen Bisnis",
            "D3 Manajemen Bisnis"});
            this.cbPROGRAMSTUDI.Location = new System.Drawing.Point(530, 18);
            this.cbPROGRAMSTUDI.Name = "cbPROGRAMSTUDI";
            this.cbPROGRAMSTUDI.Size = new System.Drawing.Size(165, 21);
            this.cbPROGRAMSTUDI.TabIndex = 12;
            this.cbPROGRAMSTUDI.SelectedIndexChanged += new System.EventHandler(this.cbPROGRAMSTUDI_SelectedIndexChanged);
            // 
            // tbMataKuliah
            // 
            this.tbMataKuliah.Location = new System.Drawing.Point(592, 215);
            this.tbMataKuliah.Name = "tbMataKuliah";
            this.tbMataKuliah.Size = new System.Drawing.Size(103, 45);
            this.tbMataKuliah.TabIndex = 13;
            this.tbMataKuliah.Text = "Pilih Mata Kuliah";
            this.tbMataKuliah.UseVisualStyleBackColor = true;
            this.tbMataKuliah.Click += new System.EventHandler(this.btMataKuliah_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Program Studi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Jenis Kelamin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kurikulumMerdeka);
            this.groupBox1.Controls.Add(this.kurikulum2013);
            this.groupBox1.Controls.Add(this.kurikulum2006);
            this.groupBox1.Location = new System.Drawing.Point(62, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 124);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kurikulum Pilihan";
            // 
            // kurikulumMerdeka
            // 
            this.kurikulumMerdeka.AutoSize = true;
            this.kurikulumMerdeka.Location = new System.Drawing.Point(0, 79);
            this.kurikulumMerdeka.Name = "kurikulumMerdeka";
            this.kurikulumMerdeka.Size = new System.Drawing.Size(116, 17);
            this.kurikulumMerdeka.TabIndex = 2;
            this.kurikulumMerdeka.TabStop = true;
            this.kurikulumMerdeka.Text = "Kurikulum Merdeka";
            this.kurikulumMerdeka.UseVisualStyleBackColor = true;
            this.kurikulumMerdeka.CheckedChanged += new System.EventHandler(this.kurikulumMerdeka_CheckedChanged);
            // 
            // kurikulum2013
            // 
            this.kurikulum2013.AutoSize = true;
            this.kurikulum2013.Location = new System.Drawing.Point(0, 55);
            this.kurikulum2013.Name = "kurikulum2013";
            this.kurikulum2013.Size = new System.Drawing.Size(98, 17);
            this.kurikulum2013.TabIndex = 1;
            this.kurikulum2013.TabStop = true;
            this.kurikulum2013.Text = "Kurikulum 2013";
            this.kurikulum2013.UseVisualStyleBackColor = true;
            this.kurikulum2013.CheckedChanged += new System.EventHandler(this.kurikulum2013_CheckedChanged);
            // 
            // kurikulum2006
            // 
            this.kurikulum2006.AutoSize = true;
            this.kurikulum2006.Location = new System.Drawing.Point(0, 31);
            this.kurikulum2006.Name = "kurikulum2006";
            this.kurikulum2006.Size = new System.Drawing.Size(98, 17);
            this.kurikulum2006.TabIndex = 0;
            this.kurikulum2006.TabStop = true;
            this.kurikulum2006.Text = "Kurikulum 2006";
            this.kurikulum2006.UseVisualStyleBackColor = true;
            this.kurikulum2006.CheckedChanged += new System.EventHandler(this.Kurik2006);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mataManagement);
            this.groupBox2.Controls.Add(this.mataSistemO);
            this.groupBox2.Controls.Add(this.matajaringanK);
            this.groupBox2.Controls.Add(this.mataPengantarL);
            this.groupBox2.Controls.Add(this.mataPenKewarganegaraan);
            this.groupBox2.Controls.Add(this.mataPenAgama);
            this.groupBox2.Controls.Add(this.mataFisika);
            this.groupBox2.Controls.Add(this.mataPemrog4);
            this.groupBox2.Controls.Add(this.mataPemrog3);
            this.groupBox2.Controls.Add(this.mataPemrog2);
            this.groupBox2.Controls.Add(this.mataPemrog1);
            this.groupBox2.Controls.Add(this.mataMatematika);
            this.groupBox2.Location = new System.Drawing.Point(315, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 145);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mata Kuliah Pilihan";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // mataManagement
            // 
            this.mataManagement.AutoSize = true;
            this.mataManagement.Location = new System.Drawing.Point(293, 122);
            this.mataManagement.Name = "mataManagement";
            this.mataManagement.Size = new System.Drawing.Size(155, 17);
            this.mataManagement.TabIndex = 11;
            this.mataManagement.Text = "Management Rantai Pasok";
            this.mataManagement.UseVisualStyleBackColor = true;
            // 
            // mataSistemO
            // 
            this.mataSistemO.AutoSize = true;
            this.mataSistemO.Location = new System.Drawing.Point(293, 90);
            this.mataSistemO.Name = "mataSistemO";
            this.mataSistemO.Size = new System.Drawing.Size(96, 17);
            this.mataSistemO.TabIndex = 10;
            this.mataSistemO.Text = "Sistem Operasi";
            this.mataSistemO.UseVisualStyleBackColor = true;
            // 
            // matajaringanK
            // 
            this.matajaringanK.AutoSize = true;
            this.matajaringanK.Location = new System.Drawing.Point(293, 55);
            this.matajaringanK.Name = "matajaringanK";
            this.matajaringanK.Size = new System.Drawing.Size(114, 17);
            this.matajaringanK.TabIndex = 9;
            this.matajaringanK.Text = "Jaringan Komputer";
            this.matajaringanK.UseVisualStyleBackColor = true;
            // 
            // mataPengantarL
            // 
            this.mataPengantarL.AutoSize = true;
            this.mataPengantarL.Location = new System.Drawing.Point(293, 19);
            this.mataPengantarL.Name = "mataPengantarL";
            this.mataPengantarL.Size = new System.Drawing.Size(114, 17);
            this.mataPengantarL.TabIndex = 8;
            this.mataPengantarL.Text = "Pengantar Logistik";
            this.mataPengantarL.UseVisualStyleBackColor = true;
            // 
            // mataPenKewarganegaraan
            // 
            this.mataPenKewarganegaraan.AutoSize = true;
            this.mataPenKewarganegaraan.Location = new System.Drawing.Point(106, 122);
            this.mataPenKewarganegaraan.Name = "mataPenKewarganegaraan";
            this.mataPenKewarganegaraan.Size = new System.Drawing.Size(169, 17);
            this.mataPenKewarganegaraan.TabIndex = 7;
            this.mataPenKewarganegaraan.Text = "Pendidikan Kewarganegaraan";
            this.mataPenKewarganegaraan.UseVisualStyleBackColor = true;
            // 
            // mataPenAgama
            // 
            this.mataPenAgama.AutoSize = true;
            this.mataPenAgama.Location = new System.Drawing.Point(106, 90);
            this.mataPenAgama.Name = "mataPenAgama";
            this.mataPenAgama.Size = new System.Drawing.Size(115, 17);
            this.mataPenAgama.TabIndex = 6;
            this.mataPenAgama.Text = "Pendidikan Agama";
            this.mataPenAgama.UseVisualStyleBackColor = true;
            // 
            // mataFisika
            // 
            this.mataFisika.AutoSize = true;
            this.mataFisika.Location = new System.Drawing.Point(106, 55);
            this.mataFisika.Name = "mataFisika";
            this.mataFisika.Size = new System.Drawing.Size(53, 17);
            this.mataFisika.TabIndex = 5;
            this.mataFisika.Text = "Fisika";
            this.mataFisika.UseVisualStyleBackColor = true;
            // 
            // mataPemrog4
            // 
            this.mataPemrog4.AutoSize = true;
            this.mataPemrog4.Location = new System.Drawing.Point(106, 20);
            this.mataPemrog4.Name = "mataPemrog4";
            this.mataPemrog4.Size = new System.Drawing.Size(97, 17);
            this.mataPemrog4.TabIndex = 4;
            this.mataPemrog4.Text = "Pemograman 4";
            this.mataPemrog4.UseVisualStyleBackColor = true;
            // 
            // mataPemrog3
            // 
            this.mataPemrog3.AutoSize = true;
            this.mataPemrog3.Location = new System.Drawing.Point(1, 122);
            this.mataPemrog3.Name = "mataPemrog3";
            this.mataPemrog3.Size = new System.Drawing.Size(97, 17);
            this.mataPemrog3.TabIndex = 3;
            this.mataPemrog3.Text = "Pemograman 3";
            this.mataPemrog3.UseVisualStyleBackColor = true;
            // 
            // mataPemrog2
            // 
            this.mataPemrog2.AutoSize = true;
            this.mataPemrog2.Location = new System.Drawing.Point(0, 90);
            this.mataPemrog2.Name = "mataPemrog2";
            this.mataPemrog2.Size = new System.Drawing.Size(97, 17);
            this.mataPemrog2.TabIndex = 2;
            this.mataPemrog2.Text = "Pemograman 2";
            this.mataPemrog2.UseVisualStyleBackColor = true;
            // 
            // mataPemrog1
            // 
            this.mataPemrog1.AutoSize = true;
            this.mataPemrog1.Location = new System.Drawing.Point(0, 55);
            this.mataPemrog1.Name = "mataPemrog1";
            this.mataPemrog1.Size = new System.Drawing.Size(97, 17);
            this.mataPemrog1.TabIndex = 1;
            this.mataPemrog1.Text = "Pemograman 1";
            this.mataPemrog1.UseVisualStyleBackColor = true;
            // 
            // mataMatematika
            // 
            this.mataMatematika.AutoSize = true;
            this.mataMatematika.Location = new System.Drawing.Point(1, 20);
            this.mataMatematika.Name = "mataMatematika";
            this.mataMatematika.Size = new System.Drawing.Size(81, 17);
            this.mataMatematika.TabIndex = 0;
            this.mataMatematika.Text = "Matematika";
            this.mataMatematika.UseVisualStyleBackColor = true;
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 523);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMataKuliah);
            this.Controls.Add(this.cbPROGRAMSTUDI);
            this.Controls.Add(this.rbCewe);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSemester);
            this.Controls.Add(this.tbThnAkademik);
            this.Controls.Add(this.miAlamat);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbNIM);
            this.Name = "Form1";
            this.Text = "Form Pilihan Matkul";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNIM;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox miAlamat;
        private System.Windows.Forms.TextBox tbThnAkademik;
        private System.Windows.Forms.TextBox tbSemester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.RadioButton rbCewe;
        private System.Windows.Forms.ComboBox cbPROGRAMSTUDI;
        private System.Windows.Forms.Button tbMataKuliah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton kurikulumMerdeka;
        private System.Windows.Forms.RadioButton kurikulum2013;
        private System.Windows.Forms.RadioButton kurikulum2006;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox mataManagement;
        private System.Windows.Forms.CheckBox mataSistemO;
        private System.Windows.Forms.CheckBox matajaringanK;
        private System.Windows.Forms.CheckBox mataPengantarL;
        private System.Windows.Forms.CheckBox mataPenKewarganegaraan;
        private System.Windows.Forms.CheckBox mataPenAgama;
        private System.Windows.Forms.CheckBox mataFisika;
        private System.Windows.Forms.CheckBox mataPemrog4;
        private System.Windows.Forms.CheckBox mataPemrog3;
        private System.Windows.Forms.CheckBox mataPemrog2;
        private System.Windows.Forms.CheckBox mataPemrog1;
        private System.Windows.Forms.CheckBox mataMatematika;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

