using System;
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
    /// 进入正方形面积计算界面
    /// </summary>
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            //读取输入的边长计算正方形的面积（单位cm）
            if(radioButton1.Checked)
                {
                 double side = double.Parse(textBox1.Text);
                double Area = 0;
;
                if (side > 0)
                {
                    Area = AC.Zhengfangxing(side);
                    //保留小数点三位数字
                    Area = Math.Round(Area, 3);
                    String ret = Area.ToString("0.000####");



                    MessageBox.Show("边长为" + side + "厘米的正方形的面积为" + ret + "平方厘米");
                }
                else MessageBox.Show("输入边长有误，不构成正方形");
            }
            ////读取输入的边长计算正方形的面积（单位英寸）
            else if (radioButton2.Checked)
            {
                double side = double.Parse(textBox1.Text);
                double Area = 0;
                double in1 = side * 2.54;
                if (side > 0)
                {
                    Area = AC.Zhengfangxing(in1);
                    //保留小数点后三位
                    Area = Math.Round(Area, 3);
                    String ret = Area.ToString("0.000####");
                    MessageBox.Show("边长为" + side + "英寸的正方形的面积为" + ret + "平方厘米");
                }
                else MessageBox.Show("输入边长有误，不构成正方形");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //返回主界面重新选择图形种类
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
