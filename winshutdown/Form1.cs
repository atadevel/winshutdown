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
        private int timeleft;
        public void StartCountdown()
        {
            if (int.TryParse(txthour.Text, out hour) && int.TryParse(txtmin.Text, out min))
            {
                timeleft = hour * 60 * 60 + min * 60;
                countdowntimer.Start();
            }
        }
        public void countdowntimer_Tick(object sender, EventArgs e)
        {

            if (timeleft > 0)
            {
                label4.Text = timeleft.ToString();
                timeleft--;
            }
            else
            {
                button1_Click(this, EventArgs.Empty);
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            countdowntimer.Stop();
            timeleft = 0;
            label4.Text = timeleft.ToString();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            StartCountdown();
        }

        public void txthour_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txthour.Text) == true)
            {
                return;
            }
            else
            {
                string hourtext = txthour.Text;
                Convert.ToInt32(hourtext);
                if (int.TryParse(hourtext, out hour))
                {

                }
                else
                {

                }
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

}


