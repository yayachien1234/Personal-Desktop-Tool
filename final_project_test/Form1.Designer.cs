using System.Drawing;
using System.Windows.Forms;

namespace final_project_test
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_time = new System.Windows.Forms.Button();
            this.btn_concentrate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_ToDoList = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbx_wtLocation = new System.Windows.Forms.ComboBox();
            this.lbl_weather = new System.Windows.Forms.Label();
            this.lbl_SelectLocation = new System.Windows.Forms.Label();
            this.panel_schedule = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_today = new System.Windows.Forms.Label();
            this.tbx_Search = new System.Windows.Forms.TextBox();
            this.btn_SetAccount = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_playStop = new System.Windows.Forms.Button();
            this.btn_AddToDo = new System.Windows.Forms.Button();
            this.btn_AddSchedule = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_ConvertFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Spotify = new System.Windows.Forms.Button();
            this.btn_moodle = new System.Windows.Forms.Button();
            this.btn_Instagram = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_DeleteButton = new System.Windows.Forms.Button();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbx_city = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel_schedule.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "letter-m (2).png");
            this.imageList1.Images.SetKeyName(1, "letter-m.png");
            this.imageList1.Images.SetKeyName(2, "wallpaper.jpg");
            // 
            // btn_time
            // 
            this.btn_time.Font = new System.Drawing.Font("Niagara Solid", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_time.Location = new System.Drawing.Point(420, 17);
            this.btn_time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_time.Name = "btn_time";
            this.btn_time.Size = new System.Drawing.Size(385, 114);
            this.btn_time.TabIndex = 4;
            this.btn_time.Text = "btn_time(time)";
            this.btn_time.UseVisualStyleBackColor = true;
            this.btn_time.Click += new System.EventHandler(this.btn_time_Click);
            // 
            // btn_concentrate
            // 
            this.btn_concentrate.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_concentrate.Location = new System.Drawing.Point(420, 137);
            this.btn_concentrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_concentrate.Name = "btn_concentrate";
            this.btn_concentrate.Size = new System.Drawing.Size(178, 85);
            this.btn_concentrate.TabIndex = 6;
            this.btn_concentrate.Text = "專注模式";
            this.btn_concentrate.UseVisualStyleBackColor = true;
            this.btn_concentrate.Click += new System.EventHandler(this.btn_time_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel_schedule);
            this.panel1.Controls.Add(this.tbx_Search);
            this.panel1.Controls.Add(this.btn_SetAccount);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.btn_Next);
            this.panel1.Controls.Add(this.btn_playStop);
            this.panel1.Controls.Add(this.btn_AddToDo);
            this.panel1.Controls.Add(this.btn_AddSchedule);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.btn_time);
            this.panel1.Controls.Add(this.btn_concentrate);
            this.panel1.Controls.Add(this.btn_ConvertFile);
            this.panel1.Location = new System.Drawing.Point(121, 185);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1393, 550);
            this.panel1.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.AutoScrollMinSize = new System.Drawing.Size(0, 282);
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.Controls.Add(this.lbl_ToDoList);
            this.panel5.Location = new System.Drawing.Point(816, 266);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(566, 281);
            this.panel5.TabIndex = 22;
            // 
            // lbl_ToDoList
            // 
            this.lbl_ToDoList.AutoSize = true;
            this.lbl_ToDoList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_ToDoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ToDoList.Location = new System.Drawing.Point(6, 14);
            this.lbl_ToDoList.Name = "lbl_ToDoList";
            this.lbl_ToDoList.Size = new System.Drawing.Size(535, 29);
            this.lbl_ToDoList.TabIndex = 2;
            this.lbl_ToDoList.Text = "{ToDo-List}   加把勁鴨~ 決定好的事情要做嘿";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::final_project_test.Properties.Resources.wallpaper;
            this.pictureBox1.Location = new System.Drawing.Point(16, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 205);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.Controls.Add(this.cbx_city);
            this.panel4.Controls.Add(this.cbx_wtLocation);
            this.panel4.Controls.Add(this.lbl_weather);
            this.panel4.Controls.Add(this.lbl_SelectLocation);
            this.panel4.Location = new System.Drawing.Point(16, 237);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(788, 54);
            this.panel4.TabIndex = 20;
            // 
            // cbx_wtLocation
            // 
            this.cbx_wtLocation.FormattingEnabled = true;
            this.cbx_wtLocation.Location = new System.Drawing.Point(3, 27);
            this.cbx_wtLocation.Name = "cbx_wtLocation";
            this.cbx_wtLocation.Size = new System.Drawing.Size(121, 23);
            this.cbx_wtLocation.TabIndex = 1;
            this.cbx_wtLocation.SelectedIndexChanged += new System.EventHandler(this.cbx_wtLocation_SelectedIndexChanged);
            // 
            // lbl_weather
            // 
            this.lbl_weather.AutoSize = true;
            this.lbl_weather.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_weather.Location = new System.Drawing.Point(130, 29);
            this.lbl_weather.Name = "lbl_weather";
            this.lbl_weather.Size = new System.Drawing.Size(82, 18);
            this.lbl_weather.TabIndex = 2;
            this.lbl_weather.Text = "lbl_weather";
            // 
            // lbl_SelectLocation
            // 
            this.lbl_SelectLocation.AutoSize = true;
            this.lbl_SelectLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbl_SelectLocation.Location = new System.Drawing.Point(3, 6);
            this.lbl_SelectLocation.Name = "lbl_SelectLocation";
            this.lbl_SelectLocation.Size = new System.Drawing.Size(142, 18);
            this.lbl_SelectLocation.TabIndex = 18;
            this.lbl_SelectLocation.Text = "Choose Location:";
            // 
            // panel_schedule
            // 
            this.panel_schedule.AutoScroll = true;
            this.panel_schedule.AutoScrollMinSize = new System.Drawing.Size(0, 245);
            this.panel_schedule.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_schedule.Controls.Add(this.label1);
            this.panel_schedule.Controls.Add(this.lbl_today);
            this.panel_schedule.Location = new System.Drawing.Point(816, 14);
            this.panel_schedule.Name = "panel_schedule";
            this.panel_schedule.Size = new System.Drawing.Size(566, 244);
            this.panel_schedule.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "{行事曆}     辛苦了鴨~ 再努力一下                 ";
            // 
            // lbl_today
            // 
            this.lbl_today.AutoSize = true;
            this.lbl_today.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_today.Location = new System.Drawing.Point(5, 51);
            this.lbl_today.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_today.Name = "lbl_today";
            this.lbl_today.Size = new System.Drawing.Size(128, 33);
            this.lbl_today.TabIndex = 0;
            this.lbl_today.Text = "lbl_today";
            // 
            // tbx_Search
            // 
            this.tbx_Search.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_Search.ForeColor = System.Drawing.Color.Silver;
            this.tbx_Search.Location = new System.Drawing.Point(16, 421);
            this.tbx_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_Search.Name = "tbx_Search";
            this.tbx_Search.Size = new System.Drawing.Size(667, 38);
            this.tbx_Search.TabIndex = 17;
            this.tbx_Search.Tag = "";
            this.tbx_Search.Text = "please enter song name";
            this.tbx_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_Search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbx_Search_MouseClick);
            // 
            // btn_SetAccount
            // 
            this.btn_SetAccount.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SetAccount.Location = new System.Drawing.Point(604, 137);
            this.btn_SetAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SetAccount.Name = "btn_SetAccount";
            this.btn_SetAccount.Size = new System.Drawing.Size(97, 85);
            this.btn_SetAccount.TabIndex = 15;
            this.btn_SetAccount.Text = "帳號設定";
            this.btn_SetAccount.UseVisualStyleBackColor = true;
            this.btn_SetAccount.Click += new System.EventHandler(this.btn_SetAccount_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Niagara Engraved", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(13, 463);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(217, 83);
            this.btn_Back.TabIndex = 14;
            this.btn_Back.Text = "|<";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("Niagara Engraved", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(460, 463);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(222, 83);
            this.btn_Next.TabIndex = 13;
            this.btn_Next.Text = ">|";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_playStop
            // 
            this.btn_playStop.Font = new System.Drawing.Font("Niagara Engraved", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playStop.Location = new System.Drawing.Point(236, 463);
            this.btn_playStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_playStop.Name = "btn_playStop";
            this.btn_playStop.Size = new System.Drawing.Size(219, 83);
            this.btn_playStop.TabIndex = 12;
            this.btn_playStop.Text = "play/stop";
            this.btn_playStop.UseVisualStyleBackColor = true;
            this.btn_playStop.Click += new System.EventHandler(this.btn_playStop_Click);
            // 
            // btn_AddToDo
            // 
            this.btn_AddToDo.Font = new System.Drawing.Font("Niagara Engraved", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddToDo.Location = new System.Drawing.Point(13, 352);
            this.btn_AddToDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddToDo.Name = "btn_AddToDo";
            this.btn_AddToDo.Size = new System.Drawing.Size(791, 54);
            this.btn_AddToDo.TabIndex = 11;
            this.btn_AddToDo.Text = "Add new to-do list";
            this.btn_AddToDo.UseVisualStyleBackColor = true;
            this.btn_AddToDo.Click += new System.EventHandler(this.btn_AddToDo_Click);
            // 
            // btn_AddSchedule
            // 
            this.btn_AddSchedule.Font = new System.Drawing.Font("Niagara Engraved", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddSchedule.Location = new System.Drawing.Point(13, 295);
            this.btn_AddSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddSchedule.Name = "btn_AddSchedule";
            this.btn_AddSchedule.Size = new System.Drawing.Size(791, 54);
            this.btn_AddSchedule.TabIndex = 10;
            this.btn_AddSchedule.Text = "Add New Schedule";
            this.btn_AddSchedule.UseVisualStyleBackColor = true;
            this.btn_AddSchedule.Click += new System.EventHandler(this.btn_AddSchedule_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Niagara Engraved", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(689, 421);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(116, 126);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_ConvertFile
            // 
            this.btn_ConvertFile.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ConvertFile.Location = new System.Drawing.Point(708, 137);
            this.btn_ConvertFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ConvertFile.Name = "btn_ConvertFile";
            this.btn_ConvertFile.Size = new System.Drawing.Size(97, 85);
            this.btn_ConvertFile.TabIndex = 16;
            this.btn_ConvertFile.Text = "檔案轉換";
            this.btn_ConvertFile.UseVisualStyleBackColor = true;
            this.btn_ConvertFile.Click += new System.EventHandler(this.btn_ConvertFile_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(121, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1393, 186);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(892, 95);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome  Back  User1";
            // 
            // btn_Spotify
            // 
            this.btn_Spotify.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Spotify.FlatAppearance.BorderSize = 0;
            this.btn_Spotify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btn_Spotify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btn_Spotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Spotify.Font = new System.Drawing.Font("Niagara Engraved", 16F);
            this.btn_Spotify.Location = new System.Drawing.Point(3, 148);
            this.btn_Spotify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Spotify.Name = "btn_Spotify";
            this.btn_Spotify.Size = new System.Drawing.Size(124, 38);
            this.btn_Spotify.TabIndex = 11;
            this.btn_Spotify.Text = "Spotify";
            this.btn_Spotify.UseVisualStyleBackColor = false;
            this.btn_Spotify.Click += new System.EventHandler(this.btn_Spotify_Click);
            // 
            // btn_moodle
            // 
            this.btn_moodle.BackColor = System.Drawing.Color.White;
            this.btn_moodle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_moodle.FlatAppearance.BorderSize = 0;
            this.btn_moodle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btn_moodle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btn_moodle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_moodle.Font = new System.Drawing.Font("Niagara Engraved", 16F);
            this.btn_moodle.Location = new System.Drawing.Point(0, 68);
            this.btn_moodle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_moodle.Name = "btn_moodle";
            this.btn_moodle.Size = new System.Drawing.Size(124, 38);
            this.btn_moodle.TabIndex = 13;
            this.btn_moodle.Tag = "https://youtube.com";
            this.btn_moodle.Text = "Moodle";
            this.btn_moodle.UseVisualStyleBackColor = false;
            this.btn_moodle.Click += new System.EventHandler(this.btn_moodle_Click_1);
            // 
            // btn_Instagram
            // 
            this.btn_Instagram.BackColor = System.Drawing.Color.White;
            this.btn_Instagram.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Instagram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btn_Instagram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btn_Instagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Instagram.Font = new System.Drawing.Font("Niagara Engraved", 16F);
            this.btn_Instagram.Location = new System.Drawing.Point(0, 108);
            this.btn_Instagram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Instagram.Name = "btn_Instagram";
            this.btn_Instagram.Size = new System.Drawing.Size(124, 38);
            this.btn_Instagram.TabIndex = 1;
            this.btn_Instagram.Text = "Instagram";
            this.btn_Instagram.UseVisualStyleBackColor = false;
            this.btn_Instagram.Click += new System.EventHandler(this.btn_Instagram_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btn_DeleteButton);
            this.panel3.Controls.Add(this.btn_AddNew);
            this.panel3.Controls.Add(this.btn_Instagram);
            this.panel3.Controls.Add(this.btn_moodle);
            this.panel3.Controls.Add(this.btn_Spotify);
            this.panel3.Location = new System.Drawing.Point(-3, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 735);
            this.panel3.TabIndex = 12;
            // 
            // btn_DeleteButton
            // 
            this.btn_DeleteButton.Location = new System.Drawing.Point(1, 664);
            this.btn_DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DeleteButton.Name = "btn_DeleteButton";
            this.btn_DeleteButton.Size = new System.Drawing.Size(124, 38);
            this.btn_DeleteButton.TabIndex = 16;
            this.btn_DeleteButton.Text = "Delete btn";
            this.btn_DeleteButton.UseVisualStyleBackColor = true;
            this.btn_DeleteButton.Click += new System.EventHandler(this.btn_DeleteButton_Click);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(1, 698);
            this.btn_AddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(124, 38);
            this.btn_AddNew.TabIndex = 14;
            this.btn_AddNew.Text = "Add new btn";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbx_city
            // 
            this.cbx_city.FormattingEnabled = true;
            this.cbx_city.Items.AddRange(new object[] {
            "臺南市",
            "宜蘭縣",
            "桃園市",
            "新竹縣",
            "新竹市",
            "苗栗縣",
            "彰化縣",
            "南投縣",
            "雲林縣",
            "嘉義縣",
            "嘉義市",
            "屏東縣",
            "臺東縣",
            "花蓮縣",
            "澎湖縣",
            "基隆市",
            "臺北市",
            "新北市",
            "高雄市",
            "臺中市",
            "連江縣",
            "金門縣"});
            this.cbx_city.Location = new System.Drawing.Point(160, 3);
            this.cbx_city.Name = "cbx_city";
            this.cbx_city.Size = new System.Drawing.Size(121, 23);
            this.cbx_city.TabIndex = 19;
            this.cbx_city.SelectedIndexChanged += new System.EventHandler(this.cbx_city_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1514, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_schedule.ResumeLayout(false);
            this.panel_schedule.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ImageList imageList1;
        private Button btn_time;
        private Button btn_concentrate;
        private Panel panel1;
        private Panel panel2;
        private Button btn_Spotify;
        public Button btn_moodle;
        private Button btn_Instagram;
        private Button btn_AddNew;
        private Button btn_DeleteButton;
        public Panel panel3;
        private Label lbl_today;
        private ComboBox cbx_wtLocation;
        private Label lbl_weather;
        private TextBox tbx_Search;
        private Button btn_ConvertFile;
        private Button btn_SetAccount;
        private Button btn_Back;
        private Button btn_Next;
        private Button btn_playStop;
        private Button btn_AddToDo;
        private Button btn_AddSchedule;
        private Button btn_Search;
        private Label lbl_SelectLocation;
        private Timer timer1;
        private Panel panel_schedule;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel5;
        private Label lbl_ToDoList;
        private Label label2;
        private ComboBox cbx_city;
    }
}

