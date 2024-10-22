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
        private void button1_Click(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(txthour.Text) * 60 + Convert.ToInt32(txtmin.Text);
            timer1.Start();

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

        private void txthour_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txthour.Text))
            {

            }
            else
            {
                string hour = txthour.Text;
                Convert.ToInt32(hour);

            }
        }
        private void txtmin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmin.Text))
            {

            }
            else
            {
                string min = txtmin.Text;
                Convert.ToInt32(min);

            }

        }

        private void txthour_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int timeleft = Convert.ToInt32(txthour.Text) * 60 * 60 + Convert.ToInt32(txtmin.Text) * 60;
            if (timeleft > 0)
                timeleft = timeleft - 1;
            else
                //Process.Start("shutdown", $"/s /t 0");
                MessageBox.Show("nigga");
            

            label4.Text=timeleft.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
