using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Log_In : Form
    {
        string username = "Admin";

        string password = "admin123";

        public Log_In()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text == username && PasswordBox.Text == password)
            {
                this.Hide();
                Form1 cl = new Form1();
                cl.ShowDialog();
                cl = null;
                this.Show();

            }
            else
            {
                OutputLabel.Text = "Please try again!!!";
                UsernameBox.Text = string.Empty;
                PasswordBox.Text = string.Empty;
            }
        }
    }

}
