using System;
using BusinessLayer;
using Csla;
using MetroFramework.Forms;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace cslaNeven
{


    public partial class PhabisUI : MetroForm
    {
        private ArtiklEdit artikl;


        public PhabisUI()
        {
            InitializeComponent();
            Lista_Artikl();



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer_info(true);
        }

        #region Liste
        private void Lista_Artikl()
        {
            try
            {
                ArtiklInfoListBS.DataSource = ArtiklInfoList.GetArtiklInfoList();
                ArtiklInfoListBS.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Lista_Fond()
        {
            try
            {
                fondInfoListBindingSource.DataSource = FondInfoList.GetFondInfoList();
                fondInfoListBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Left Vertical Navigation Tab Control


        private void btn_ulaz_robe_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 0;
        }

        private void btn_kasa_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 1;
        }

        private void btn_nivelacije_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 2;
        }

        private void btn_prenosnice_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 3;
        }
        private void btn_artikli_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 4;
        }
        private void btn_blagajna_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 5;
        }
        private void btn_recepti_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 6;
        }

        private void FondtoolStrip_Click(object sender, EventArgs e)
        {
            FondUI f = new FondUI();
            f.ShowDialog();
        }

        #endregion

        #region Junk
        private void metroTile1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Top Horizontal Navigation
        private void MjestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mjesta m = new Mjesta();
            m.ShowDialog();
        }
        #endregion

        #region Info Timer
        private void timer_info(bool state)
        {
            if (state)
            {
                label1.Text = "OBAVJESTENJE: Nova lista fonda stupa na snagu od 01.01.2018. - Izmjene su sledece : ************************  U meniju Servis, nalazi se ekran Nivelacija kod izmjene cijena na listi koji omogucava nivelaciju cijena za lijekove kojima se mijenja cijena na listi********";
                timer_obavjestenja.Start();
            }
            else
            {
                label1.Text = null;
                timer_obavjestenja.Stop();
            }
        }

        private void timer_info_tick(object sender, EventArgs e)
        {
            if (label1.Right > 0)
                label1.Left = label1.Left - 5;
            else if (label1.Right <= 0)
            {
                label1.Left = 107;


            }
        }

        private void strip_tile_Click(object sender, EventArgs e)
        {
            {
                timer_info(false);
            }

        }
        #endregion

        #region Seed Data
        private void btn_db_seed_Click(object sender, EventArgs e)
        {
            var seeder = new DataAccessLayer.Seeder();
            seeder.seedMjesta();
            seeder.seedFond();
        }
        #endregion

        #region Artikl

        private void btn_Dodaj_artikl_Click(object sender, EventArgs e)
        {
            artikl = ArtiklEdit.CreateArtiklEdit();
            ArtiklEditBS.DataSource = artikl;
            ArtiklEditBS.ResetBindings(false);
            txt_sifra_artikla.Focus();
        }

        private void btn_Snimi_artikl_Click(object sender, EventArgs e)
        {
            ArtiklEditBS.RaiseListChangedEvents = false;
            ArtiklEditBS.EndEdit();
            try
            {
                artikl = artikl.Save();
                Lista_Artikl();

            }
            catch (DataPortalException ex)
            {
                MessageBox.Show(ex.BusinessException.Message, "Snimi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            ArtiklEditBS.RaiseListChangedEvents = true;


        }

        private void btn_Izmjeni_artikl_Click(object sender, EventArgs e)
        {
            //TO DO
        }

        private void btn_Obrisi_artikl_Click(object sender, EventArgs e)
        {
            var select = ArtiklInfoListBS.Current as ArtiklInfo;
            if (select == null) return;

            if (MessageBox.Show("Da li ste sigurni?", "Potvrdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ArtiklEdit.DeleteArtiklEdit(select.Id);
                Lista_Artikl();
            }
        }

        private void btn_Ponisti_artikl_Click(object sender, EventArgs e)
        {
            //TO DO
            lbl_sifra_artikl.Focus();


        }

        private void combo_fond_Click(object sender, EventArgs e)
        {
            Lista_Fond();
        }

        #endregion
    }
}
