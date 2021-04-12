using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        double reasultValue = 0;
        string operationPerformed = " ";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ( textBox_Reasult.Text == "0" || isOperationPerformed)
                textBox_Reasult.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Reasult.Text = textBox_Reasult.Text + button.Text;
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            reasultValue = Double.Parse(textBox_Reasult.Text);
            labelCurrentOperation.Text = reasultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBox_Reasult.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_Reasult.Text = "0";
            reasultValue = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (operationPerformed) 
            {
                case "+":
                    textBox_Reasult.Text = (reasultValue + double.Parse(textBox_Reasult.Text)).ToString();
                    break;
                case "-":
                    textBox_Reasult.Text = (reasultValue - double.Parse(textBox_Reasult.Text)).ToString();
                    break;

                case "*":
                    textBox_Reasult.Text = (reasultValue * double.Parse(textBox_Reasult.Text)).ToString();
                    break;

                case "/":
                    textBox_Reasult.Text = (reasultValue / double.Parse(textBox_Reasult.Text)).ToString();
                    break;

            }
        }
    }
}
