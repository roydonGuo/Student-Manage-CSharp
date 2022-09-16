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
    public partial class StudentMenu : Form
    {
        
        public StudentMenu(string str)
        {
            InitializeComponent();
            ppToolStripMenuItem.Text = str;
        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {

        }

        private void 查询信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelStu ss = new SelStu();
            ss.url = ppToolStripMenuItem.Text;
            ss.Show();
        }
    }
}
