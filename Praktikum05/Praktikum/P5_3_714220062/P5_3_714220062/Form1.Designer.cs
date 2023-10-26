namespace P5_3_714220062
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTMerkHp = new System.Windows.Forms.TextBox();
            this.RB_Android = new System.Windows.Forms.RadioButton();
            this.RB_IOS = new System.Windows.Forms.RadioButton();
            this.CBYA = new System.Windows.Forms.CheckBox();
            this.BTNTampilan = new System.Windows.Forms.Button();
            this.BTNKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MerkHp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "OS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sudah Diperbaiki?";
            // 
            // TXTMerkHp
            // 
            this.TXTMerkHp.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTMerkHp.Location = new System.Drawing.Point(239, 54);
            this.TXTMerkHp.Name = "TXTMerkHp";
            this.TXTMerkHp.Size = new System.Drawing.Size(100, 23);
            this.TXTMerkHp.TabIndex = 3;
            // 
            // RB_Android
            // 
            this.RB_Android.AutoSize = true;
            this.RB_Android.Location = new System.Drawing.Point(208, 110);
            this.RB_Android.Name = "RB_Android";
            this.RB_Android.Size = new System.Drawing.Size(61, 17);
            this.RB_Android.TabIndex = 4;
            this.RB_Android.TabStop = true;
            this.RB_Android.Text = "Android";
            this.RB_Android.UseVisualStyleBackColor = true;
            // 
            // RB_IOS
            // 
            this.RB_IOS.AutoSize = true;
            this.RB_IOS.Location = new System.Drawing.Point(312, 109);
            this.RB_IOS.Name = "RB_IOS";
            this.RB_IOS.Size = new System.Drawing.Size(43, 17);
            this.RB_IOS.TabIndex = 5;
            this.RB_IOS.TabStop = true;
            this.RB_IOS.Text = "IOS";
            this.RB_IOS.UseVisualStyleBackColor = true;
            // 
            // CBYA
            // 
            this.CBYA.AutoSize = true;
            this.CBYA.Location = new System.Drawing.Point(208, 166);
            this.CBYA.Name = "CBYA";
            this.CBYA.Size = new System.Drawing.Size(39, 17);
            this.CBYA.TabIndex = 6;
            this.CBYA.Text = "Ya";
            this.CBYA.UseVisualStyleBackColor = true;
            // 
            // BTNTampilan
            // 
            this.BTNTampilan.Location = new System.Drawing.Point(58, 217);
            this.BTNTampilan.Name = "BTNTampilan";
            this.BTNTampilan.Size = new System.Drawing.Size(75, 23);
            this.BTNTampilan.TabIndex = 7;
            this.BTNTampilan.Text = "Tampilan";
            this.BTNTampilan.UseVisualStyleBackColor = true;
            this.BTNTampilan.Click += new System.EventHandler(this.BTNTampilan_Click);
            // 
            // BTNKeluar
            // 
            this.BTNKeluar.Location = new System.Drawing.Point(291, 217);
            this.BTNKeluar.Name = "BTNKeluar";
            this.BTNKeluar.Size = new System.Drawing.Size(75, 23);
            this.BTNKeluar.TabIndex = 8;
            this.BTNKeluar.Text = "Keluar";
            this.BTNKeluar.UseVisualStyleBackColor = true;
            this.BTNKeluar.Click += new System.EventHandler(this.BTNKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 276);
            this.Controls.Add(this.BTNKeluar);
            this.Controls.Add(this.BTNTampilan);
            this.Controls.Add(this.CBYA);
            this.Controls.Add(this.RB_IOS);
            this.Controls.Add(this.RB_Android);
            this.Controls.Add(this.TXTMerkHp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ServiceHp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTMerkHp;
        private System.Windows.Forms.RadioButton RB_Android;
        private System.Windows.Forms.RadioButton RB_IOS;
        private System.Windows.Forms.CheckBox CBYA;
        private System.Windows.Forms.Button BTNTampilan;
        private System.Windows.Forms.Button BTNKeluar;
    }
}

