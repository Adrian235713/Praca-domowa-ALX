using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    internal class Actions :  Form, IntActions
    {
        public string UserInput(object button)
        {
            Button infButton = (Button)button;

            List<string> operations = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "+", "-", "/", "*", "=", ".","(",")" };
            foreach (string operation in operations)
            {
                if (operation == infButton.Text)
                {
                    return operation;
                }
            }
            return "0";
        }

        public string ResetInput(object button)
        {
            Button infButton = (Button)button;
            bool inp = infButton.Enabled;
            if (inp)
                return "";
            return "";
        }

        public string Solution(string equation)
        {
            try
            {
                DataTable dataTable = new DataTable();
                var solution = dataTable.Compute(equation, "");
                string solutionString = solution.ToString();
                return solutionString;
            }
            catch (DivideByZeroException)
            {
                return "It is not divisible by 0";
            }
        }


    }
}
