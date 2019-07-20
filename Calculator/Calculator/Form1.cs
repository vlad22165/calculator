using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.OneArgumentCalculators;
using Calculator.TwoArgumentsCalculators;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_click(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(textBox1.Text);
                double secondArgument = Convert.ToDouble(textBox2.Text);

                ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button) sender).Name);
                var result = calculator.Calculate(firstArgument, secondArgument);
                textBox3.Text = result.ToString();
            }
            catch (Exception exc)
            {
                textBox3.Text = exc.Message;
            }
        }

        private void OneArgumentCalculate_click(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(textBox1.Text);

                IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button) sender).Name);
                var result = calculator.Calculate(firstArgument);
                textBox3.Text = result.ToString();
            }
            catch (Exception exc)
            {
                textBox3.Text = exc.Message;
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
