using System;
using System.Drawing;
using System.Reflection.Emit;
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
            textBox2.Hide();
          
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
                label4.Show();
                Password.Hide();
                label2.Hide();
                button1.Show();
                textBox2.Show();
                button2.Show();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            text += textBox2.Text;
            label5.Show();
            label5.Text = text;
            panel1.BackColor = Color.AliceBlue;
            panel1.Size = new Size(300, 100);

            label5.Parent = panel1;
            label5.BackColor = Color.Transparent;
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "";
        }
    }
}
