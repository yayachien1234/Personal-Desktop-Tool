using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project_test
{
    public partial class ClockForm : Form{

        public List<string> alarms;
        public List<Button> btn_alarms = new List<Button>();

        private static string alarmPath = "alarm.txt";
        private static bool tbx_timer_HasText = false;
        private int timer_h, timer_m, timer_s;
        private int sw_h, sw_m, sw_s;  // sw=stopwatch

        public ClockForm()
        {
            InitializeComponent();

            alarms = new List<string>();
            if (!File.Exists(alarmPath))
            {
                File.Create(alarmPath);
            }
            else
            {
                using (StreamReader sr = new StreamReader(alarmPath))
                {
                    while (!sr.EndOfStream)
                    {
                        alarms.Add(sr.ReadLine());
                    }
                }
            }
        }

        private void ClockForm_Load(object sender, EventArgs e)
        {
            lbl_addAlarm.Text = "";

            ShowAlarms();

            // timer settings
            tbx_timer.Text = "00h00m00s";
            tbx_timer.ForeColor = Color.Gray;

            timer1.Enabled = false;

            // timestop settings
            timer2.Enabled = false;
            sw_h = 0;
            sw_m = 0;
            sw_s = 0;
        }

        private void btn_addAlarm_Click(object sender, EventArgs e)
        {
            if(int.Parse(cbx_hr.Text) >= 0 && int.Parse(cbx_hr.Text) < 24 &&
                int.Parse(cbx_min.Text) >= 0 && int.Parse(cbx_min.Text) < 60) 
            {
                string alarmTime = int.Parse(cbx_hr.Text).ToString() + ":" + int.Parse(cbx_min.Text).ToString();
                if (!alarms.Contains(alarmTime))
                {
                    alarms.Add(alarmTime);
                    using(StreamWriter sw = new StreamWriter(alarmPath, false))
                    {
                        foreach(string alarm in alarms)
                        {
                            sw.WriteLine(alarm);
                        }
                    }
                }
                lbl_addAlarm.ForeColor = Color.Green;
                lbl_addAlarm.Text = "success";

                ShowAlarms();
            }
            else
            {
                lbl_addAlarm.ForeColor = Color.Red;
                lbl_addAlarm.Text = "fail";
            }

        }

        private void btn_alarm_Click(object sender, EventArgs e)
        {
            Button alarm = sender as Button;
            if(alarm.BackColor == Color.LightGreen)
            {
                alarm.Tag = 0;
                alarm.BackColor = Color.Red;
            }
            else
            {
                alarm.Tag = 1;
                alarm.BackColor = Color.LightGreen;
            }
        }

        private void ShowAlarms()
        {
            foreach(Button btn_a in btn_alarms) 
            {
                Controls.Remove(btn_a);
            }
            btn_alarms.Clear();

            int x = 50, y = 100;

            alarms.Sort();

            foreach (string alarm in alarms)
            {
                // setting alarm button
                Button btn_alarm = new Button();
                btn_alarm.Location = new Point(x, y);
                btn_alarm.AutoSize = true;
                btn_alarm.Text = alarm;
                btn_alarm.Tag = 1;
                btn_alarm.BackColor = Color.LightGreen;
                btn_alarm.Click += new EventHandler(btn_alarm_Click);
                panel_alarm.Controls.Add(btn_alarm);
                btn_alarms.Add(btn_alarm);

                y += (btn_alarm.Size.Height + 10);

            }

        }

        private void tbx_timer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & 
                (int)e.KeyChar != 8 & (int)e.KeyChar != 46 & 
                (int)e.KeyChar != 37 & (int)e.KeyChar != 39)
            {
                e.Handled = true;
            }
        }

        //tbx_timer 獲得焦點
        private void tbx_timer_Enter(object sender, EventArgs e)
        {
            if (tbx_timer_HasText == false)
                tbx_timer.Text = "";
            tbx_timer.ForeColor = Color.Black;
        }

        //tbx_timer 失去焦點
        private void tbx_timer_Leave(object sender, EventArgs e)
        {
            if (tbx_timer.Text == "")
            {
                tbx_timer.Text = "00h00m00s";
                tbx_timer.ForeColor = Color.Gray;
                tbx_timer_HasText = false;
            }
            else
            {
                tbx_timer_HasText = true;
            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("請直接輸入數\nex:輸入123456，會將計時器設成12:34:56", "help", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_StartAndStop_Click(object sender, EventArgs e)
        {
            if(btn_StartAndStop.Text == "Start")
            {
                if (tbx_timer_HasText && timer_m < 60 && timer_s < 60)
                {
                    btn_StartAndStop.Text = "Stop";
                    tbx_timer.Enabled = false;
                    timer1.Enabled = true;
                }
                else if (timer_m >= 60 || timer_s >= 60)
                {
                    MessageBox.Show("計時器設置錯誤\n分鐘或秒數不可大於59", "error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("未設定時間", "warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                btn_StartAndStop.Text = "Start";
                timer1.Enabled = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            timer_s = int.Parse(tbx_timer.Text) % 100;
            timer_m = int.Parse(tbx_timer.Text) % 10000 / 100;
            timer_h = int.Parse(tbx_timer.Text) / 10000;

            ShowTimer(timer_h, timer_m, timer_s);

            btn_StartAndStop.Text = "Start";
            timer1.Enabled = false;
            tbx_timer.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timer_s == 0)
            {
                if(timer_m == 0)
                {
                    if(timer_h == 0)
                    {
                        timer1.Enabled = false;
                        btn_StartAndStop.Text = "Start";
                        btn_cancel_Click(null, null);
                        MessageBox.Show("Times up!");
                    }
                    else
                    {
                        timer_h--;
                        timer_m = 59;
                        timer_s = 59;
                    }
                }
                else
                {
                    timer_m--;
                    timer_s = 59;
                }
            }
            else
            {
                timer_s--;
            }

            ShowTimer(timer_h, timer_m, timer_s);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            RunStopWatch();
        }

        private void btn_StopwatchPlay_Click(object sender, EventArgs e)
        {
            if(btn_StopwatchPlay.Text == "Start")
            {
                btn_StopwatchPlay.Text = "Stop";
                btn_LapAndReset.Text = "Lap";
                timer2.Enabled = true;
            }
            else
            {
                btn_StopwatchPlay.Text = "Start";
                btn_LapAndReset.Text = "Reset";
                timer2.Enabled = false;
            }
        }

        private void btn_LapAndReset_Click(object sender, EventArgs e)
        {
            if(btn_LapAndReset.Text == "Reset")
            {
                sw_h = 0;
                sw_m = 0;
                sw_s = 0;

                ShowStopwatch(sw_h, sw_m , sw_s);

                timer2.Enabled = false;
                tbx_stopwatch.Text = "";
            }
            else
            {
                tbx_stopwatch.Text += lbl_stopwatch.Text + "\n";
            }
        }

        private void tbx_timer_TextChanged(object sender, EventArgs e)
        {
            if (!tbx_timer.Text.Equals("00h00m00s"))
            {
                try
                {
                    timer_s = int.Parse(tbx_timer.Text) % 100;
                    timer_m = int.Parse(tbx_timer.Text) % 10000 / 100;
                    timer_h = int.Parse(tbx_timer.Text) / 10000;

                    ShowTimer(timer_h, timer_m, timer_s);
                }catch (Exception ex) 
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
        }

        private void ShowTimer(int h, int m, int s)
        {
            string showtime = "";
            showtime += h.ToString("D2");
            showtime += ":";
            showtime += m.ToString("D2");
            showtime += ":";
            showtime += s.ToString("D2");

            lbl_time.Text = showtime;
        }

        private void ShowStopwatch(int h, int m, int s)
        {
            string showtime = "";
            showtime += h.ToString("D2");
            showtime += ":";
            showtime += m.ToString("D2");
            showtime += ":";
            showtime += s.ToString("D2");

            lbl_stopwatch.Text = showtime;
        }

        private void RunStopWatch()
        {
            sw_s++;
            if (sw_s == 60)
            {
                sw_s = 0;
                sw_m++;
                if (sw_m == 60)
                {
                    sw_m = 0;
                    sw_h++;
                }
            }

            ShowStopwatch(sw_h, sw_m, sw_s);
        }
    }
}
