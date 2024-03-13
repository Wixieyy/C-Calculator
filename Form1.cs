using System.Collections;
using System.Configuration;

namespace FCalc
{
    public partial class FCalc : Form
    {
        private bool allowed = true;
        private String text;
        private int remove;

        public FCalc()
        {
            InitializeComponent();
        }

        private void numberButtons_click(object sender, EventArgs e)
        {
            text = ((Button)sender).Text;
            inputBox.Text += text;
        }

        private void arithmeticButtons_click(object sender, EventArgs e)
        {
            text = ((Button)sender).Text;
            if (inputBox.Text != String.Empty && allowed)
            {
                inputBox.Text += text;
                allowed = false;
            }
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            remove = inputBox.Text.Length - 1;
            if (inputBox.Text != String.Empty)
            {
                inputBox.Text = inputBox.Text.Remove(remove);
                allowed = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = String.Empty;
            allowed = true;
        }

        private void calculateButton_click(object sender, EventArgs e)
        {
            for (int i = 0; i < inputBox.Text.Length; i++)
            {
                String[] numbers = inputBox.Text.Split('+', '-', '*', '/');

                if (inputBox.Text[i] == '+')
                {
                    inputBox.Text = (Int32.Parse(numbers[0]) + Int32.Parse(numbers[1])).ToString();
                }
                else if (inputBox.Text[i] == '-')
                {
                    inputBox.Text = (Int32.Parse(numbers[0]) - Int32.Parse(numbers[1])).ToString();
                }
                else if (inputBox.Text[i] == '*')
                {
                    inputBox.Text = (Int32.Parse(numbers[0]) * Int32.Parse(numbers[1])).ToString();
                }
                else if (inputBox.Text[i] == '/')
                {
                    inputBox.Text = (Int32.Parse(numbers[0]) / Int32.Parse(numbers[1])).ToString();
                }
            }
        }
    }
}
