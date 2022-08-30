﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 进入圆形面积计算界面
    /// </summary>
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            //读取输入的半径计算圆的面积
            if (radioButton1.Checked)
            { 
                double r = double.Parse(textBox1.Text);
                double Area = 0;
                if (r > 0)
                {
                    Area = AC.Yuan(r);
                    //保留小数点三位数字
                    Area = Math.Round(Area, 3);
                    String ret = Area.ToString("0.000####");
                    MessageBox.Show("半径为" + r + "厘米的圆的面积为" + ret + "平方厘米");
                }
                else MessageBox.Show("输入半径有误，请重新输入");
            }
            else if (radioButton2.Checked)
            {
                double r = double.Parse(textBox1.Text);
                double Area = 0;
                double in1 = r * 2.54;
                if(r>0){ Area = Area = AC.Yuan(in1);
                    //保留小数点后三位
                    Area = Math.Round(Area, 3);
                    String ret = Area.ToString("0.000####");
                    MessageBox.Show("半径为" + r + "英寸的圆的面积为" + ret + "平方厘米"); }
                else MessageBox.Show("输入半径有误，请重新输入");
            }
        }
        //返回主界面重新选择图形种类
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
