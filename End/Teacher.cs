using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace End
{
    public partial class TeacherMenu : Form
    {
        public TeacherMenu()
        {
            InitializeComponent();
        }

        private void 信息查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StuList stu = new StuList();
            stu.Show();
        }

        private void 信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 信息查询ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TeaList tea = new TeaList();
            tea.Show();
        }

        private void 查询学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 新增数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent add = new AddStudent();
            add.Show();
        }

        private void 新增教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher add = new AddTeacher();
                add.Show();
        }
    }
}
