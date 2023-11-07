namespace P6_4_714220062
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.WpWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.WpWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.WpCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTinggi = new System.Windows.Forms.TextBox();
            this.txtBerat = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAngka = new System.Windows.Forms.TextBox();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBesar = new System.Windows.Forms.TextBox();
            this.txtKecil = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.WpWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WpWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WpCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tinggi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Berat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Umur - NoKTP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Umur";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(183, 47);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(129, 20);
            this.txtNama.TabIndex = 7;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            this.txtNama.Leave += new System.EventHandler(this.txtNama_Leave);
            // 
            // WpWarning
            // 
            this.WpWarning.ContainerControl = this;
            this.WpWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("WpWarning.Icon")));
            // 
            // WpWrong
            // 
            this.WpWrong.ContainerControl = this;
            this.WpWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("WpWrong.Icon")));
            // 
            // WpCorrect
            // 
            this.WpCorrect.ContainerControl = this;
            this.WpCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("WpCorrect.Icon")));
            // 
            // txtTinggi
            // 
            this.txtTinggi.Location = new System.Drawing.Point(183, 83);
            this.txtTinggi.MaxLength = 3;
            this.txtTinggi.Name = "txtTinggi";
            this.txtTinggi.Size = new System.Drawing.Size(129, 20);
            this.txtTinggi.TabIndex = 8;
            this.txtTinggi.Leave += new System.EventHandler(this.txtTinggi_Leave);
            // 
            // txtBerat
            // 
            this.txtBerat.Location = new System.Drawing.Point(183, 116);
            this.txtBerat.Name = "txtBerat";
            this.txtBerat.Size = new System.Drawing.Size(129, 20);
            this.txtBerat.TabIndex = 9;
            this.txtBerat.TextChanged += new System.EventHandler(this.txtBerat_TextChanged);
            this.txtBerat.Leave += new System.EventHandler(this.txtBerat_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(183, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 20);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtAngka
            // 
            this.txtAngka.Location = new System.Drawing.Point(183, 234);
            this.txtAngka.Name = "txtAngka";
            this.txtAngka.Size = new System.Drawing.Size(129, 20);
            this.txtAngka.TabIndex = 11;
            this.txtAngka.Leave += new System.EventHandler(this.txtAngka_Leave);
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(183, 268);
            this.txtAngka2.MaxLength = 16;
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(129, 20);
            this.txtAngka2.TabIndex = 12;
            this.txtAngka2.Leave += new System.EventHandler(this.txtAngka2_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Pencet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Beres";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "No& KTP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "/kg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "KONFIRMASI PENDAFTARAN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(176, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(459, 40);
            this.label10.TabIndex = 18;
            this.label10.Text = "FORUM PENDAFTARAN BPJS KESEHATAN";
            // 
            // txtBesar
            // 
            this.txtBesar.Location = new System.Drawing.Point(443, 90);
            this.txtBesar.Name = "txtBesar";
            this.txtBesar.Size = new System.Drawing.Size(153, 20);
            this.txtBesar.TabIndex = 19;
            this.txtBesar.TextChanged += new System.EventHandler(this.txtBesar_TextChanged);
            // 
            // txtKecil
            // 
            this.txtKecil.Location = new System.Drawing.Point(443, 137);
            this.txtKecil.Name = "txtKecil";
            this.txtKecil.Size = new System.Drawing.Size(153, 20);
            this.txtKecil.TabIndex = 20;
            this.txtKecil.TextChanged += new System.EventHandler(this.txtKecil_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.txtKecil);
            this.Controls.Add(this.txtBesar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBerat);
            this.Controls.Add(this.txtTinggi);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WpWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WpWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WpCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ErrorProvider WpWarning;
        private System.Windows.Forms.ErrorProvider WpWrong;
        private System.Windows.Forms.ErrorProvider WpCorrect;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.TextBox txtAngka;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBerat;
        private System.Windows.Forms.TextBox txtTinggi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKecil;
        private System.Windows.Forms.TextBox txtBesar;
    }
}

