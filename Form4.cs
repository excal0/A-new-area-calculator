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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p, area;
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            if (radioButton1.Checked)
            {
                if ((a + b > c) && (a - b < c))
                {
                    p = (a + b + c) / 2;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    String ret = area.ToString("0.000####");
                    MessageBox.Show("三角形的面积为" + ret + "平方厘米");
                }
                else
                {
                    MessageBox.Show("所输入的三个边长无法构成三角形");
                }
            }
            else if (radioButton2.Checked)
            {
                a = a * 2.54;
                b = b * 2.54;
                c = c * 2.54;
                if ((a + b > c) && (a - b < c))
                {
                    p = (a + b + c) / 2;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    String ret = area.ToString("0.000####");
                    MessageBox.Show("三角形的面积为" + ret + "平方厘米");
                }
                else
                {
                    MessageBox.Show("所输入的三个边长无法构成三角形");
                }

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
