using System.Diagnostics;

namespace winshutdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int time = 11;
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", $"/s /t {time}");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 0");

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
