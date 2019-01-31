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
using Dapper;

namespace DapperCRUD
{
    public partial class Form1 : MetroForm
    {
        EntityState state = EntityState.Unchanged;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PuniGridRadnik();
            PuniGridSektor();
        }


        public void ClearAll()
        {
            txt_radnik_id.Text = null;
            txt_ime.Text = null;
            txt_prezime.Text = null;
            txt_maticni.Text = null;
            combo_sektor.SelectedValue = -1;

        }

        public void PuniGridRadnik()
        {
            using (IDbConnection db = new MySqlConnection(Conn.ConnectionString))
            {
                db.Open();
                radnikBindingSource.DataSource = db.Query<radnik>("select * from tbl_radnik");
                panel1.Enabled = false;
            }
        }

        public void PuniGridSektor()
        {
            using (IDbConnection db = new MySqlConnection(Conn.ConnectionString))
            {
                db.Open();
                tblsektorBindingSource.DataSource = db.Query<tbl_sektor>("select * from tbl_sektor");
                panel1.Enabled = false;
            }
        }


    

        private void btn_insert_radnik_Click(object sender, EventArgs e)
        {
            state = EntityState.Added;
            panel1.Enabled = true;
            radnikBindingSource.Add(new radnik());
            radnikBindingSource.MoveLast();
            txt_ime.Focus();

        }

        private void combo_sektor_Click(object sender, EventArgs e)
        {
           
        }


        private void grid_radnik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_update_radnik_Click(object sender, EventArgs e)
        {
            state = EntityState.Changed;
            panel1.Enabled = true;
            txt_ime.Focus();
        }

        private void btn_delete_radnik_Click(object sender, EventArgs e)
        {

            state = EntityState.Deleted;

            using (IDbConnection db = new MySqlConnection(Conn.ConnectionString))
            {
                db.Open();
                radnik r = radnikBindingSource.Current as radnik;
                if (r != null)
                {
                    int result = db.Execute("delete from tbl_radnik where id=@id", new { id = r.id });
                    if(result !=0)
                    {
                        radnikBindingSource.RemoveCurrent();
                        panel1.Enabled = false;
                        state = EntityState.Unchanged;
                    }

                }

            }



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            radnikBindingSource.ResetBindings(false);
            ClearAll();
            PuniGridRadnik();
            PuniGridSektor();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            radnikBindingSource.EndEdit();
            radnik r = radnikBindingSource.Current as radnik;

            if(r != null)
            {
                using (IDbConnection db = new MySqlConnection(Conn.ConnectionString))
                {
                    db.Open();

                    if (state == EntityState.Added)
                    {
                        db.Execute("insert into tbl_radnik (ime, prezime, maticni, sektorid) values (@ime,@prezime,@maticni,@sektorid)",
                            new { ime = r.ime, prezime = r.prezime, maticni = r.maticni, sektorid = r.sektorid });
                    }
                    else if (state == EntityState.Changed)
                    {
                        db.Execute ("update tbl_radnik set ime=@ime, prezime=@prezime, maticni=@maticni, sektorid=@sektorid where id=@id",
                        new {id = r.id, ime = r.ime, prezime = r.prezime, maticni = r.maticni, sektorid = r.sektorid });
                    }

                    PuniGridRadnik();
                    state = EntityState.Unchanged;

                }

            }
        }
    }
}
