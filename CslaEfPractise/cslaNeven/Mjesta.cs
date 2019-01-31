using BusinessLayer;
using Csla;
using System;
using System.Text;
using System.Windows.Forms;

namespace cslaNeven
{
    public partial class Mjesta : BaseFormExtended
    {
        public Mjesta()
        {
            InitializeComponent();
            Lista_Mjesta();
        }

        private void Mjesta_Load(object sender, EventArgs e)
        {

        }

        private void Lista_Mjesta()
        {
            try
            {
                MjestaInfoListBO.DataSource = MjestaInfoList.GetMjestaInfoList();
                MjestaInfoListBO.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
