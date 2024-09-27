using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LabTask2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string pattern = @"^\d+e[+-]?\d+$";
            bool isValid = Regex.IsMatch(input, pattern);
            MessageBox.Show(isValid ? "Valid scientific notation." : "Invalid scientific notation.");
        }
    }
}
