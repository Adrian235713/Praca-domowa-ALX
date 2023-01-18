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

        //----------------------------------------------------------------------------------------------

        string numbersLotto = "";
        string numbersLottoPlus = "";

        //----------------------------------------------------------------------------------------------
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

        //----------------------------------------------------------------------------------------------

        private void butCheck_Click(object sender, EventArgs e)
        {

            string[] numbersLottoTable = numbersLotto.Split('-');
            string[] userNumbersLottoTable = textInpLotto.Text.Split('-');

            int scoreLotto = 0;
            string numersLotto = "Twoje trafienia to: ";
            foreach(string number in userNumbersLottoTable)
            {
                if (numbersLottoTable.Contains(number))
                {
                    numersLotto += number + " ";
                    scoreLotto++;
                }
            }
            numersLotto += " Masz: " + scoreLotto + " trafien";
            textResultsLotto.Text = numersLotto;

            //----------------------------------------------------------------------------------------------

            string[] numbersLottoTablePlus = numbersLottoPlus.Split('-');
            string[] userNumbersLottoTablePlus = textInpLootPlus.Text.Split('-');

            int scoreLottoPlus = 0;
            string numersLottoPlus = "Twoje trafienia to: ";
            foreach (string number in userNumbersLottoTablePlus)
            {
                if (numbersLottoTablePlus.Contains(number))
                {
                    numersLottoPlus += number + " ";
                    scoreLottoPlus++;
                }
            }
            numersLottoPlus += " Masz: " + scoreLottoPlus + " trafien";
            textResultsLootoPlus.Text = numersLottoPlus;
        }

        //----------------------------------------------------------------------------------------------

        private void butReset_Click(object sender, EventArgs e)
        {
            textDrawResults.Text = "";
            textLotPlas.Text = "";
            textInpLotto.Text = "";
            textInpLootPlus.Text = "";
            textResultsLotto.Text = "";
            textResultsLootoPlus.Text = "";
        }

        //----------------------------------------------------------------------------------------------
    }
}
