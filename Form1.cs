using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal weight;
            decimal height;

            if (
                decimal.TryParse(textBox1.Text, out weight) &&
                decimal.TryParse(textBox2.Text, out height) &&
                weight > 0 &&
                height > 0
                )
            {
                decimal BMI = weight / height / height * 10000;
                BMI = Math.Round(BMI, 2);

                if (BMI > 25)
                {
                    label3.Text = $"BMI: {BMI}\nStatus: overweight";
                }
                else if (BMI < 18.5m)
                {
                    label3.Text = $"BMI: {BMI}\nStatus: underweight";
                }
                else
                {
                    label3.Text = $"BMI: {BMI}\nStatus: normal weight";
                }
            }
            else
            {
                label3.Text = "Incorrect input.\nPlease enter positive integer values.";
                textBox1.Text = "";
                textBox2.Text = "";
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
        }
    }
}
