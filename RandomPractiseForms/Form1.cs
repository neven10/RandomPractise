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


    }
}
