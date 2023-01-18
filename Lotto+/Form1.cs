using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string numbersLotto = "";
        string numbersLottoPlus = "";

        private void butDraw_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            for (int i = 0; i < 6; i++)
            {

                numbersLotto += ran.Next(1, 49) + "-";
            }
            numbersLotto = numbersLotto.Remove(numbersLotto.Length - 1);
            textDrawResults.Text = numbersLotto;

            for (int i = 0; i < 6; i++)
            {
                numbersLottoPlus += ran.Next(1, 49) + "-";
            }
            numbersLottoPlus = numbersLottoPlus.Remove(numbersLottoPlus.Length - 1);
            textLotPlas.Text = numbersLottoPlus;
        }

        private void butCheck_Click(object sender, EventArgs e)
        {
     
        }
    }
}
