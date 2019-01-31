using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace EFModelFirst
{
    public partial class Form1 : Form
    {
        CrudModelContainer ctx;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctx = new CrudModelContainer();

            ctx.radniks.Load();
            ctx.sektors.Load();

            radnikBindingSource.DataSource = ctx.radniks.Local.ToBindingList();
            sektorBindingSource.DataSource = ctx.sektors.Local.ToBindingList();

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void radnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            radnikBindingSource.EndEdit();
            ctx.SaveChanges();
        }
    }
}
