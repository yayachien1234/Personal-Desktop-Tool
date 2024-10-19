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

namespace final_project_test
{
    public partial class SetAccountForm : Form
    {
        public SetAccountForm()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string path = "moodleAccount.txt";
            if(!File.Exists(path))
                File.Create(path);
            using(StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(tbx_username.Text);
                sw.WriteLine(tbx_password.Text);
            }
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
