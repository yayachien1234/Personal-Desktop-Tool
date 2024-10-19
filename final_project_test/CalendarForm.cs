using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace final_project_test
{
    public partial class CalendarForm : Form
    {
        public CalendarForm()
        {
            InitializeComponent();
        }

        List<TextBox> tbx_plans = new List<TextBox>();
        List<Button> btn_upgrades = new List<Button>();
        List<Button> btn_deletes = new List<Button>();
        List<Button> btn_confirms = new List<Button>();
        List<Button> btn_cancels = new List<Button>();
        string[] plans_path;
        string old_plan;
        string datePlan_path;

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            addPlanMessage.Text = "";

            string calendar_path = @"..\..\calendar\";
            if (!Directory.Exists(calendar_path))
                Directory.CreateDirectory(calendar_path);

            string today = DateTime.Now.ToString("yyyyMd");

            datePlan_path = Path.Combine(@"..\..\calendar\", today);

            if (Directory.Exists(datePlan_path))
            {
                ShowPlans();
            }
            else
            {
                HidePlans();
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            String selected_date = e.Start.ToShortDateString();
            selected_date = selected_date.Replace("/", "");

            datePlan_path = Path.Combine(@"..\..\calendar\", selected_date);

            if (Directory.Exists(datePlan_path))
            {
                ShowPlans();
            }
            else
            {
                HidePlans();
            }
        }

        private void addPlanButton_Click(object sender, EventArgs e)
        {
            // 新增計畫按鈕被點擊時觸發事件
            string planDate = monthCalendar1.SelectionRange.Start.ToShortDateString();
            string planText = planTextBox.Text;

            planDate = planDate.Replace("/", "");

            if (!string.IsNullOrEmpty(planText))
            {
                datePlan_path = Path.Combine(@"..\..\calendar\", planDate);
                if (!Directory.Exists(datePlan_path))
                {
                    Directory.CreateDirectory(datePlan_path);
                }

                // create file
                string filePath;
                int files = Directory.GetFiles(datePlan_path).Length;
                do
                {
                    files++;
                    string fileName = planDate + "_plan" + files + ".txt";
                    filePath = Path.Combine(datePlan_path, fileName);
                } while (File.Exists(filePath));
                FileInfo finfo = new FileInfo(filePath);
                Directory.CreateDirectory(finfo.DirectoryName);

                // write text into file
                StreamWriter sw = finfo.CreateText();
                sw.Write(planText);
                sw.Flush();
                sw.Close();

                // 顯示計畫訊息
                addPlanMessage.ForeColor = Color.Black;
                addPlanMessage.Text = $"已新增計畫：\n日期：{planDate}\n計畫內容：{planText}";

                // clear textbox
                planTextBox.Text = "";

                ShowPlans();
            }
            else
            {
                // 提示使用者輸入計畫內容
                addPlanMessage.ForeColor = Color.Red;
                addPlanMessage.Text = "請輸入計畫內容。";
            }
        }

        private void btn_upgrade_Click(object sender, EventArgs e)
        {
            int i = btn_upgrades.IndexOf(sender as Button);

            if (tbx_plans[i].ReadOnly)
            {
                btn_cancel_Click(null, null);

                old_plan = tbx_plans[i].Text;

                tbx_plans[i].ReadOnly = false;

                btn_confirms[i].Enabled = true;
                btn_confirms[i].Visible = true;
                btn_cancels[i].Enabled = true;
                btn_cancels[i].Visible = true;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int i = btn_deletes.IndexOf(sender as Button);

            File.Delete(plans_path[i]);
            MessageBox.Show("刪除成功!");

            ShowPlans();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            int i = btn_confirms.IndexOf(sender as Button);

            tbx_plans[i].ReadOnly = true;

            FileInfo finfo_new = new FileInfo(plans_path[i]);
            StreamWriter sw = finfo_new.CreateText();

            sw.Write(tbx_plans[i].Text);
            sw.Flush();
            sw.Close();

            btn_confirms[i].Enabled = false;
            btn_confirms[i].Visible = false;

            btn_cancels[i].Enabled = false;
            btn_cancels[i].Visible = false;

            MessageBox.Show("更新成功");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // turn off all upgrade
            for (int i = 0; i < tbx_plans.Count; i++)
            {
                btn_confirms[i].Enabled = false;
                btn_confirms[i].Visible = false;

                btn_cancels[i].Enabled = false;
                btn_cancels[i].Visible = false;

                if (!tbx_plans[i].ReadOnly)
                    tbx_plans[i].Text = old_plan;
                tbx_plans[i].ReadOnly = true;
            }
        }

        // show plans
        private void ShowPlans()
        {
            HidePlans();

            plans_path = Directory.GetFiles(datePlan_path);

            int x = 340, y = 50;

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
                Controls.Add(tbx_plan);
                tbx_plans.Add(tbx_plan);

                // setting upgrade button
                Button btn_upgrade = new Button();
                btn_upgrade.Location = new Point(670, y);
                btn_upgrade.Size = new Size(50, 40);
                btn_upgrade.Text = "修改";
                btn_upgrade.Click += new EventHandler(btn_upgrade_Click);
                Controls.Add(btn_upgrade);
                btn_upgrades.Add(btn_upgrade);

                // setting delete button
                Button btn_delete = new Button();
                btn_delete.Location = new Point(730, y);
                btn_delete.Size = new Size(50, 40);
                btn_delete.Text = "刪除";
                btn_delete.Click += new EventHandler(btn_delete_Click);
                Controls.Add(btn_delete);
                btn_deletes.Add(btn_delete);

                // setting confirm button
                Button btn_confirm = new Button();
                btn_confirm.Location = new Point(790, y);
                btn_confirm.Size = new Size(50, 40);
                btn_confirm.Text = "確定";
                btn_confirm.Enabled = false;
                btn_confirm.Visible = false;
                btn_confirm.Click += new EventHandler(btn_confirm_Click);
                Controls.Add(btn_confirm);
                btn_confirms.Add(btn_confirm);

                // setting cancel button
                Button btn_cancel = new Button();
                btn_cancel.Location = new Point(850, y);
                btn_cancel.Size = new Size(50, 40);
                btn_cancel.Text = "取消";
                btn_cancel.Enabled = false;
                btn_cancel.Visible = false;
                btn_cancel.Click += new EventHandler(btn_cancel_Click);
                Controls.Add(btn_cancel);
                btn_cancels.Add(btn_cancel);

                y += (tbx_plan.Size.Height + 10);

                sr.Close();
            }

        }

        private void HidePlans()
        {
            // hide plans
            for (int i = 0; i < tbx_plans.Count; i++)
            {
                Controls.Remove(tbx_plans[i]);
                Controls.Remove(btn_upgrades[i]);
                Controls.Remove(btn_deletes[i]);
                Controls.Remove(btn_confirms[i]);
                Controls.Remove(btn_cancels[i]);
            }

            tbx_plans.Clear();
            btn_upgrades.Clear();
            btn_deletes.Clear();
            btn_confirms.Clear();
            btn_cancels.Clear();
        }
    }
}
