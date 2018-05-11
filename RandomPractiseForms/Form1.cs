using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPractiseForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        void ListToMbox()
        {
            string[] names = { "1", "2", "3" };
            string s = string.Join(",", names);
            MessageBox.Show(s);
        }

        void ToolTipFloat()
        {
            var tip = new ToolTip();
            tip.SetToolTip(this, "a");
        }

        void FileExplore()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                
            }
        }

        void AutoRunStartup()
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("App", Application.ExecutablePath.ToString());
            MessageBox.Show("You have been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        void TrayNotify()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                //Show ballon tip
                notifyIcon1.ShowBalloonTip(1000, "Important notice", "Something important has come up. Click this to know more.", ToolTipIcon.Info);
            }
        }

    }
}
