namespace 数据库
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV = new System.Windows.Forms.DataGridView();
            this.insertTable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblpagecount = new System.Windows.Forms.Label();
            this.LblTotalPage = new System.Windows.Forms.Label();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lklblFirst = new System.Windows.Forms.Label();
            this.lklblEnd = new System.Windows.Forms.Label();
            this.lklblPreview = new System.Windows.Forms.Label();
            this.lklblNext = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV.Location = new System.Drawing.Point(0, 0);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowTemplate.Height = 23;
            this.DGV.Size = new System.Drawing.Size(644, 248);
            this.DGV.TabIndex = 1;
            // 
            // insertTable
            // 
            this.insertTable.Location = new System.Drawing.Point(6, 30);
            this.insertTable.Name = "insertTable";
            this.insertTable.Size = new System.Drawing.Size(120, 44);
            this.insertTable.TabIndex = 2;
            this.insertTable.Text = "查 询";
            this.insertTable.UseVisualStyleBackColor = true;
            this.insertTable.Click += new System.EventHandler(this.insertTable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询年龄";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "查询某个字段";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(435, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 44);
            this.button5.TabIndex = 2;
            this.button5.Text = "年龄平均值/求和";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "sum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "avg";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "分页查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblpagecount
            // 
            this.lblpagecount.AutoSize = true;
            this.lblpagecount.Location = new System.Drawing.Point(7, 89);
            this.lblpagecount.Name = "lblpagecount";
            this.lblpagecount.Size = new System.Drawing.Size(65, 12);
            this.lblpagecount.TabIndex = 6;
            this.lblpagecount.Text = "共      页";
            // 
            // LblTotalPage
            // 
            this.LblTotalPage.AutoSize = true;
            this.LblTotalPage.Location = new System.Drawing.Point(31, 89);
            this.LblTotalPage.Name = "LblTotalPage";
            this.LblTotalPage.Size = new System.Drawing.Size(11, 12);
            this.LblTotalPage.TabIndex = 8;
            this.LblTotalPage.Text = "5";
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Location = new System.Drawing.Point(161, 89);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(11, 12);
            this.lblCurrentPage.TabIndex = 10;
            this.lblCurrentPage.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "当前第      页";
            // 
            // lklblFirst
            // 
            this.lklblFirst.AutoSize = true;
            this.lklblFirst.Location = new System.Drawing.Point(226, 89);
            this.lklblFirst.Name = "lklblFirst";
            this.lklblFirst.Size = new System.Drawing.Size(41, 12);
            this.lklblFirst.TabIndex = 11;
            this.lklblFirst.Text = "第一页";
            this.lklblFirst.Click += new System.EventHandler(this.lklblFirst_Click);
            // 
            // lklblEnd
            // 
            this.lklblEnd.AutoSize = true;
            this.lklblEnd.Location = new System.Drawing.Point(287, 89);
            this.lklblEnd.Name = "lklblEnd";
            this.lklblEnd.Size = new System.Drawing.Size(53, 12);
            this.lklblEnd.TabIndex = 11;
            this.lklblEnd.Text = "最后一页";
            this.lklblEnd.Click += new System.EventHandler(this.lklblEnd_Click);
            // 
            // lklblPreview
            // 
            this.lklblPreview.AutoSize = true;
            this.lklblPreview.Location = new System.Drawing.Point(356, 89);
            this.lklblPreview.Name = "lklblPreview";
            this.lklblPreview.Size = new System.Drawing.Size(41, 12);
            this.lklblPreview.TabIndex = 11;
            this.lklblPreview.Text = "上一页";
            this.lklblPreview.Click += new System.EventHandler(this.lklblPreview_Click);
            // 
            // lklblNext
            // 
            this.lklblNext.AutoSize = true;
            this.lklblNext.Location = new System.Drawing.Point(430, 89);
            this.lklblNext.Name = "lklblNext";
            this.lklblNext.Size = new System.Drawing.Size(41, 12);
            this.lklblNext.TabIndex = 11;
            this.lklblNext.Text = "下一页";
            this.lklblNext.Click += new System.EventHandler(this.lklblNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.lklblNext);
            this.groupBox1.Controls.Add(this.LblTotalPage);
            this.groupBox1.Controls.Add(this.lblpagecount);
            this.groupBox1.Controls.Add(this.lblCurrentPage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lklblPreview);
            this.groupBox1.Controls.Add(this.lklblEnd);
            this.groupBox1.Controls.Add(this.lklblFirst);
            this.groupBox1.Location = new System.Drawing.Point(12, 510);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 114);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分页查询";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.insertTable);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(3, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "全部/模糊查询";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(9, 366);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 138);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "增删改";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(232, 51);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "23425436";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(52, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "33";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "男";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "张三";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "电话：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "年龄：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "姓别：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "姓名：";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(222, 90);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 35);
            this.button7.TabIndex = 0;
            this.button7.Text = "删除";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(107, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 35);
            this.button6.TabIndex = 0;
            this.button6.Text = "修改";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 35);
            this.button4.TabIndex = 0;
            this.button4.Text = "增加";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 636);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button insertTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblpagecount;
        private System.Windows.Forms.Label LblTotalPage;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lklblFirst;
        private System.Windows.Forms.Label lklblEnd;
        private System.Windows.Forms.Label lklblPreview;
        private System.Windows.Forms.Label lklblNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}

