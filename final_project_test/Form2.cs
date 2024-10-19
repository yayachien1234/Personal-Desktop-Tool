using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace final_project_test
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }
        // 定義一個事件，當button1被按下時觸發
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 如果 Form2 關閉時要顯示 Form1，可以透過委派方式來執行 Form1 的顯示
            (Owner as Form1)?.Show();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button newButton = form1.CreateButton(textBox1.Text, textBox2.Text);
            form1.panel3.Controls.Add(newButton);
            string lineToAdd = $"\n{textBox1.Text} | {textBox2.Text}";

            // 使用StreamWriter將新行添加到shortcut.txt
            using (StreamWriter writer = File.AppendText("shortcut.txt"))
            {
                writer.WriteLine(lineToAdd);
            }
            this.Close();
        }//按下新增捷徑按鈕

    }
}
