using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalculator
{
    public partial class Form1 : Form
    {

        private Parser parser;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TryAddDigit( sender );
        }

        private void TryAddDigit(object sender)
        {
            Button btn = (Button)sender;
            parser.AddDigit(btn.Text[0]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            parser = new Parser(this.tbDisplay);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TryAddDigit(sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TryAddDigit(sender);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TryAddDigit(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TryAddDigit(sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TryAddDigit(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TryAddDigit(sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TryAddDigit(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TryAddDigit(sender);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TryAddDigit(sender);
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            parser.Backspace();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            parser.CE();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            parser.C();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            parser.PutDot();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            btnM.Text = "";
            parser.MC();
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            parser.MR();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            btnM.Text = "M";
            parser.MS();
        }

        private void btnMPLUS_Click(object sender, EventArgs e)
        {
            btnM.Text = "M";
            parser.MPLUS();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            parser.Calculate(Parser.Operator.DIVIDE);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            parser.Calculate(Parser.Operator.PLUS);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            parser.Calculate(Parser.Operator.MINUS);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            parser.Calculate(Parser.Operator.TIMES);
        }

        private void btnAddSymbol_Click(object sender, EventArgs e)
        {
            parser.AddSymbol();
        }

        private void btnOneOverX_Click(object sender, EventArgs e)
        {
            parser.oneOverX();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            parser.Sqrt();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            parser.Calculate(Parser.Operator.EQUAL);
        }

        private void btnPersentage_Click(object sender, EventArgs e)
        {
            parser.Perc();
        }
    }
}
