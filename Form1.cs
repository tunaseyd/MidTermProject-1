namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Saloon1 cl = new Saloon1();
            cl.ShowDialog();
            cl = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Saloon2 cl = new Saloon2();
            cl.ShowDialog();
            cl = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Saloon3 cl = new Saloon3();
            cl.ShowDialog();
            cl = null;
            this.Show();
        }
    }
}