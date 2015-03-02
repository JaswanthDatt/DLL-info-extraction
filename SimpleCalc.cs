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
    public partial class SimpleCalc : Form
    {
        public SimpleCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
         //   textBox1.Text = calc.Simplecalc.add(Double.Parse(textBox1.Text),0.0).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
