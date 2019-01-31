using BusinessLayer;
using Csla;
using System;
using System.Text;
using System.Windows.Forms;

namespace cslaNeven
{
    public partial class FondUI : BaseFormExtended 
    {
        private FondEdit fond;
        public FondUI()
        {
            InitializeComponent();


        }

        protected override void LoadControls()
        {
            Lista_Fond();
            base.LoadControls();
        }

        private void DisableControls(bool state)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox || ctrl is NumericUpDown)
                    ctrl.Enabled = !state;
            }
        }

        private void Lista_Fond()
        {
            try
            {
                FondInfoListBS.DataSource = FondInfoList.GetFondInfoList();
                FondInfoListBS.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FondGrid_SelectionChanged(object sender, EventArgs e)
        {
            //if (FondInfoListbindingSource.Current == null) return;
            //var select = FondInfoListbindingSource.Current as FondInfo;
            //FondEditbindingSource.DataSource = select;
        }


        protected override void Dodaj()
        {
            base.Dodaj();
            fond = FondEdit.CreateFondEdit();
            FondEditBS.DataSource = fond;
            FondEditBS.ResetBindings(false);
            txt_sifra_fond.Focus();

        }
        protected override void Izmjeni()
        {
            base.Izmjeni();
            try
            {
                if (FondInfoListBS.Current == null) return;
                var select = FondInfoListBS.Current as FondInfo;
                fond = FondEdit.GetFondEdit(select.Id);
                FondEditBS.DataSource = fond;
                fond.Id = select.Id;
                FondEditBS.ResetBindings(false);
                txt_sifra_fond.Focus();
            }
            catch (DataPortalException ex)
            {

                MessageBox.Show(ex.BusinessException.Message, "Izmjeni", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected override void Snimi()
        {
            
            FondEditBS.RaiseListChangedEvents = false;
            FondEditBS.EndEdit();
            try
            {
                if (!fond.IsValid)
                {
                    var errors = fond.BrokenRulesCollection;
                    StringBuilder sb = new StringBuilder();
                    foreach (var er in errors)
                    {
                        sb.AppendLine(er.Description);
                    }

                    MessageBox.Show(sb.ToString());
                    return;
                }


                    fond = fond.Save();
                base.Snimi();
                Lista_Fond();



            }
            catch (DataPortalException ex)
            {
                MessageBox.Show(ex.BusinessException.Message, "Snimi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            FondEditBS.RaiseListChangedEvents = true;






        }

        protected override void Obrisi()
        {
            base.Obrisi();
            var select = FondInfoListBS.Current as FondInfo;
            if (select == null) return;

            if (MessageBox.Show("Da li ste sigurni?", "Potvrdi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FondEdit.DeleteFondEdit(select.Id);
                Lista_Fond();
            }
        }
     

        protected override void Cancel()
        {
            Lista_Fond();
            base.Cancel();
            FondEditBS.CancelEdit();
            FondEditBS.ResetBindings(false);
            

        }

        private void FondUI_Load(object sender, EventArgs e)
        {

        }
    }
}
