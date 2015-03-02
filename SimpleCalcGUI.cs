using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calc;

namespace GUI_Calc
{
    public partial class SimpleCalcGUI : Form
    {
        public SimpleCalcGUI()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "+")
            {
                textBox3.Text = Simplecalc.add(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text)).ToString();
            }
            else if (btn.Text == "-")
            {
                textBox3.Text = Simplecalc.subtract(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text)).ToString();
            }
            else if (btn.Text == "*")
            {
                textBox3.Text = Simplecalc.multiply(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text)).ToString();
            }
            else if (btn.Text == "/")
            {
                textBox3.Text = Simplecalc.divide(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text)).ToString();
            }
            else if (btn.Text == "C")
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}
