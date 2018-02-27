using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if ((resultScreen.Text == "0")||(operation_pressed))
            {
                resultScreen.Clear();
                operation_pressed = false;
            }
            Button a = (Button)sender;
            resultScreen.Text = resultScreen.Text + a.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultScreen.Clear();
        }
        
        private void operator_click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            operation = a.Text;
            value = double.Parse(resultScreen.Text);
            operation_pressed = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    resultScreen.Text=(value+double.Parse(resultScreen.Text)).ToString();
                    break;
                case "-":
                    resultScreen.Text = (value - double.Parse(resultScreen.Text)).ToString();
                    break;
                case "*":
                    resultScreen.Text = (value * double.Parse(resultScreen.Text)).ToString();
                    break;
                case "/":
                    resultScreen.Text = (value / double.Parse(resultScreen.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
