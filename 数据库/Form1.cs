using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数据库
{
    public partial class Form1 : Form
    {
        static int TotalRows;
        //private int CurrentRows = 0;
        private int Pages = 0;
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void insertTable_Click(object sender, EventArgs e)
        {
            dt = server.GetDataTable("select*from 学生信息");
            this.DGV.DataSource = dt;           

        }
        //--查询一定范围的SQL语句
        //use student1
        //select* from 学生信息 where 年龄 between 22 and 33 
        //--模糊查询数据里含有某个字段的
        //select* from 学生信息 where 姓名 like '%'+'张'+'%'
        private void button1_Click(object sender, EventArgs e)
        {

            this.DGV.DataSource = server.GetDataTable("select* from 学生信息 where 年龄 between 22 and 33");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DGV.DataSource = server.GetDataTable("select* from 学生信息 where 姓名 like '%" + "张" + "%'");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (this.DGV.Rows.Count > 0)
            {
                DataTable dt1 = (DataTable)this.DGV.DataSource;
                int sum = 0;
                double avg = 0;
                for (int i = 0; i < this.DGV.Rows.Count - 1; i++)
                {
                    sum = Convert.ToInt32(dt1.Rows[i][2]);
                }
                avg = sum / this.DGV.Rows.Count;
                label2.Text = avg.ToString();
                label1.Text = sum.ToString();


            }
        }


        
       



        //**********************************************分页查询*******************************************************************************
        private static string constring = @"server =LAPTOP-PRPGFGCD\MSSQLSERVER2;database=student1;uid=sa;pwd=123456;";
        private void ShowData(int i, int j)
        {
            string sql = @"select * from 学生信息";
            //连接数据库
            SqlConnection con = new SqlConnection(constring);
            //执行SQL语句
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, con);
            //创建数据集 用于接收返回数据
            DataSet myds = new DataSet();
            //向数据中心填充数据
            sqlda.Fill(myds,i, j, "学生信息");
            this.DGV.DataSource = myds.Tables["学生信息"].DefaultView;           
            myds.Dispose();
            con.Close();
        }
        //首页
        private void lklblFirst_Click(object sender, EventArgs e)
        {
            ShowData(0, 5);
            lblCurrentPage.Text = "1";
        }

        //末尾页
        private void lklblEnd_Click(object sender, EventArgs e)
        {
            ShowData((Pages - 1) *5, 5);
            lblCurrentPage.Text = Pages.ToString();
        }
    
        //上一页
        private void lklblPreview_Click(object sender, EventArgs e)
        {
            if (lblCurrentPage.Text == "1")
            {
                MessageBox.Show("当前已经为首页!");
            }
            else
            {
                lblCurrentPage.Text = (Convert.ToInt16(lblCurrentPage.Text) - 1).ToString();
                ShowData(((Convert.ToInt16(lblCurrentPage.Text)) -1) * 5, 5);
               // lblCurrentPage.Text = (Convert.ToInt16(lblCurrentPage.Text) - 1).ToString();
            }
        }

        //下一页
        private void lklblNext_Click(object sender, EventArgs e)
        {
            if (lblCurrentPage.Text == Pages.ToString())
            {
                MessageBox.Show("当前页面已经为最后一页了!");
            }
            else
            {
                ShowData((Convert.ToInt16(lblCurrentPage.Text)) * 5, 5);
                lblCurrentPage.Text = (Convert.ToInt16(lblCurrentPage.Text) + 1).ToString();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(constring))
            {
                string sql = @"select * from 学生信息";           
                //执行SQL语句
                SqlDataAdapter sqlda = new SqlDataAdapter(sql, connection);
                //创建数据集 用于接收返回数据
                DataSet myds = new DataSet();
                //向数据中心填充数据
                sqlda.Fill(myds);
                dt= myds.Tables[0];
                TotalRows = dt.Rows.Count;
                Pages = TotalRows % 8;
                if (Pages == 0)
                {
                    Pages = TotalRows / 5;
                }
                else
                {
                    Pages = TotalRows / 5 + 1;
                }
                LblTotalPage.Text = Pages.ToString();
                lblCurrentPage.Text = "1";                                       
                ShowData(0, 5);
            }
        }



        //**********************************************************增 删  改*************************************************************************
        public static int ServerAble(string sql)
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(sql, sqlcon))
                {
                    //打开数据库
                    sqlcon.Open();
                    //操作并返回受影响的行数
                    return cmd.ExecuteNonQuery();
                }

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "insert into  学生信息(姓名,年龄,性别,电话)values('{0}','{1}','{2}','{3}')";
            sql = string.Format(sql, this.textBox1.Text.Trim(), this.textBox3.Text.Trim(), this.textBox2.Text.Trim(), this.textBox4.Text.Trim());
            
            if (ServerAble(sql)>0)
            {
                dt = server.GetDataTable("select*from 学生信息");
                this.DGV.DataSource = dt;
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }       
        private void button6_Click(object sender, EventArgs e)
        {
            int index = this.DGV.CurrentCell.RowIndex;//获取当前选择的行的索引
            if (index>0)
            {
                //int i = Convert.ToInt32(dt.Rows[index].ItemArray[0]);
                int i = Convert.ToInt32(this.DGV.CurrentRow.Cells[0].Value);
                string sql = "update 学生信息 set 姓名='{0}',年龄='{1}',性别='{2}',电话='{3}'where 学号='{4}'";
                sql = string.Format(sql, this.textBox1.Text.Trim(), this.textBox3.Text.Trim(), this.textBox2.Text.Trim(), this.textBox4.Text.Trim(), i);

                if (ServerAble(sql) > 0)
                {
                    dt = server.GetDataTable("select*from 学生信息");
                    this.DGV.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("操作失败");
                }
            }
            else
            {
                MessageBox.Show("请在表格中选择要修改的信息");
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int index = this.DGV.CurrentCell.RowIndex;//获取当前选择的行的索引
            if (index > 0)
            {               
                int i = Convert.ToInt32(this.DGV.CurrentRow.Cells[0].Value);
                string sql = " delete from 学生信息 where 学号='{0}'";
                sql = string.Format(sql, i);
                if (ServerAble(sql) > 0)
                {
                    dt = server.GetDataTable("select*from 学生信息");
                    this.DGV.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("操作失败");
                }
            }
            else
            {
                MessageBox.Show("请在表格中选择要删除的信息");
            }
        }     
    }
}
