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
    /// 进入长方形面积计算界面
    /// </summary>
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
                if (a > 0 && b > 0)
                {
                    Area = AC.Changfangxing(a,b);
                    //保留小数点三位数字
                    Area = Math.Round(Area, 3);
                    String ret = Area.ToString("0.000####");



                    MessageBox.Show("长方形的面积为" + ret + "平方厘米");
                }
                else MessageBox.Show("输入边长有误，不构成长方形");
            }
                else if (radioButton2.Checked)
                {
                    double a = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox2.Text);
                    double Area = 0;
                if (a > 0 && b > 0)
                {
                    Area = Area = AC.Changfangxing(a, b) * 2.54 * 2.54;
                    //保留小数点三位数字
                    Area = Math.Round(Area, 3);
                    String ret = Area.ToString("0.000####");



                    MessageBox.Show("长方形的面积为" + ret + "平方厘米");
                }
            }
            else MessageBox.Show("输入边长有误，不构成长方形");

        }

        //返回主界面重新选择图形种类
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
