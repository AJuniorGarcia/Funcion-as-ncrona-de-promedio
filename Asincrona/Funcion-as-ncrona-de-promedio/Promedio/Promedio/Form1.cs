using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            double partial1 = Convert.ToDouble(textBox1.Text);
            double partial2 = Convert.ToDouble(textBox2.Text);
            double partial3 = Convert.ToDouble(textBox3.Text);
            double partial4 = Convert.ToDouble(textBox4.Text);

            double average = CalculateAverage(partial1, partial2, partial3, partial4);

            lbresultado.Text = "El promedio final es: " + average.ToString();
        }
        static double CalculateAverage(double partial1, double partial2, double partial3, double partial4)
        {
            return (partial1 + partial2 + partial3 + partial4) / 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            lbresultado.Text = "";
        }
    }
}
