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
    public partial class CreateUserForm : Form
    {
        BusinessManager bm = new BusinessManager();

        public CreateUserForm()
        {
            InitializeComponent();
            alumnRadioBtn.Checked = true;
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {

        }

        private void alumnRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void adminRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void skapaKontoBtn_Click(object sender, EventArgs e)
        {
            if (alumnRadioBtn.Checked == true)
                SkapaKontoAlumn();

            if (personalRadioBtn.Checked == true)
                SkapaKontoPersonal();

            DialogResult = DialogResult.OK;
        }

        private void avbrytBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void SkapaKontoAlumn()
        {
            if (användarNamnTextBox.Text != "" && lösenordTextBox.Text != "")
            {

                bm.LäggTillAlumn(new Alumn()
                {
                    Användarnamn = användarNamnTextBox.Text,
                    Förnamn = förnamnTextBox.Text,
                    Efternamn = efternamnTextBox.Text,
                    Epost = epostTextBox.Text,
                    Lösenord = lösenordTextBox.Text

                });
            }
            MessageBox.Show("Hej " + förnamnTextBox.Text + "! Ditt nya Alumn-konto är nu skapat, nu kan du logga in!");
        }

        public void SkapaKontoPersonal()
        {
            if (användarNamnTextBox.Text != "" && lösenordTextBox.Text != "")
            {

                bm.LäggTillPersonal(new Personal()
                {
                    Användarnamn = användarNamnTextBox.Text,
                    Förnamn = förnamnTextBox.Text,
                    Efternamn = efternamnTextBox.Text,
                    Epost = epostTextBox.Text,
                    Lösenord = lösenordTextBox.Text
                });
            }
            MessageBox.Show("Hej " + förnamnTextBox.Text + "! Ditt nya Personal-konto är nu skapat, nu kan du logga in!");
        }
    }
}
