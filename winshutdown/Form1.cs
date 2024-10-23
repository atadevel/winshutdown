using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace winshutdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hour;
        int min;
        private int timeleft =  ;
        public void StartCountdown()
        {
            timeleft = Convert.ToInt32(txthour.Text) * 60 * 60 + Convert.ToInt32(txtmin.Text) * 60;
            label4.Text = timeleft.ToString();
            countdowntimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Process.Start("shutdown", $"/s /t 0");

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

        public void txthour_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txthour.Text))
            {

            }
            else
            {
                string hourtext = txthour.Text;
                Convert.ToInt32(hourtext);
                int.TryParse(hourtext, out hour);



            }
        }
        public void txtmin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmin.Text))
            {

            }
            else
            {
                string mintext = txtmin.Text;
                Convert.ToInt32(mintext);
                if (int.TryParse(mintext, out min))
                {

                }
                else
                {

                }
            }
               

                

            }

        }

        private void txthour_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmin_TextChanged(object sender, EventArgs e)
        {

        }
        
        public void countdowntimer_Tick(object sender, EventArgs e)
        {

            label4.Text = timeleft.ToString();
            if (timeleft > 0)
            {
                timeleft--;
            }
            else
            {
                button1_Click(this, EventArgs.Empty);
            }

        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            countdowntimer.Start();
            label4.Text = timeleft.ToString();
        }
    }
}
