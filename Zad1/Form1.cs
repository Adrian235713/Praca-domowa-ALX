using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(textBox1.Text);
            double number2 = double.Parse(textBox2.Text);

            Zad zad = new Zad();

            if(zad.isItEven(number1, number2))
            {
                label1.Text = "Jest parzysta";
            }
            else
            {
                label1.Text = "Nie jest parzysta";
            }
        }
    }
}
