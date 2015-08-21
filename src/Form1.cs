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
using System.Reflection;
namespace GUI_Calc
{
    public partial class Calc_dll : Form
    {
        public Calc_dll()
        {
            InitializeComponent();
        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.ShowDialog();

            /*    button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true; 
                button5.Visible = true;  
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true; */
                button9.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox5.Visible = true;
                button10.Visible = true;
                checkBox6.Visible = true;
                checkBox7.Visible = true;
                checkBox8.Visible = true;
                checkBox4.Visible = true;
                               
                
                string dllName = ofd.SafeFileName;
                var assem = Assembly.LoadFrom(dllName);

                var classes_types = assem.GetTypes();
                
                foreach(var class_in in classes_types)
                {
                   textBox1.AppendText("Type: "+class_in.Name+"\n");

                    var methods = class_in.GetMethods();
                    foreach (var methods_in in methods)
                    {
                        textBox1.AppendText("\t\t"+methods_in.Name+":"+methods_in.GetBaseDefinition()+"\n");

                    }
                                        
                 }               
               
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Calc_dll_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CalcForm clf = new CalcForm();
            clf.Controls["label2"].Text = "+";
            clf.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CalcForm clf = new CalcForm();
            clf.Controls["label2"].Text = "-";
            
            clf.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CalcForm clf = new CalcForm();
            clf.Controls["label2"].Text = "*";
            clf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalcForm clf = new CalcForm();
            clf.Controls["label2"].Text = "/";
            clf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ComplexCalc cmpx = new ComplexCalc();
            cmpx.Controls["label5"].Text = "+";
            cmpx.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ComplexCalc cmpx = new ComplexCalc();
            cmpx.Controls["label5"].Text = "-";
            cmpx.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ComplexCalc cmpx = new ComplexCalc();
            cmpx.Controls["label5"].Text = "*";
            cmpx.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ComplexCalc cmpx = new ComplexCalc();
            cmpx.Controls["label5"].Text = "-";
            cmpx.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                SimpleCalcGUI smcg = new SimpleCalcGUI();
                smcg.Controls["button1"].Visible = true;
                smcg.Show();
            }
            else if (checkBox2.Checked == true)
            {
                SimpleCalcGUI smcg = new SimpleCalcGUI();
                smcg.Controls["button2"].Visible = true;
                smcg.Show();
            }
            else if (checkBox3.Checked == true)
            {
                SimpleCalcGUI smcg = new SimpleCalcGUI();
                smcg.Controls["button3"].Visible = true;
                smcg.Show();
            }
            else if (checkBox4.Checked == true)
            {
                SimpleCalcGUI smcg = new SimpleCalcGUI();
                smcg.Controls["button4"].Visible = true;
                smcg.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ComplexCalc cmpx = new ComplexCalc();
            cmpx.Show();
        }

      
       

       
    }
}
