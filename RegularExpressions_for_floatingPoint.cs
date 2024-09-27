using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LabTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string pattern = @"^\d{1,6}(\.\d{1,6})?$";
            bool isValid = Regex.IsMatch(input, pattern);
            MessageBox.Show(isValid ? "Valid floating point number." : "Invalid floating point number.");
        }
    }
}
