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
    public partial class StuList : Form
    {
        public StuList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void StuList_Load(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();

            string sql = string.Format(@"select * from student a left join class c on a.class_id=c.id");
            MySqlDataReader res = DBhelp.executeQuery(sql);
            while (res.Read())
            {
                string id = res["id"].ToString();
                string account = res["account"].ToString();
                string name = res["name"].ToString();
                string age = res["age"].ToString();
                string sclass = res["class"].ToString();

                ListViewItem lv = new ListViewItem();

                lv.Tag = id;
                //主项
                lv.Text = account;
                //子项
                lv.SubItems.Add(name);
                lv.SubItems.Add(age);
                lv.SubItems.Add(sclass);
                this.listView1.Items.Add(lv);

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string sid = null;
        string cid = null;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  判断有没有选中数据
            if (this.listView1.SelectedItems.Count > 0)
            {
                //  拿到 选中数据  0： 因为每次选中一行 所有索引值为0
                ListViewItem lis = this.listView1.SelectedItems[0];
                sid = lis.Tag.ToString();
                string account = lis.Text;

                //  子 
                string name = lis.SubItems[1].Text;
                string age = lis.SubItems[2].Text;
                string sclass = lis.SubItems[3].Text;
                // 把拿到得数据 赋值到框里面
                textBox1.Text = account;
                textBox2.Text = name;
                textBox3.Text = age;
                label6.Text = sid;
                

            }


            string sql = string.Format(@"select  *  from class");
            MySqlDataReader res = DBhelp.executeQuery(sql);
            while (res.Read())
            {

                string sclass = res["class"].ToString();
                this.comboBox1.Items.Add(sclass);

            }
            comboBox1.Items.Insert(0, "请选择");
            this.comboBox1.SelectedIndex = 0;


            string sql1 = string.Format(@"select  *  from class where class='{0}'", comboBox1.Text);
            MySqlDataReader res1 = DBhelp.executeQuery(sql);
            while (res1.Read())
            {

                cid = res["id"].ToString();

                label7.Text = cid;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"UPDATE student set account='{0}',name='{1}',age={2} ,class_id={3} WHERE id={4}", textBox1.Text, textBox2.Text, textBox3.Text,cid, label6.Text);
            int i = DBhelp.ExecuteNonQuery(sql);
            if (i > 0)
            {
                MessageBox.Show("修改成功");
                StuList_Load(sender, e);

            }
            else
            {

                MessageBox.Show("失败");
            }
        }
    }
}
