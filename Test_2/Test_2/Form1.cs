using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text, s2 = textBox2.Text;
            try
            {
                double num1, num2, result;
                num1 = Double.Parse(s1);
                num2 = Double.Parse(s2);
                switch (op.Text)
                {
                    case "+": result = num1 + num2;  output.Text = (result).ToString();  break;
                    case "-": result = num1 - num2;  output.Text = (result).ToString();  break;
                    case "*": result = num1 * num2;  output.Text = (result).ToString();  break;
                    case "/": result = num1 / num2;  output.Text = (result).ToString();  break;
                }
            }
            catch (OverflowException)
            {
                output.Text = "数据溢出!";
            }   
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
