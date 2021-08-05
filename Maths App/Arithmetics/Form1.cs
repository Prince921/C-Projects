using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetics
{
    public partial class arithmeticOperations : Form
    {
        public arithmeticOperations()
        {
            InitializeComponent();
            resultTextBox.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float result;
            firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            result = firstNumber + secondNumber;
            resultTextBox.Text = (result.ToString());

        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float result;
            firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            result = firstNumber - secondNumber;
            resultTextBox.Text = (result.ToString());

        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float result;
            firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            result = firstNumber / secondNumber;
            resultTextBox.Text = (result.ToString());

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float result;
            firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            result = firstNumber * secondNumber;
            resultTextBox.Text = (result.ToString());

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumberTextBox.Text = "";
            secondNumberTextBox.Text = "";
            resultTextBox.Text = "";
        }
    }
}
