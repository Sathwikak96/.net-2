using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp369
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                label4.Visible = true;
                if (textBox1.Text == "")
                {
                    label4.Text = "Enter the amount";
                }
                else
                {
                    Double convertedamt = Convert.ToDouble(textBox1.Text);
                    if (comboBox1.SelectedItem == "INR" && comboBox2.SelectedItem == "USD")
                    {
                        Double a = convertedamt / 74;
                        label4.Text = a + "$";
                    }
                    else if (comboBox1.SelectedItem == "INR" && comboBox2.SelectedItem == "SAR")
                    {
                        Double a = convertedamt / 17;
                        label4.Text = a + "SAR";
                    }
                    else if (comboBox1.SelectedItem == "INR" && comboBox2.SelectedItem == "EUR")
                    {

                        Double a = convertedamt / 11;
                        label4.Text = a + "EUR";
                    }
                    else
                    {
                        label4.Text = "Please Enter the conversion code";
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label4.Text = "";

        }
    }
}


