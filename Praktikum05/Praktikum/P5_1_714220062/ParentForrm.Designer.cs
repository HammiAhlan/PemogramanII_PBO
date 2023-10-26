namespace P5_2_714220062
{
    partial class ParentForm
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
            this.MdiMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowCascadeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowTileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MdiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MdiMenu
            // 
            this.MdiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.WindowMenuItem});
            this.MdiMenu.Location = new System.Drawing.Point(0, 0);
            this.MdiMenu.Name = "MdiMenu";
            this.MdiMenu.Size = new System.Drawing.Size(933, 24);
            this.MdiMenu.TabIndex = 1;
            this.MdiMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // WindowMenuItem
            // 
            this.WindowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowCascadeMenuItem,
            this.WindowTileMenuItem});
            this.WindowMenuItem.Name = "WindowMenuItem";
            this.WindowMenuItem.Size = new System.Drawing.Size(68, 20);
            this.WindowMenuItem.Text = "&Windows";
            // 
            // WindowCascadeMenuItem
            // 
            this.WindowCascadeMenuItem.Name = "WindowCascadeMenuItem";
            this.WindowCascadeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.WindowCascadeMenuItem.Text = "&Cascade";
            this.WindowCascadeMenuItem.Click += new System.EventHandler(this.WindowCascadeMenuItem_Click);
            // 
            // WindowTileMenuItem
            // 
            this.WindowTileMenuItem.Name = "WindowTileMenuItem";
            this.WindowTileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.WindowTileMenuItem.Text = "&Tile";
            this.WindowTileMenuItem.Click += new System.EventHandler(this.WindowTileMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.MdiMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MdiMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ParentForm";
            this.Text = "Form1";
            this.MdiMenu.ResumeLayout(false);
            this.MdiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MdiMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowCascadeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowTileMenuItem;
    }
}

