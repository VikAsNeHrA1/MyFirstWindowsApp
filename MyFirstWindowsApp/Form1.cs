using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyFirstWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.LanguageSelector.SelectedIndexChanged += new System.EventHandler(this.LanguageSelector_SelectedIndexChanged);

            this.Data.SelectedIndexChanged += new System.EventHandler(this.Data_SelectedIndexChanged);
        }

        private void AddLanguageButton_Click(object sender, EventArgs e)
        {
            var newLanguage = TextBox.Text.Trim();
            if (!string.IsNullOrEmpty(newLanguage) && !LanguageSelector.Items.Contains(newLanguage))
            {
                LanguageSelector.Items.Add(newLanguage);
                TextBox.Clear();

                MessageBox.Show("Language added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LanguageSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LanguageSelector.SelectedItem != null)
            {
                var selectedLanguage = LanguageSelector.SelectedItem.ToString();
                if (!Data.Items.Contains(selectedLanguage))
                {
                    Data.Items.Add(selectedLanguage);
                }
            }
        }

        private void Data_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
