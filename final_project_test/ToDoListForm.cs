using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project_test
{
    public partial class ToDoListForm : Form
    {
        private static string ToDo_path = @"..\..\ToDo\";

        public ToDoListForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!tbx_ToDo.Text.Equals(""))
            {
                try
                {
                    int files = 0;
                    string filePath;
                    do
                    {
                        files++;
                        string fileName = "ToDo" + files + ".txt";
                        filePath = Path.Combine(ToDo_path, fileName);
                    } while (File.Exists(filePath));

                    File.Create(filePath).Close();

                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.Write(tbx_ToDo.Text);
                    }

                    lbl_add.ForeColor = Color.LightGreen;
                    lbl_add.Text = "新增成功";

                    tbx_ToDo.Text = "";
                }
                catch (Exception ex)
                {
                    lbl_add.ForeColor = Color.Red;
                    lbl_add.Text = "新增失敗";
                    Debug.WriteLine(ex.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToDoListForm_Load(object sender, EventArgs e)
        {
            lbl_add.Text = "";
        }

        private void tbx_ToDo_Click(object sender, EventArgs e)
        {
            lbl_add.Text = "";
        }
    }
}
