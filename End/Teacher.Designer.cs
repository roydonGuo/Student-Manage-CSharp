namespace End
{
    partial class TeacherMenu
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
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新增数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.老师管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息查询ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.新增教师ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生管理ToolStripMenuItem,
            this.信息查询ToolStripMenuItem,
            this.老师管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息查询ToolStripMenuItem1,
            this.新增数据ToolStripMenuItem});
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            // 
            // 信息查询ToolStripMenuItem1
            // 
            this.信息查询ToolStripMenuItem1.Name = "信息查询ToolStripMenuItem1";
            this.信息查询ToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.信息查询ToolStripMenuItem1.Text = "信息查询";
            this.信息查询ToolStripMenuItem1.Click += new System.EventHandler(this.信息查询ToolStripMenuItem1_Click);
            // 
            // 新增数据ToolStripMenuItem
            // 
            this.新增数据ToolStripMenuItem.Name = "新增数据ToolStripMenuItem";
            this.新增数据ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.新增数据ToolStripMenuItem.Text = "新增数据";
            this.新增数据ToolStripMenuItem.Click += new System.EventHandler(this.新增数据ToolStripMenuItem_Click);
            // 
            // 信息查询ToolStripMenuItem
            // 
            this.信息查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询学生ToolStripMenuItem});
            this.信息查询ToolStripMenuItem.Name = "信息查询ToolStripMenuItem";
            this.信息查询ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.信息查询ToolStripMenuItem.Text = "班级管理";
            this.信息查询ToolStripMenuItem.Click += new System.EventHandler(this.信息查询ToolStripMenuItem_Click);
            // 
            // 查询学生ToolStripMenuItem
            // 
            this.查询学生ToolStripMenuItem.Name = "查询学生ToolStripMenuItem";
            this.查询学生ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.查询学生ToolStripMenuItem.Text = "查询学生";
            this.查询学生ToolStripMenuItem.Click += new System.EventHandler(this.查询学生ToolStripMenuItem_Click);
            // 
            // 老师管理ToolStripMenuItem
            // 
            this.老师管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息查询ToolStripMenuItem2,
            this.新增教师ToolStripMenuItem});
            this.老师管理ToolStripMenuItem.Name = "老师管理ToolStripMenuItem";
            this.老师管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.老师管理ToolStripMenuItem.Text = "老师管理";
            // 
            // 信息查询ToolStripMenuItem2
            // 
            this.信息查询ToolStripMenuItem2.Name = "信息查询ToolStripMenuItem2";
            this.信息查询ToolStripMenuItem2.Size = new System.Drawing.Size(152, 24);
            this.信息查询ToolStripMenuItem2.Text = "信息查询";
            this.信息查询ToolStripMenuItem2.Click += new System.EventHandler(this.信息查询ToolStripMenuItem2_Click);
            // 
            // 新增教师ToolStripMenuItem
            // 
            this.新增教师ToolStripMenuItem.Name = "新增教师ToolStripMenuItem";
            this.新增教师ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.新增教师ToolStripMenuItem.Text = "新增教师";
            this.新增教师ToolStripMenuItem.Click += new System.EventHandler(this.新增教师ToolStripMenuItem_Click);
            // 
            // TeacherMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 435);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeacherMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 新增数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 老师管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息查询ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 新增教师ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询学生ToolStripMenuItem;
    }
}