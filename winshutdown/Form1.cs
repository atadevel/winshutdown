using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace winshutdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int hour = 0;
        int min = 0;
        private int timeleft;
        private string clickedbutton = "";
        private void operation(string buttonclicked)
        {
            if (timeleft < 1)
            {
                clickedbutton = buttonclicked;

                if (buttonclicked == "button1")
                {
                    Process.Start("shutdown", "/s /t 0");
                }
                else if (buttonclicked == "button2")
                {
                    Process.Start("shutdown", "/r /t 0");
                }
            }
        }
        public void StartCountdown()
        {
            txthour_Leave(this, EventArgs.Empty);
            txtmin_Leave(this, EventArgs.Empty);
            timeleft = hour * 3600 + min * 60;
            countdowntimer.Start();

        }
        public void countdowntimer_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft--;
                label4.Text = timeleft.ToString();
            }
            else
            {
                operation(clickedbutton);
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            StartCountdown();
            clickedbutton = "button1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StartCountdown();
            clickedbutton = "button2";
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
            if (string.IsNullOrEmpty(txthour.Text))
            {
                hour = 0;
            }
            else
            {
                int.TryParse(txthour.Text, out hour);
            }
        }
        public void txtmin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmin.Text))
            {
                min = 0;
            }
            else
            {
                int.TryParse(txtmin.Text, out min);
            }




        }

    }

}


