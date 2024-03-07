using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text != null)
                {
                    double n = Convert.ToInt32(textBox1.Text);
                    double result = new ConvertMass().Convert(n);
                    textBox2.Text = result.ToString();
                }
            }
            else if (radioButton2.Checked)
            {
                if (textBox1.Text != null)
                {
                    double n = Convert.ToInt32(textBox1.Text);
                    double result = new ConvertLength().Convert(n);
                    textBox2.Text = result.ToString();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "pounds";
            label2.Text = "kg";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "feet";
            label2.Text = "m";
        }
    }
}
