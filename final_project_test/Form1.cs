using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace final_project_test
{
    public partial class Form1 : Form
    {

        private Form2 form2;
        private ClockForm clockForm = new ClockForm();
        private List<Button> buttonsList = new List<Button>();
        private Weather weather;
        private bool firstTimebtn_DeleteButtonClick = true;
        private bool first_search = true;
        private bool first_login = true;
        private string which_webpage = "";
        private bool in_music_webpage = false;
        private int webpage_number = 0;
        private bool use_profile = true;
        private bool catch_profile = true;
        private string profile_path = "";
        private string ToDo_path = @"..\..\ToDo\";
        private List<Button> btn_ToDoList = new List<Button>();

        public const string filePath = "shortcut.txt";
        int i = 1;

        IWebDriver driver;

        public Form1()
        {
            InitializeComponent();
            Get_Profile();
            LoadButtonsFromTextFile();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // show today calendar
            lbl_today.Text = DateTime.Now.ToString("yyyy/MM/dd");
            int x = lbl_today.Location.X;
            int y = lbl_today.Location.Y + lbl_today.Height + 10;
            ShowPlans(x, y);

            // setting weather location
            weather = new Weather();
            if (weather.getCityData("臺南市"))
            {
                cbx_wtLocation.Items.AddRange(weather.Locations.ToArray());
                Debug.WriteLine("get weather locations success");
            }
            else
            {
                Debug.WriteLine("get weather locations fail");
            }
            lbl_weather.Text = "";

            // timer setting
            timer1.Interval = 1000;  // 1s
            timer1.Enabled = true;
            btn_time.Text = DateTime.Now.ToString("H:mm:ss");

            // ToDoList settings
            if (!Directory.Exists(ToDo_path))
                Directory.CreateDirectory(ToDo_path);
            ShowToDoList();

        }
        private void btn_moodle_Click_1(object sender, EventArgs e)
        {
            string MA_path = "moodleAccount.txt";  // MA=moodle account
            if (File.Exists(MA_path))
            {
                string username, password;

                using (StreamReader sr = new StreamReader(MA_path))
                {
                    username = sr.ReadLine();
                    password = sr.ReadLine();
                }

                if (webpage_number == 0)
                {
                    Login();
                    first_search = false;
                    webpage_number++;
                }
                else if (webpage_number == 1 && in_music_webpage)
                {
                    // 開新分頁
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    js.ExecuteScript("window.open();");

                    // 切換到新分頁
                    foreach (string handle in driver.WindowHandles)
                    {
                        driver.SwitchTo().Window(handle);

                        if (!driver.Url.Contains("music"))
                        {
                            // 找到包含 "music" 的窗口，進行操作
                            in_music_webpage = false;
                            break;
                        }
                    }
                    webpage_number++;
                }
                else if (webpage_number == 2)
                {
                    // 切換到新分頁
                    foreach (string handle in driver.WindowHandles)
                    {
                        driver.SwitchTo().Window(handle);

                        if (!driver.Url.Contains("music"))
                        {
                            // 找到不包含 "music" 的窗口，進行操作
                            in_music_webpage = false;
                            break;
                        }
                    }
                }

                driver.Navigate().GoToUrl("https://moodle.ncku.edu.tw/");
                Thread.Sleep(1000);
                which_webpage = "moodle";
                // 使用 XPath 或其他適當的定位方式
                try
                {
                    IWebElement usernameInput = driver.FindElement(By.Id("login_username"));
                    usernameInput.Click();
                    usernameInput.Clear();
                    usernameInput.SendKeys(username);

                    IWebElement passwordInput = driver.FindElement(By.Id("login_password"));
                    passwordInput.Click();
                    passwordInput.Clear();
                    passwordInput.SendKeys(password);

                    IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/section[2]/aside/section[1]/div/div/form/div[4]/input"));
                    LoginButton.Click();
                }
                catch (Exception) { }
            }

        }
        private void btn_Instagram_Click(object sender, EventArgs e)
        {
            if (webpage_number == 0)
            {
                Login();
                first_search = false;
                webpage_number++;
            }
            else if (webpage_number == 1 && in_music_webpage)
            {
                // 開新分頁
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.open();");

                // 切換到新分頁
                foreach (string handle in driver.WindowHandles)
                {
                    driver.SwitchTo().Window(handle);

                    if (!driver.Url.Contains("music"))
                    {
                        // 找到包含 "music" 的窗口，進行操作
                        in_music_webpage = false;
                        break;
                    }
                }
                webpage_number++;
            }
            else if (webpage_number == 2)
            {
                // 切換到新分頁
                foreach (string handle in driver.WindowHandles)
                {
                    driver.SwitchTo().Window(handle);

                    if (!driver.Url.Contains("music"))
                    {
                        // 找到不包含 "music" 的窗口，進行操作
                        in_music_webpage = false;
                        break;
                    }
                }
            }
            // 進入 Instagram 網站
            driver.Navigate().GoToUrl("https://www.instagram.com/");
            which_webpage = "instagram";
            if (!use_profile)
            {
                IWebElement usernameInput = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/main/article/div[2]/div[1]/div[2]/form/div/div[1]/div/label/input"));
                usernameInput.SendKeys("yayachien1234@gmail.com");
                IWebElement passwordInput = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/main/article/div[2]/div[1]/div[2]/form/div/div[2]/div/label/input"));
                passwordInput.SendKeys("Jonathan911020");
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/main/article/div[2]/div[1]/div[2]/form/div/div[3]/button"));
                loginButton.Click();
                Thread.Sleep(5000);
            }
        }

        private void LoadButtonsFromTextFile()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    // 讀取 shortcut.txt 的所有行
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 2)
                        {
                            string buttonText = parts[0];
                            string buttonUrl = parts[1];
                            Button newButton = CreateButton(buttonText, buttonUrl);
                            panel3.Controls.Add(newButton);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}");
                }
            }
        }
        public Button CreateButton(string buttonText, string buttonUrl)
        {
            // 創建一個新的按鈕
            Button newButton = new Button();
            newButton.Text = buttonText;
            newButton.Size = new Size(108, 42);
            newButton.Location = new Point(0, 118 + i * 32); // 設定按鈕左上角的位置
            i++;
            newButton.Font = new Font("Niagara Engraved", 16, FontStyle.Regular);
            newButton.Click += (s, args) => GotoWebpage(buttonUrl);
            // 設定FlatStyle為Flat
            newButton.FlatStyle = FlatStyle.Flat;

            // 設定FlatAppearance的相關屬性
            newButton.FlatAppearance.BorderSize = 0;
            newButton.FlatAppearance.MouseDownBackColor = Color.Turquoise;
            newButton.FlatAppearance.MouseOverBackColor = Color.Turquoise;

            // 創建 CheckBox
            CheckBox checkBox = new CheckBox();
            checkBox.Size = new Size(15, 15);
            checkBox.Text = "";
            checkBox.Visible = false;

            // 設定 CheckBox 的位置，相對於按鈕的右側 10 單位
            checkBox.Location = new Point(5, 100 + i * 32);

            // 將按鈕和 CheckBox 添加到 panel3 中
            buttonsList.Add(newButton);
            panel3.Controls.Add(newButton);
            panel3.Controls.Add(checkBox);

            // 將按鈕和 CheckBox 關聯起來
            newButton.Tag = checkBox;

            return newButton;
        } //建立捷徑按鈕

        private void btn_DeleteButton_Click(object sender, EventArgs e)
        {
            if (firstTimebtn_DeleteButtonClick)
            {
                foreach (Button button in buttonsList)
                {
                    CheckBox checkBox = button.Tag as CheckBox;
                    if (checkBox != null)
                    {
                        checkBox.Visible = true;
                    }
                }
                firstTimebtn_DeleteButtonClick = false;
                return;
            }
            bool anyCheckBoxChecked = false;
            List<Button> buttonsToRemove = new List<Button>();

            foreach (Button button in buttonsList)
            {
                CheckBox checkBox = button.Tag as CheckBox;

                if (checkBox != null && checkBox.Checked)
                {
                    buttonsToRemove.Add(button);
                    DeleteButtonInfoFromTextFile(button);
                }
            }

            foreach (Button button in buttonsToRemove)
            {
                CheckBox checkBox = button.Tag as CheckBox;
                panel3.Controls.Remove(button);
                panel3.Controls.Remove(checkBox);
                buttonsList.Remove(button);
            }

            if (!anyCheckBoxChecked)
            {
                foreach (Button button in buttonsList)
                {
                    CheckBox checkBox = button.Tag as CheckBox;
                    if (checkBox != null)
                    {
                        checkBox.Visible = false;
                    }
                }
                firstTimebtn_DeleteButtonClick = true;
            }
        }
        private void DeleteButtonInfoFromTextFile(Button button)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            string buttonText = button.Text;
            string buttonUrl = button.Tag as string;
            string lineToRemove = lines.FirstOrDefault(line => line.StartsWith(buttonText));
            if (lines.Contains(lineToRemove))
            {
                lines.Remove(lineToRemove);
                File.WriteAllLines(filePath, lines);
            }
        }

        private void btn_Spotify_Click(object sender, EventArgs e)
        {
            if (webpage_number == 0)
            {
                Login();
                first_search = false;
                webpage_number++;
            }
            else if (webpage_number == 1 && in_music_webpage)
            {
                // 開新分頁
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.open();");

                // 切換到新分頁
                foreach (string handle in driver.WindowHandles)
                {
                    driver.SwitchTo().Window(handle);

                    if (!driver.Url.Contains("music"))
                    {
                        // 找到包含 "music" 的窗口，進行操作
                        in_music_webpage = false;
                        break;
                    }
                }
                webpage_number++;
            }
            else if (webpage_number == 2)
            {
                // 切換到新分頁
                foreach (string handle in driver.WindowHandles)
                {
                    driver.SwitchTo().Window(handle);

                    if (!driver.Url.Contains("music"))
                    {
                        // 找到不包含 "music" 的窗口，進行操作
                        in_music_webpage = false;
                        break;
                    }
                }
            }
            which_webpage = "spotify";
            driver.Navigate().GoToUrl("https://open.spotify.com/");
        }

        private void OtherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            Form1_Load_1(null, null);
        }

        public void btn_AddSchedule_Click(object sender, EventArgs e)
        {
            CalendarForm calendarForm = new CalendarForm();
            calendarForm.Show();
            calendarForm.FormClosed += OtherForm_FormClosed;
            this.Hide();

            int x = lbl_today.Location.X;
            int y = lbl_today.Location.Y + lbl_today.Height + 10;
            ShowPlans(x, y);
        }
        public void GotoWebpage(string url)
        {
            if (webpage_number == 0)
            {
                Login();
                first_search = false;
                webpage_number++;
            }
            else if (webpage_number == 1 && in_music_webpage)
            {
                // 開新分頁
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.open();");

                // 切換到新分頁
                foreach (string handle in driver.WindowHandles)
                {
                    driver.SwitchTo().Window(handle);

                    if (!driver.Url.Contains("music"))
                    {
                        // 找到包含 "music" 的窗口，進行操作
                        in_music_webpage = false;
                        break;
                    }
                }
                webpage_number++;
            }
            else if (webpage_number == 2)
            {
                // 切換到新分頁
                foreach (string handle in driver.WindowHandles)
                {
                    driver.SwitchTo().Window(handle);

                    if (!driver.Url.Contains("music"))
                    {
                        // 找到不包含 "music" 的窗口，進行操作
                        in_music_webpage = false;
                        break;
                    }
                }
            }
            driver.Navigate().GoToUrl(url);
        }
        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.form1 = this;
            this.Hide();
            form2.Show();
            form2.FormClosed += OtherForm_FormClosed;
        }

        private void ShowPlans(int x, int y)
        {
            string today = DateTime.Now.ToString("yyyyMd");

            string datePlan_path = Path.Combine(@"..\..\calendar\", today);

            if (Directory.Exists(datePlan_path))
            {
                string[] plans_path = Directory.GetFiles(datePlan_path);

                foreach (string plan_path in plans_path)
                {
                    StreamReader sr = new StreamReader(plan_path);

                    string plan = sr.ReadToEnd();

                    // 設定顯示行事曆
                    TextBox tbx_plan = new TextBox();
                    tbx_plan.Size = new Size(300, 40);
                    tbx_plan.Multiline = true;
                    tbx_plan.Text = plan;
                    tbx_plan.Location = new Point(x, y);
                    tbx_plan.ReadOnly = true;
                    tbx_plan.Font = new Font("Microsoft Sans Serif", 15F);
                    panel_schedule.Controls.Add(tbx_plan);

                    y += (tbx_plan.Size.Height + 10);

                    sr.Close();
                }
            }

        }

        private void cbx_wtLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            weather.Location = cbx_wtLocation.SelectedItem as string;

            lbl_weather.Text = string.Format("{0} {1} {2} {3} {4} {5}",
                weather.Wx, weather.PoP, weather.Temperature, weather.CI, weather.Wind, weather.RH);
        }

        private void btn_ConvertFile_Click(object sender, EventArgs e)
        {
            ConvertFileForm convertFileForm = new ConvertFileForm();
            this.Hide();
            convertFileForm.Show();
            convertFileForm.FormClosed += OtherForm_FormClosed;
        }

        private void Login()
        {

            if (first_login)
            {
                // ChromeDriver Setting
                string driverPath = @"chromedriver.exe";
                ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(driverPath);
                chromeDriverService.HideCommandPromptWindow = true;
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--user-data-dir=" + profile_path);
                options.AddArgument("--start-maximized");
                driver = new ChromeDriver(chromeDriverService, options);
                Thread.Sleep(1000);
                first_login = false;
            }
        }

        private void Get_Profile()
        {
            // ChromeDriver Setting
            string driverPath = @"chromedriver.exe";
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(driverPath);
            chromeDriverService.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(chromeDriverService, options);
            Thread.Sleep(500);
            driver.Navigate().GoToUrl("chrome://version");
            // 找到 id 為 "profile_path" 的元素
            IWebElement profilePathElement = driver.FindElement(By.Id("profile_path"));

            // 獲取元素的文字內容
            profile_path = profilePathElement.Text; ;
            Thread.Sleep(500);
            // 找到 \Local\ 之前的部分
            int localIndex = profile_path.IndexOf(@"\Temp\");
            string prefix = profile_path.Substring(0, localIndex);

            // 組合新的路徑
            string result = Path.Combine(prefix, "Google", "Chrome", "User Data");

            // 替換反斜線為正斜線
            result = result.Replace("\\", "/");

            // 加上磁碟機名稱
            //result = "C:" + result;

            Console.WriteLine(result);
            profile_path = result;

            // 將文字存儲到 profile_path 變數中
            Thread.Sleep(500);
            driver.Quit();
            catch_profile = false;

        }
        // Music Area
        private void btn_Search_Click(object sender, EventArgs e)
        {

            if (!in_music_webpage && webpage_number == 0)
            {
                Login();
                driver.Navigate().GoToUrl("https://music.youtube.com/");
                in_music_webpage = true;
                webpage_number++;
            }
            else if (!in_music_webpage && webpage_number == 2)
            {
                foreach (string handle in driver.WindowHandles)
                {
                    driver.SwitchTo().Window(handle);

                    if (driver.Url.Contains("music"))
                    {
                        // 找到包含 "music" 的窗口，進行操作
                        in_music_webpage = true;
                        break;
                    }
                }
                driver.Navigate().Back();
                in_music_webpage = true;

            }
            else if (!in_music_webpage && webpage_number == 1)
            {
                // 開新分頁
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.open();");
                webpage_number++;
                // 切換到新分頁
                foreach (string handle in driver.WindowHandles)
                {
                    driver.SwitchTo().Window(handle);

                    if (driver.Url.Contains("music"))
                    {
                        // 找到包含 "music" 的窗口，進行操作
                        in_music_webpage = true;
                        break;
                    }
                }
                driver.Navigate().GoToUrl("https://music.youtube.com/");
                in_music_webpage = true;

                // 現在你可以在新的分頁上進行操作
            }

            IWebElement searchInput = driver.FindElement(By.XPath("/html/body/ytmusic-app/ytmusic-app-layout/ytmusic-nav-bar/div[2]"));
            searchInput.Click();
            searchInput = driver.FindElement(By.XPath("/html/body/ytmusic-app/ytmusic-app-layout/ytmusic-nav-bar/div[2]/ytmusic-search-box/div/div[1]/input"));
            searchInput.SendKeys(tbx_Search.Text);
            searchInput.SendKeys(OpenQA.Selenium.Keys.Enter);

            Thread.Sleep(1000);
            IWebElement videoTitle = driver.FindElement(By.XPath("/html/body/ytmusic-app/ytmusic-app-layout/div[4]/ytmusic-search-page/ytmusic-tabbed-search-results-renderer/div[2]/ytmusic-section-list-renderer/div[2]/ytmusic-card-shelf-renderer/div/div[2]/div[1]/div/div[2]/div[2]/yt-button-renderer[1]/yt-button-shape/button/yt-touch-feedback-shape/div/div[2]"));
            videoTitle.Click();
            tbx_Search.Text = "please enter song name";
            Thread.Sleep(500);
            foreach (string handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);

                if (!driver.Url.Contains("music"))
                {
                    // 找到包含 "music" 的窗口，進行操作
                    if (webpage_number == 1 && in_music_webpage)
                    {

                    }
                    else
                    {
                        in_music_webpage = false;
                    }

                    break;
                }
            }
            driver.Manage().Window.Minimize();
        }
        private void Goto_Music()
        {
            foreach (string handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);

                if (driver.Url.Contains("music"))
                {
                    // 找到包含 "music" 的窗口，進行操作
                    in_music_webpage = true;
                    break;
                }
            }
        }
        private void btn_playStop_Click(object sender, EventArgs e)
        {
            Goto_Music();

            IWebElement PlayOrStop = driver.FindElement(By.XPath("/html/body/ytmusic-app/ytmusic-app-layout/ytmusic-player-bar/div[1]/div/tp-yt-paper-icon-button[3]/tp-yt-iron-icon"));
            PlayOrStop.Click();
            foreach (string handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);

                if (!driver.Url.Contains("music"))
                {
                    // 找到包含 "music" 的窗口，進行操作
                    if (webpage_number == 1 && in_music_webpage)
                    {

                    }
                    else
                    {
                        in_music_webpage = false;
                    }

                    break;
                }
            }
            driver.Manage().Window.Minimize();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            foreach (string handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);

                if (driver.Url.Contains("music"))
                {
                    // 找到包含 "music" 的窗口，進行操作
                    in_music_webpage = true;
                    break;
                }
            }

            IWebElement Next = driver.FindElement(By.XPath("/html/body/ytmusic-app/ytmusic-app-layout/ytmusic-player-bar/div[1]/div/tp-yt-paper-icon-button[5]/tp-yt-iron-icon"));
            Next.Click();
            foreach (string handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);

                if (!driver.Url.Contains("music"))
                {
                    // 找到包含 "music" 的窗口，進行操作
                    if (webpage_number == 1 && in_music_webpage)
                    {

                    }
                    else
                    {
                        in_music_webpage = false;
                    }

                    break;
                }
            }
            driver.Manage().Window.Minimize();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            foreach (string handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);

                if (driver.Url.Contains("music"))
                {
                    // 找到包含 "music" 的窗口，進行操作
                    in_music_webpage = true;
                    break;
                }
            }

            IWebElement Back = driver.FindElement(By.XPath("/html/body/ytmusic-app/ytmusic-app-layout/ytmusic-player-bar/div[1]/div/tp-yt-paper-icon-button[1]/tp-yt-iron-icon"));
            Back.Click();
            foreach (string handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);

                if (!driver.Url.Contains("music"))
                {
                    // 找到包含 "music" 的窗口，進行操作
                    if (webpage_number == 1 && in_music_webpage)
                    {

                    }
                    else
                    {
                        in_music_webpage = false;
                    }

                    break;
                }
            }
            driver.Manage().Window.Minimize();
        }

        private void tbx_Search_MouseClick(object sender, MouseEventArgs e)
        {
            tbx_Search.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btn_time.Text = DateTime.Now.ToString("H:mm:ss");

            foreach (Button alarm in clockForm.btn_alarms)
            {
                if ((int)alarm.Tag == 1 && alarm.Text.Equals(DateTime.Now.ToString("H:m")))
                {
                    alarm.Tag = 0;
                    RingAlarm();
                }
            }
        }

        private void btn_time_Click(object sender, EventArgs e)
        {
            clockForm = new ClockForm();
            clockForm.FormClosed += OtherForm_FormClosed;
            clockForm.Show();
            this.Hide();
        }

        private void RingAlarm()
        {
            SoundPlayer alarm = new SoundPlayer();
            alarm.SoundLocation = "alarm.wav";
            alarm.Load();
            alarm.Play();
        }

        private void btn_SetAccount_Click(object sender, EventArgs e)
        {
            SetAccountForm saf = new SetAccountForm();
            saf.FormClosed += OtherForm_FormClosed;
            saf.Show();
            this.Hide();
        }

        private void btn_AddToDo_Click(object sender, EventArgs e)
        {
            ToDoListForm tdlf = new ToDoListForm();
            tdlf.FormClosed += OtherForm_FormClosed;
            tdlf.Show();
            this.Hide();
        }

        private void ShowToDoList()
        {
            int x = lbl_ToDoList.Location.X;
            int y = lbl_ToDoList.Location.Y + lbl_ToDoList.Height + 10;

            foreach (Button todo in btn_ToDoList)
            {
                panel5.Controls.Remove(todo);
            }
            btn_ToDoList.Clear();

            string[] things = Directory.GetFiles(ToDo_path);

            foreach (string thing in things)
            {
                using (StreamReader sr = new StreamReader(thing))
                {
                    Button todo = new Button();
                    todo.Text = sr.ReadToEnd();
                    todo.Location = new Point(x, y);
                    todo.Size = new Size(300, 40);
                    todo.Tag = thing;
                    todo.BackColor = Color.WhiteSmoke;
                    todo.Font = new Font("Microsoft Sans Serif", 15F);
                    todo.TextAlign = ContentAlignment.MiddleLeft;
                    todo.Click += new EventHandler(btn_ToDo_Click);
                    panel5.Controls.Add(todo);
                    btn_ToDoList.Add(todo);
                }

                y += 50;
            }
        }

        private void btn_ToDo_Click(Object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("該事項已完成?", "To-Do List",
                MessageBoxButtons.OKCancel);
            if (DialogResult.OK == result)
            {
                Button thing = (Button)sender;

                try
                {
                    File.Delete(thing.Tag as string);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("File Delete error");
                    Debug.WriteLine(ex.ToString());
                }

                ShowToDoList();
            }
        }

        private void cbx_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (weather.getCityData(cbx_city.SelectedItem as string))
            {
                cbx_wtLocation.Text = "";
                cbx_wtLocation.Items.Clear();
                cbx_wtLocation.Items.AddRange(weather.Locations.ToArray());
                Debug.WriteLine(cbx_city.SelectedItem as string + "weather");
                Debug.WriteLine("get weather locations success");
            }
            else
            {
                Debug.WriteLine(cbx_city.SelectedText + "weather");
                Debug.WriteLine("get weather locations fail");
            }
            lbl_weather.Text = "";
        }
    }
}
