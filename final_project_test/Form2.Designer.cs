using System.Drawing;
using System.Windows.Forms;

namespace final_project_test
{
    partial class Form2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 64);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 45);
            textBox1.TabIndex = 0;

            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 146);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 45);
            textBox2.TabIndex = 1;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 85);
            label1.Name = "label1";
            label1.Size = new Size(123, 24);
            label1.TabIndex = 2;
            label1.Text = "button的名字";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 167);
            label2.Name = "label2";
            label2.Size = new Size(118, 24);
            label2.TabIndex = 3;
            label2.Text = "要導入的網址";
            // 
            // button1
            // 
            button1.Location = new Point(332, 293);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "新增btn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 440);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        public TextBox textBox1;
        public TextBox textBox2;
        public Button button1;
    }
}