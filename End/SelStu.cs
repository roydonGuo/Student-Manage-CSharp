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
    public partial class SelStu : Form
    {
        public string url;
        public SelStu()
        {
            InitializeComponent();
        }

        string id =null;
        string account =null;
        string password=null;
        string name = null;
        string age = null;
        string sclass = null;
        private void SelStu_Load(object sender, EventArgs e)
        {

            string sql = string.Format(@"select * from student s left join class c on s.class_id=c.id where name='{0}'",url);
            MySqlDataReader res = DBhelp.executeQuery(sql);
            while (res.Read())
            {
                id = res["id"].ToString();
                account = res["account"].ToString();
                password = res["password"].ToString();
                name = res["name"].ToString();
                age = res["age"].ToString();
                sclass = res["class"].ToString();
            }
            textBox1.Text = name;
            textBox2.Text = account;
            textBox3.Text = password;
            textBox4.Text = age;
            textBox5.Text = sclass;
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
