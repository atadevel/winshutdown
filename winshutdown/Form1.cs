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
            Process.Start("shutdown", $"/s /t {txthour}");
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
                MessageBox.Show(hour);
            }
        }
        private void txtmin_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtmin.Text))
            {
                
            }
            else
            {
                string min = txtmin.Text;
                Convert.ToInt32(min);
                MessageBox.Show(min);
            }
            
        }

        private void txthour_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
