using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace VSDataBinding
{
    public partial class Form1 : MetroForm
    {



        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simple_crudDataSet.tbl_sektor' table. You can move, or remove it, as needed.
            this.tbl_sektorTableAdapter.Fill(this.simple_crudDataSet.tbl_sektor);
            // TODO: This line of code loads data into the 'simple_crudDataSet.tbl_radnik' table. You can move, or remove it, as needed.
            this.tbl_radnikTableAdapter.Fill(this.simple_crudDataSet.tbl_radnik);

        }




        private void btn_insert_radnik_Click(object sender, EventArgs e)
        {

            tbl_radnikTableAdapter.Insert(txt_ime.Text, txt_prezime.Text, Convert.ToInt32(txt_maticni.Text), Convert.ToInt32(combo_sektor.SelectedValue));
            this.tbl_radnikTableAdapter.Fill(this.simple_crudDataSet.tbl_radnik);

        }

        private void combo_sektor_Click(object sender, EventArgs e)
        {
          
        }


        private void grid_radnik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_update_radnik_Click(object sender, EventArgs e)
        {

            this.Validate();
            tblradnikBindingSource.EndEdit();
            tbl_radnikTableAdapter.Update(simple_crudDataSet.tbl_radnik);
            tbl_radnikTableAdapter.Fill(simple_crudDataSet.tbl_radnik);
        }

        private void btn_delete_radnik_Click(object sender, EventArgs e)
        {

            tbl_radnikTableAdapter.Delete(Convert.ToInt32(txt_id.Text), txt_ime.Text, txt_prezime.Text, Convert.ToInt32(txt_maticni.Text), Convert.ToInt32(combo_sektor.SelectedValue));
            this.tbl_radnikTableAdapter.Fill(this.simple_crudDataSet.tbl_radnik);
        }


    }
}
