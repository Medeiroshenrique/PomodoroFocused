using System.Configuration;

namespace Pomodoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Important information: 25 minutes has 1500 seconds
        int Worktime = 10; //* 60;
        int RestTime = 5;//* 60;
        

        private void PomodoroTimer_Tick(object sender, EventArgs e)
        {
            if (Worktime > 0)
            {
                Worktime -= 1;
            }
            else
            {
                PomodoroTimer.Stop();
                MessageBox.Show("Time to rest soldier!");
                RestTimer.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("and... START YOUR TASK!!!");
            PomodoroTimer.Start();

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