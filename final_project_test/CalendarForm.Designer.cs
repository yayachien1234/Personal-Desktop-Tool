namespace final_project_test
{
    partial class CalendarForm
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.addPlanButton = new System.Windows.Forms.Button();
            this.planTextBox = new System.Windows.Forms.TextBox();
            this.addPlanMessage = new System.Windows.Forms.Label();
            this.lbl_DatePlan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(10, 10);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // addPlanButton
            // 
            this.addPlanButton.AutoSize = true;
            this.addPlanButton.Font = new System.Drawing.Font("Mistral", 15F);
            this.addPlanButton.Location = new System.Drawing.Point(216, 220);
            this.addPlanButton.Name = "addPlanButton";
            this.addPlanButton.Size = new System.Drawing.Size(99, 40);
            this.addPlanButton.TabIndex = 1;
            this.addPlanButton.Text = "New Plan";
            this.addPlanButton.UseVisualStyleBackColor = true;
            this.addPlanButton.Click += new System.EventHandler(this.addPlanButton_Click);
            // 
            // planTextBox
            // 
            this.planTextBox.Location = new System.Drawing.Point(10, 220);
            this.planTextBox.Multiline = true;
            this.planTextBox.Name = "planTextBox";
            this.planTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.planTextBox.Size = new System.Drawing.Size(200, 40);
            this.planTextBox.TabIndex = 2;
            // 
            // addPlanMessage
            // 
            this.addPlanMessage.AutoSize = true;
            this.addPlanMessage.Location = new System.Drawing.Point(12, 275);
            this.addPlanMessage.MaximumSize = new System.Drawing.Size(100, 0);
            this.addPlanMessage.Name = "addPlanMessage";
            this.addPlanMessage.Size = new System.Drawing.Size(59, 15);
            this.addPlanMessage.TabIndex = 3;
            this.addPlanMessage.Text = " Message";
            // 
            // lbl_DatePlan
            // 
            this.lbl_DatePlan.AutoSize = true;
            this.lbl_DatePlan.Font = new System.Drawing.Font("Mistral", 15F);
            this.lbl_DatePlan.Location = new System.Drawing.Point(339, 10);
            this.lbl_DatePlan.Name = "lbl_DatePlan";
            this.lbl_DatePlan.Size = new System.Drawing.Size(124, 30);
            this.lbl_DatePlan.TabIndex = 4;
            this.lbl_DatePlan.Text = "Today\'s plan:";
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 450);
            this.Controls.Add(this.lbl_DatePlan);
            this.Controls.Add(this.addPlanMessage);
            this.Controls.Add(this.planTextBox);
            this.Controls.Add(this.addPlanButton);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "CalendarForm";
            this.Text = "行事曆";
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button addPlanButton;
        private System.Windows.Forms.TextBox planTextBox;
        private System.Windows.Forms.Label addPlanMessage;
        private System.Windows.Forms.Label lbl_DatePlan;
    }
}