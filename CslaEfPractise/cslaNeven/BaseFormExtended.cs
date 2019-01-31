using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cslaNeven
{
    public partial class BaseFormExtended : BaseForm
    {
        public BaseFormExtended()
        {
            InitializeComponent();


            btn_Dodaj.Click += (s, e) => Dodaj();
            btn_Izmjeni.Click += (s, e) => Izmjeni();
            btn_Snimi.Click += (s, e) => Snimi();
            btn_Obrisi.Click += (s, e) => Obrisi();
            btn_Ponisti.Click += (s, e) => Cancel();
            Load += (s, e) => LoadControls();



        }

        private void BaseFormExtended_Load(object sender, EventArgs e)
        {

        }
        protected virtual void LoadControls()
        {
            DisableControls(true);
            ToogleToolbar(true);



        }
        private void ToogleToolbar(bool state)
        {
            btn_Dodaj.Enabled = state;
            btn_Izmjeni.Enabled = state;
            btn_Snimi.Enabled = !state;
            btn_Obrisi.Enabled = state;
        }


        private void DisableControls(bool state)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox || ctrl is NumericUpDown)
                    ctrl.Enabled = !state;
            }
        }

        protected virtual void Dodaj()
        {
            DisableControls(false);
            ToogleToolbar(false);
        }
        protected virtual void Izmjeni()
        {
            ToogleToolbar(false);
            DisableControls(false);
        }
        protected virtual void Snimi()
        {
            ToogleToolbar(true);
            DisableControls(true);
        }
        protected virtual void Obrisi()
        {
            ToogleToolbar(true);
            DisableControls(true);
        }
        protected virtual void Cancel()
        {
            ToogleToolbar(true);
            DisableControls(true);
        }
        


    }
}
