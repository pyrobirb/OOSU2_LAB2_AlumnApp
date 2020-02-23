using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainAlumnForm : Form
    {
        BusinessManager bm = new BusinessManager();
        public MainAlumnForm()
        {
            InitializeComponent();
        }

        private void tabControlAlumn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void raderaKontoAlumnBtn_Click(object sender, EventArgs e)
        {
            var alumnatttabort = (Alumn)bm.uiw.AlumnRepository.GetById((GLOBALS.inloggadAlumn).AnvändarID);
                bm.uiw.AlumnRepository.Remove(alumnatttabort);
            MessageBox.Show("Ditt konto är nu borttaget" );
            bm.Commit();

        }
    }
}
