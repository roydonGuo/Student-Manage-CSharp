namespace End
{
    partial class StudentMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查询信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.欢迎你ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询信息ToolStripMenuItem,
            this.修改密码ToolStripMenuItem,
            this.欢迎你ToolStripMenuItem,
            this.ppToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查询信息ToolStripMenuItem
            // 
            this.查询信息ToolStripMenuItem.Name = "查询信息ToolStripMenuItem";
            this.查询信息ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.查询信息ToolStripMenuItem.Text = "查询信息";
            this.查询信息ToolStripMenuItem.Click += new System.EventHandler(this.查询信息ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            // 
            // 欢迎你ToolStripMenuItem
            // 
            this.欢迎你ToolStripMenuItem.Name = "欢迎你ToolStripMenuItem";
            this.欢迎你ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.欢迎你ToolStripMenuItem.Text = "欢迎你：";
            // 
            // ppToolStripMenuItem
            // 
            this.ppToolStripMenuItem.Name = "ppToolStripMenuItem";
            this.ppToolStripMenuItem.Size = new System.Drawing.Size(41, 24);
            this.ppToolStripMenuItem.Text = "pp";
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 375);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查询信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 欢迎你ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ppToolStripMenuItem;
    }
}