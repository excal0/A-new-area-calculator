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
            if (radioButton1.Checked)
            {
                double r = double.Parse(textBox1.Text);
                double Area = 0;
                double pi = 3.1415926;
                Area = r * r*pi;
                //保留小数点三位数字
                Area = Math.Round(Area, 3);
                String ret = Area.ToString("0.000####");



                MessageBox.Show("半径为" + r + "厘米的圆的面积为" + ret + "平方厘米");
            }
            else if (radioButton2.Checked)
            {
                double r = double.Parse(textBox1.Text);
                double Area = 0;
                double in1 = r * 2.54;
                double pi = 3.1415926;
                Area = in1 * in1*pi;
                //保留小数点后三位
                Area = Math.Round(Area, 3);
                String ret = Area.ToString("0.000####");
                MessageBox.Show("半径为" + r + "英寸的圆的面积为" + ret + "平方厘米");
            }
        }
    }
}
