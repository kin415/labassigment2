using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LabTask3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void FindWordsButton_Click(object sender, EventArgs e)
        {
            string inputText = inputTextBox.Text;
            string pattern = @"\b[tm]\w*\b";
            MatchCollection matches = Regex.Matches(inputText, pattern);
            
            // Clear existing rows
            dataGridView1.Rows.Clear();

            // Add matches to DataGridView
            foreach (Match match in matches)
            {
                dataGridView1.Rows.Add(match.Value);
            }
        }
    }
}
