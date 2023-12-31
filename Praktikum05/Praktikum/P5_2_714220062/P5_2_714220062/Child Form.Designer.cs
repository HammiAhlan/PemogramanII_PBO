﻿namespace P5_2_714220062
{
    partial class Child_Form
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
            this.OutputLabel = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.TimeOption = new System.Windows.Forms.RadioButton();
            this.DateOption = new System.Windows.Forms.RadioButton();
            this.TImeOption2 = new System.Windows.Forms.RadioButton();
            this.OutputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutputLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(0, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(800, 32);
            this.OutputLabel.TabIndex = 0;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OutputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(32, 69);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 1;
            this.DisplayButton.Text = "&Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.AutoSize = true;
            this.ExitButton.Location = new System.Drawing.Point(190, 69);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputGroupBox.AutoSize = true;
            this.OutputGroupBox.Controls.Add(this.TImeOption2);
            this.OutputGroupBox.Controls.Add(this.TimeOption);
            this.OutputGroupBox.Controls.Add(this.DateOption);
            this.OutputGroupBox.Location = new System.Drawing.Point(8, 152);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(228, 728);
            this.OutputGroupBox.TabIndex = 3;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "ChooseOutput";
            this.OutputGroupBox.Enter += new System.EventHandler(this.OutputGroupBox_Enter);
            // 
            // TimeOption
            // 
            this.TimeOption.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TimeOption.Location = new System.Drawing.Point(54, 639);
            this.TimeOption.Name = "TimeOption";
            this.TimeOption.Size = new System.Drawing.Size(168, 24);
            this.TimeOption.TabIndex = 1;
            this.TimeOption.TabStop = true;
            this.TimeOption.Text = "Display Current Time";
            this.TimeOption.UseVisualStyleBackColor = true;
            this.TimeOption.CheckedChanged += new System.EventHandler(this.TimeOption_CheckedChanged);
            // 
            // DateOption
            // 
            this.DateOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateOption.Location = new System.Drawing.Point(54, 19);
            this.DateOption.Name = "DateOption";
            this.DateOption.Size = new System.Drawing.Size(168, 24);
            this.DateOption.TabIndex = 0;
            this.DateOption.TabStop = true;
            this.DateOption.Text = "Display Current Date";
            this.DateOption.UseVisualStyleBackColor = true;
            this.DateOption.CheckedChanged += new System.EventHandler(this.DateOption_CheckedChanged);
            // 
            // TImeOption2
            // 
            this.TImeOption2.AutoSize = true;
            this.TImeOption2.Location = new System.Drawing.Point(54, 49);
            this.TImeOption2.Name = "TImeOption2";
            this.TImeOption2.Size = new System.Drawing.Size(122, 17);
            this.TImeOption2.TabIndex = 2;
            this.TImeOption2.TabStop = true;
            this.TImeOption2.Text = "Display Current Time";
            this.TImeOption2.UseVisualStyleBackColor = true;
            this.TImeOption2.CheckedChanged += new System.EventHandler(this.TImeOption2_CheckedChanged);
            // 
            // Child_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.OutputLabel);
            this.Name = "Child_Form";
            this.Text = "Child Form";
            this.OutputGroupBox.ResumeLayout(false);
            this.OutputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.RadioButton TimeOption;
        private System.Windows.Forms.RadioButton DateOption;
        private System.Windows.Forms.RadioButton TImeOption2;
    }
}