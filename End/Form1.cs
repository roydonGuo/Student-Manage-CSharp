using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace End
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            this.account.Text = "";
            this.password.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string psw=null;
            string name = null;
            if (rbStudent.Checked)
            {
                string sql = string.Format(@"select * from student where account='{0}'", account.Text);
                MySqlDataReader res = DBhelp.executeQuery(sql);
                while (res.Read())
                {
                    psw = res["password"].ToString();
                    name = res["name"].ToString();

                }
                if (psw.Equals(password.Text))
                {
                    
                    MessageBox.Show("登录成功");
                    StudentMenu stu = new StudentMenu(name);
                    stu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("账号密码错误");
                }
            }
            else
            {
                string sql = string.Format(@"select password from teacher where account='{0}'", account.Text);
                MySqlDataReader res = DBhelp.executeQuery(sql);
                while (res.Read())
                {
                    psw = res["password"].ToString();

                }
                if (psw.Equals(password.Text))
                {
                    MessageBox.Show("登录成功");
                    TeacherMenu tea = new TeacherMenu();
                    tea.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("账号密码错误");
                }

            }


        }
    }
}
