namespace FCalc
{
    public partial class FCalc : Form
    {
        public FCalc()
        {
            InitializeComponent();
        }

        private void numberButtons_click(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            inputBox.Text += text;
        }

        private void arithmeticButtons_click(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            inputBox.Text += text;
        }

    }
}
