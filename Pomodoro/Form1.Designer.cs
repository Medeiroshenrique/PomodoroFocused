namespace Pomodoro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btn_Play = new Button();
            PomodoroTimer = new System.Windows.Forms.Timer(components);
            RestTimer = new System.Windows.Forms.Timer(components);
            TimerLabel = new Label();
            SuspendLayout();
            // 
            // btn_Play
            // 
            btn_Play.BackColor = Color.DarkOrange;
            btn_Play.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Play.Location = new Point(359, 431);
            btn_Play.Margin = new Padding(3, 4, 3, 4);
            btn_Play.Name = "btn_Play";
            btn_Play.Size = new Size(202, 95);
            btn_Play.TabIndex = 0;
            btn_Play.Text = "PLAY";
            btn_Play.UseVisualStyleBackColor = false;
            btn_Play.Click += button1_Click;
            // 
            // PomodoroTimer
            // 
            PomodoroTimer.Interval = 1000;
            PomodoroTimer.Tick += PomodoroTimer_Tick;
            // 
            // RestTimer
            // 
            RestTimer.Interval = 1000;
            RestTimer.Tick += RestTimer_Tick;
            // 
            // TimerLabel
            // 
            TimerLabel.Font = new Font("Impact", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            TimerLabel.Location = new Point(83, 259);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(129, 52);
            TimerLabel.TabIndex = 1;
            TimerLabel.Text = "00 : 00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pomodoro;
            ClientSize = new Size(779, 595);
            Controls.Add(TimerLabel);
            Controls.Add(btn_Play);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "HomePage";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Play;
        private System.Windows.Forms.Timer PomodoroTimer;
        private System.Windows.Forms.Timer RestTimer;
        private Label TimerLabel;
    }
}