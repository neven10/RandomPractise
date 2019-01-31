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

namespace SimpleCRUD
{
    public partial class Form1 : MetroForm
    {
        mysqlController k;


        public Form1()
        {
            InitializeComponent();
            PuniRadnikGrid();
            PuniSektorCombo();
        }


        public void PuniRadnikGrid()
        {
            k = new mysqlController();
            grid_radnik.DataSource = k.Datatable("select * from tbl_radnik");
            grid_radnik.Refresh();
        }

        private void btn_insert_radnik_Click(object sender, EventArgs e)
        {

            k = new mysqlController();
            k.InsertUpdateDelete("insert into tbl_radnik (ime, prezime,maticni, sektorid) values (@ime, @prezime, @maticni, @sektorid)",
            new MySqlParameter("@ime", txt_ime.Text),
            new MySqlParameter("@prezime", txt_prezime.Text),
            new MySqlParameter("@maticni", txt_maticni.Text),
            new MySqlParameter("@sektorid", combo_sektor.SelectedValue));

            PuniRadnikGrid();

        }

        private void combo_sektor_Click(object sender, EventArgs e)
        {
            PuniSektorCombo();
        }

        public void PuniSektorCombo()
        {
            k = new mysqlController();
            combo_sektor.DataSource = k.Datatable("select id, sektor from tbl_sektor");
            combo_sektor.ValueMember = "id";
            combo_sektor.DisplayMember = "sektor";
        }

        private void grid_radnik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grid_radnik.Rows[e.RowIndex];
                txt_radnik_id.Text = row.Cells["id"].Value.ToString();
                txt_ime.Text = row.Cells["ime"].Value.ToString();
                txt_prezime.Text = row.Cells["prezime"].Value.ToString();
                txt_maticni.Text = row.Cells["maticni"].Value.ToString();
                combo_sektor.SelectedValue = row.Cells["sektorid"].Value.ToString();

            }
        }

        private void btn_update_radnik_Click(object sender, EventArgs e)
        {
            k.InsertUpdateDelete("update tbl_radnik set ime=@ime, prezime=@prezime, maticni = @maticni, sektorid = @sektorid where id=@id",
            new MySqlParameter("@ime", txt_ime.Text),
            new MySqlParameter("@prezime", txt_prezime.Text),
            new MySqlParameter("@maticni", txt_maticni.Text),
            new MySqlParameter("@sektorid", combo_sektor.SelectedValue),
            new MySqlParameter("@id", Convert.ToInt32(txt_radnik_id.Text)));
            PuniRadnikGrid();
        }

        private void btn_delete_radnik_Click(object sender, EventArgs e)
        {
            k = new mysqlController();
            k.InsertUpdateDelete("delete from tbl_radnik where id=@id",
            new MySqlParameter("@id", Convert.ToInt32(txt_radnik_id.Text)));

            PuniRadnikGrid();

        }
    }
}
