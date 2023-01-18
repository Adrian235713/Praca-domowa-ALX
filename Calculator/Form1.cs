using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private new Actions actions = new Actions();


        private void btmReset_Click(object sender, EventArgs e)
        {
            textEquation.Text = actions.ResetInput(sender);
            textSolution.Text = "";
        }

        private void butCalculate_Click(object sender, EventArgs e)
        {
            textSolution.Text = actions.Solution(textEquation.Text);
        }


        //-------------------------------------------------------------------

        private void but1_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void but8_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void but9_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void btm4_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void btm5_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void btm6_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void btm7_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void btm8_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void btm9_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void butDiv_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void butMul_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void butSub_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void butAd_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void btmDrop_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void but0_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void butBracket1_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void butBracket2_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        private void butEqual_Click(object sender, EventArgs e)
        {
            textEquation.Text += actions.UserInput(sender);
        }

        //-------------------------------------------------------------------
    }
}
