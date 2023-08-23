using System.Configuration;

namespace Pomodoro
{
    public partial class Form1 : Form
    {
        //Important information: 25 minutes has 1500 seconds
        private int Worktime = 25 * 60;
        private int RestTime = 5 * 60;
        private int Minutes = 25;
        private int Seconds = 60;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("and... START YOUR TASK!!!");
            PomodoroTimer.Start();
            Minutes -= 1;
        }

        private void PomodoroTimer_Tick(object sender, EventArgs e)
        {
            if (Worktime > 0)
            {
                Worktime -= 1;
                Seconds -= 1;
                this.TimerLabel.Text = $"{Minutes} : {Seconds}";
                if (Minutes > 0) {
                    if (Seconds == 0)
                    {
                        Minutes -= 1;
                        Seconds = 60;
                    }
                }
                
            }
            else
            {
                PomodoroTimer.Stop();
                MessageBox.Show("Time to rest soldier!");
                RestTimer.Start();
                Minutes = 5;
            }
        }

        private void RestTimer_Tick(object sender, EventArgs e)
        {
            if (RestTime > 0)
            {
                RestTime -= 1;
            }
            else
            {
                RestTimer.Stop();
                MessageBox.Show("Rest time is over!");
            }
        }

    }
}