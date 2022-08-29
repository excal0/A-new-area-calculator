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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (radioButton1.Checked)
                {
                    double a = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox2.Text);
                    double Area = 0;
                    ; Area = a * b;
                    //保留小数点三位数字
                    Area = Math.Round(Area, 3);
                    String ret = Area.ToString("0.000####");



                    MessageBox.Show("长方形的面积为" + ret + "平方厘米");
                }
                else if (radioButton2.Checked)
                {
                    double a = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox2.Text);
                    double Area = 0;
                    Area = a * b * 2.54 * 2.54;
                    //保留小数点三位数字
                    Area = Math.Round(Area, 3);
                    String ret = Area.ToString("0.000####");



                    MessageBox.Show("长方形的面积为" + ret + "平方厘米");
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
