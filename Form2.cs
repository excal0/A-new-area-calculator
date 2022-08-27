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
            if(radioButton1.Checked)
                {
                 double side = double.Parse(textBox1.Text);
                double Area = 0;
;                Area = side * side;
                //保留小数点三位数字
                Area = Math.Round(Area,3);
                String ret =Area.ToString("0.000####");
                


                MessageBox.Show("边长为" + side + "厘米的正方形的面积为" + ret + "平方厘米");
            }
            else if (radioButton2.Checked)
            {
                double side = double.Parse(textBox1.Text);
                double Area = 0;
                double in1 = side * 2.54;
                Area = in1 * in1;
                //保留小数点后三位
                Area = Math.Round(Area, 3);
                String ret = Area.ToString("0.000####");
                MessageBox.Show("边长为" + side + "英寸的正方形的面积为" + ret + "平方厘米");
            }
        }
    }
}
