using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 定义面积计算器类
/// </summary>
public class AC
{
    
    /// <summary>
    /// 计算正方形面积
    /// </summary>
    /// <param name="side">正方形边长</param>
    /// <returns>正方形面积</returns>
    public static double Zhengfangxing(double side)
    { double area;
      area = side * side;
       return area;
      }
    /// <summary>
    /// 计算圆的面积
    /// </summary>
    /// <param name="r">圆的半径</param>
    /// <returns>圆的面积</returns>
    public static double Yuan(double r)
    {
        double area;
        double pi = 3.1415;
        area = r * r * pi;
        return area;
    }
   /// <summary>
   /// 计算三角形的面积
   /// </summary>
   /// <param name="a">第一条边</param>
   /// <param name="b">第二条边</param>
   /// <param name="c">第三条边</param>
   /// <returns>三角形面积</returns>
    public static double Sanjiaoxing(double a, double b, double c)
    {
        double area;
        double p;
        p = (a + b + c) / 2;
        area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return area;
    }
    /// <summary>
    ///计算长方形的面积 
    /// </summary>
    /// <param name="a">长</param>
    /// <param name="b">宽</param>
    /// <returns>长方形面积</returns>
    public static double Changfangxing(double a, double b)
    {
        double area;
        area = a * b;
        return area;
    }
}
namespace WindowsFormsApp1
{
    /// <summary>
    /// 选择需要计算面积的图形种类
    /// 并进入该图形的面积计算界面
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //选择需要计算面积的图形种类
        private void button1_Click(object sender, EventArgs e)
        {
            //正方形面积计算界面
            if (radioButton1.Checked)
            {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
            //圆面积计算界面
            else if (radioButton2.Checked)
            {
               Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            //三角形面积计算界面
            else if (radioButton3.Checked)
            {
               Form4 form4 =new Form4();
                form4.Show();
                this.Hide();
            }
            //长方形面积计算界面
            else if(radioButton4.Checked)
                    {
                Form5 form5 =new Form5();
                form5.Show();
                this.Hide();
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
