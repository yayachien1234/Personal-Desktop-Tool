namespace final_project_test
{
    partial class ClockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_alarm = new System.Windows.Forms.Panel();
            this.lbl_addAlarm = new System.Windows.Forms.Label();
            this.btn_addAlarm = new System.Windows.Forms.Button();
            this.cbx_min = new System.Windows.Forms.ComboBox();
            this.cbx_hr = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_StartAndStop = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.tbx_timer = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbx_stopwatch = new System.Windows.Forms.TextBox();
            this.btn_StopwatchPlay = new System.Windows.Forms.Button();
            this.btn_LapAndReset = new System.Windows.Forms.Button();
            this.lbl_stopwatch = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel_alarm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_alarm
            // 
            this.panel_alarm.Controls.Add(this.lbl_addAlarm);
            this.panel_alarm.Controls.Add(this.btn_addAlarm);
            this.panel_alarm.Controls.Add(this.cbx_min);
            this.panel_alarm.Controls.Add(this.cbx_hr);
            this.panel_alarm.Location = new System.Drawing.Point(12, 12);
            this.panel_alarm.Name = "panel_alarm";
            this.panel_alarm.Size = new System.Drawing.Size(373, 426);
            this.panel_alarm.TabIndex = 0;
            // 
            // lbl_addAlarm
            // 
            this.lbl_addAlarm.AutoSize = true;
            this.lbl_addAlarm.Location = new System.Drawing.Point(288, 55);
            this.lbl_addAlarm.Name = "lbl_addAlarm";
            this.lbl_addAlarm.Size = new System.Drawing.Size(41, 15);
            this.lbl_addAlarm.TabIndex = 3;
            this.lbl_addAlarm.Text = "label1";
            // 
            // btn_addAlarm
            // 
            this.btn_addAlarm.Location = new System.Drawing.Point(207, 52);
            this.btn_addAlarm.Name = "btn_addAlarm";
            this.btn_addAlarm.Size = new System.Drawing.Size(75, 23);
            this.btn_addAlarm.TabIndex = 2;
            this.btn_addAlarm.Text = "add alarm";
            this.btn_addAlarm.UseVisualStyleBackColor = true;
            this.btn_addAlarm.Click += new System.EventHandler(this.btn_addAlarm_Click);
            // 
            // cbx_min
            // 
            this.cbx_min.FormattingEnabled = true;
            this.cbx_min.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbx_min.Location = new System.Drawing.Point(129, 52);
            this.cbx_min.Name = "cbx_min";
            this.cbx_min.Size = new System.Drawing.Size(59, 23);
            this.cbx_min.TabIndex = 1;
            // 
            // cbx_hr
            // 
            this.cbx_hr.FormattingEnabled = true;
            this.cbx_hr.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbx_hr.Location = new System.Drawing.Point(49, 52);
            this.cbx_hr.Name = "cbx_hr";
            this.cbx_hr.Size = new System.Drawing.Size(59, 23);
            this.cbx_hr.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_StartAndStop);
            this.panel1.Controls.Add(this.btn_help);
            this.panel1.Controls.Add(this.tbx_timer);
            this.panel1.Location = new System.Drawing.Point(391, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 192);
            this.panel1.TabIndex = 1;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("新細明體", 25F);
            this.lbl_time.Location = new System.Drawing.Point(191, 117);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_time.Size = new System.Drawing.Size(160, 42);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "00:00:00";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(40, 141);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(61, 44);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_StartAndStop
            // 
            this.btn_StartAndStop.Location = new System.Drawing.Point(40, 91);
            this.btn_StartAndStop.Name = "btn_StartAndStop";
            this.btn_StartAndStop.Size = new System.Drawing.Size(61, 44);
            this.btn_StartAndStop.TabIndex = 2;
            this.btn_StartAndStop.Text = "Start";
            this.btn_StartAndStop.UseVisualStyleBackColor = true;
            this.btn_StartAndStop.Click += new System.EventHandler(this.btn_StartAndStop_Click);
            // 
            // btn_help
            // 
            this.btn_help.AutoSize = true;
            this.btn_help.Location = new System.Drawing.Point(367, 3);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(27, 25);
            this.btn_help.TabIndex = 1;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // tbx_timer
            // 
            this.tbx_timer.Font = new System.Drawing.Font("新細明體", 25F);
            this.tbx_timer.Location = new System.Drawing.Point(40, 20);
            this.tbx_timer.Multiline = true;
            this.tbx_timer.Name = "tbx_timer";
            this.tbx_timer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_timer.Size = new System.Drawing.Size(311, 55);
            this.tbx_timer.TabIndex = 0;
            this.tbx_timer.TextChanged += new System.EventHandler(this.tbx_timer_TextChanged);
            this.tbx_timer.Enter += new System.EventHandler(this.tbx_timer_Enter);
            this.tbx_timer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_timer_KeyPress);
            this.tbx_timer.Leave += new System.EventHandler(this.tbx_timer_Leave);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbx_stopwatch);
            this.panel2.Controls.Add(this.btn_StopwatchPlay);
            this.panel2.Controls.Add(this.btn_LapAndReset);
            this.panel2.Controls.Add(this.lbl_stopwatch);
            this.panel2.Location = new System.Drawing.Point(392, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 227);
            this.panel2.TabIndex = 2;
            // 
            // tbx_stopwatch
            // 
            this.tbx_stopwatch.Font = new System.Drawing.Font("新細明體", 16F);
            this.tbx_stopwatch.Location = new System.Drawing.Point(39, 123);
            this.tbx_stopwatch.Multiline = true;
            this.tbx_stopwatch.Name = "tbx_stopwatch";
            this.tbx_stopwatch.ReadOnly = true;
            this.tbx_stopwatch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_stopwatch.Size = new System.Drawing.Size(292, 101);
            this.tbx_stopwatch.TabIndex = 3;
            // 
            // btn_StopwatchPlay
            // 
            this.btn_StopwatchPlay.Location = new System.Drawing.Point(135, 72);
            this.btn_StopwatchPlay.Name = "btn_StopwatchPlay";
            this.btn_StopwatchPlay.Size = new System.Drawing.Size(61, 44);
            this.btn_StopwatchPlay.TabIndex = 2;
            this.btn_StopwatchPlay.Text = "Start";
            this.btn_StopwatchPlay.UseVisualStyleBackColor = true;
            this.btn_StopwatchPlay.Click += new System.EventHandler(this.btn_StopwatchPlay_Click);
            // 
            // btn_LapAndReset
            // 
            this.btn_LapAndReset.Location = new System.Drawing.Point(39, 72);
            this.btn_LapAndReset.Name = "btn_LapAndReset";
            this.btn_LapAndReset.Size = new System.Drawing.Size(61, 44);
            this.btn_LapAndReset.TabIndex = 1;
            this.btn_LapAndReset.Text = "Reset";
            this.btn_LapAndReset.UseVisualStyleBackColor = true;
            this.btn_LapAndReset.Click += new System.EventHandler(this.btn_LapAndReset_Click);
            // 
            // lbl_stopwatch
            // 
            this.lbl_stopwatch.AutoSize = true;
            this.lbl_stopwatch.Font = new System.Drawing.Font("新細明體", 25F);
            this.lbl_stopwatch.Location = new System.Drawing.Point(32, 18);
            this.lbl_stopwatch.Name = "lbl_stopwatch";
            this.lbl_stopwatch.Size = new System.Drawing.Size(160, 42);
            this.lbl_stopwatch.TabIndex = 0;
            this.lbl_stopwatch.Text = "00:00:00";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_alarm);
            this.Name = "ClockForm";
            this.Text = "ClockForm";
            this.Load += new System.EventHandler(this.ClockForm_Load);
            this.panel_alarm.ResumeLayout(false);
            this.panel_alarm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_alarm;
        private System.Windows.Forms.ComboBox cbx_min;
        private System.Windows.Forms.ComboBox cbx_hr;
        private System.Windows.Forms.Label lbl_addAlarm;
        private System.Windows.Forms.Button btn_addAlarm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbx_timer;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_StartAndStop;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_stopwatch;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_StopwatchPlay;
        private System.Windows.Forms.Button btn_LapAndReset;
        private System.Windows.Forms.TextBox tbx_stopwatch;
    }
}