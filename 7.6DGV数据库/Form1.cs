using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._6DGV数据库
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();

        private void insertTable_Click(object sender, EventArgs e)
        {
            //添加表头信息，标题列中添加信息
            dt.Columns.Add("学号", typeof(int));
            dt.Columns.Add("姓名", typeof(string));
            dt.Columns.Add("班级", typeof(string));
            dt.Columns.Add("电话", typeof(string));

         
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DGV.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(1, "助教", "语言班", "38932487");
            dt.Rows.Add(2, "老师", "语言班", "38932487");
            dt.Rows.Add(3, "小张", "语言班", "6757567676");
            dt.Rows.Add(4, "赵云", "语言班", "567567567");
            dt.Rows.Add(5, "李小龙", "视觉班", "4654546456");
            dt.Rows.Add(6, "张飞", "语言班", "678678");
        }
        //删除数据
        private void button2_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 1)
            {
                int index = dt.Rows.Count - 1;//删除最后一行       
                dt.Rows.Remove(dt.Rows[index]);

            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dt.Rows.Count - 1;//修改最后一行          
            dt.Rows[index][1]="嘉嘉";
            dt.Rows[index][2] = "舞蹈班";
            dt.Rows[index][3] = "394230949";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = this.DGV.CurrentCell.RowIndex;//获取当前选择的行的索引
            dt.Rows.Remove(dt.Rows[index]);
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = this.DGV.CurrentCell.RowIndex;//获取当前选择的行的索引
            this.textBox1.Text = dt.Rows[index].ItemArray[0].ToString();
            this.textBox2.Text = dt.Rows[index].ItemArray[1].ToString();
            this.textBox3.Text = dt.Rows[index].ItemArray[2].ToString();
            this.textBox4.Text = dt.Rows[index].ItemArray[3].ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = dt.Rows.Count - 1;//修改最后一行    
            dt.Rows[index][0] = this.textBox1.Text;
            dt.Rows[index][1] = this.textBox2.Text;
            dt.Rows[index][2] = this.textBox3.Text;
            dt.Rows[index][3] = this.textBox4.Text;
        }
    }
}
