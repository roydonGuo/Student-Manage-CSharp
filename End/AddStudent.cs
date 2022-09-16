using MySql.Data.MySqlClient;
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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string cid = null;
        private void AddStudent_Load(object sender, EventArgs e)
        {
            string sql = string.Format(@"select * from class");
            MySqlDataReader res = DBhelp.executeQuery(sql);
            while (res.Read())
            {
               
                string sclass = res["class"].ToString();

                this.comboBox1.Items.Add(sclass);

            }
            comboBox1.Items.Insert(0, "请选择");
            this.comboBox1.SelectedIndex = 0;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into student (account,name,age,class_id)values('{0}','{1}',{2},{3})",textBox3.Text,textBox1.Text,textBox2.Text,cid);
            int i = DBhelp.ExecuteNonQuery(sql);
            if (i > 0)
            {
                MessageBox.Show("新增成功");
                StuList s = new StuList();
                s.Show();
                this.Hide();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql2 = string.Format(@"select * from class where class='{0}'", comboBox1.Text);
            MySqlDataReader res2 = DBhelp.executeQuery(sql2);
            while (res2.Read())
            {

                cid = res2["id"].ToString();


            }
        }
    }
}
