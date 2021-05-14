using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalculator
{
    class Parser
    {
        private TextBox tbDispaly;

        public enum DisplayMode
        {
            CLEAR, APPEND
        }

        public enum Operator
        {
            PLUS, MINUS, DIVIDE, TIMES, EQUAL
        }

        private DisplayMode displayMode = DisplayMode.CLEAR;
        private Operator op = Operator.EQUAL;
        private TextBox tbDisplay;

        private double total;//current calculated number

        private double mem;
        public Parser(TextBox textBox)
        {
            this.tbDispaly = textBox;
        }

        public void MS()
        {
            mem = GetCurrentValue();
        }

        public void MPLUS()
        {
            mem += GetCurrentValue();
        }

        public void MR()
        {
            tbDispaly.Text = "" + mem;
        }

        public void MC()
        {
            mem = 0;
        }

        public void CE()
        {
            tbDispaly.Text = "0";
            displayMode = DisplayMode.CLEAR;
        }

        public void C()
        {
            CE();
            total = 0;
            op = Operator.EQUAL;
        }

        public void PutDot()
        {
            if (!tbDispaly.Text.Contains("."))
            {
                tbDispaly.Text += ".";
            }
        }
        public void Backspace()
        {
            string disp = tbDispaly.Text;
            if (disp.Length == 1)
            {
                tbDispaly.Text = "0";
                displayMode = DisplayMode.CLEAR;
            }
            else
            {
                disp = disp.Substring(0, disp.Length - 1);
                tbDispaly.Text = disp;
            }

        }

        public double GetCurrentValue()
        {
            return double.Parse(tbDispaly.Text);
        }

        public void oneOverX()
        {
            double result = 1 / GetCurrentValue();
            tbDispaly.Text = "" + result;
            displayMode = DisplayMode.CLEAR;
        }

        public void Perc()
        {
            if (op==Operator.TIMES)
            {
                double result = GetCurrentValue() / 100;
                tbDispaly.Text = "" + result;
                displayMode = DisplayMode.CLEAR;
            }        
        }
        public void Sqrt()
        {
            double result = Math.Sqrt(GetCurrentValue());
            tbDispaly.Text = "" + result;
        }
        public void AddSymbol()
        {
            if (GetCurrentValue() == 0)
                return;

            if (!tbDispaly.Text.StartsWith("-"))
            {
                tbDispaly.Text = "-" + tbDispaly.Text;
            }
            else
            {
                tbDispaly.Text = tbDispaly.Text.Substring(1);
                
            }
        }

        public void Calculate(Operator newOperator)
        {
            Operator oldOperator = this.op;
            this.op = newOperator;
            double curValue = GetCurrentValue();
            displayMode = DisplayMode.CLEAR;

            switch (oldOperator)
            {
                default:
                    total = curValue;
                    return;

                case Operator.PLUS:
                    total += curValue;
                    break;

                case Operator.MINUS:
                    total -= curValue;
                    break;

                case Operator.DIVIDE:
                    total /= curValue;
                    break;

                case Operator.TIMES:
                    total *= curValue;
                    break;
            }
            tbDispaly.Text = "" + total;
        }

        public void AddDigit(char digit)
        {

            double curValue = GetCurrentValue();

            if (curValue == 0 && digit == '0')
                return;

            if (displayMode==DisplayMode.CLEAR)
            {
                tbDispaly.Text = "" + digit;
                displayMode = DisplayMode.APPEND;
            }
            else
            {
                tbDispaly.Text += digit;
            }
        }

    }
}
