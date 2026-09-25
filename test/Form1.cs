using System;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        string FakeUsername = "admin";
        string FakePassword = "admin";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = Password.Text;

            if (username == FakeUsername && password == FakePassword)
            {
                label3.Text = "Hej " + username;

                textBox1.Hide();
                label1.Hide();

                Password.Hide();
                label2.Hide();

                LogaIn.Hide();
            }
            else
            {
                label3.Text = "Fel användarnamn eller lösenord";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
