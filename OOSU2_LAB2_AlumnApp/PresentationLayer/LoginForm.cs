using BusinessEntities.Models;
using BusinessLayer;
using DataLayer.Contexts;
using DataLayer.Seed;
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
    public partial class LoginForm : Form
    {
        DatabaseContext akc = new DatabaseContext();
        BusinessManager bm = new BusinessManager();

        public LoginForm()
        {
            InitializeComponent();
            akc.Database.EnsureDeleted();
            akc.Database.EnsureCreated();
            AlumnKontaktSeed.Populate(akc);


        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vårt syfte med alumnappen är att erbjuda alumner från högskolan i Borås aktiviteter som till exempel gästföreläsningar eller aktiviteter för att träffa personer som gått samma utbildning samt ge oss en möjlighet att kontakta alumner ifall vi behöver till exempel gästföreläsare från arbetslivet. \nVid registreringen av kontot behöver du uppge epostadress och namn som kontaktuppgifter. Sedan kan du frivilligt registrera fler uppgifter om examina, certifikat etc. \nVill du ändra på personuppgifter eller ta bord ditt konto finns den möjligheten i appen. \n\nGodkänner du villkoren?", "Villkor enligt GDPR för AlumnAppen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CreateUserForm createUserForm = new CreateUserForm();
                createUserForm.ShowDialog();
            }
            else
            {
                Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            ValidateUserLogin(userNameTextBox.Text, passwordTextBox.Text);
            ValidateLogIn_OpenMainForm();
        }
        public void ValidateUserLogin(string username, string password)
        {
            bm.ControlLogin(username, password);

        }
        public void ValidateLogIn_OpenMainForm()
        {

            if (bm.loggedInAlumn != null || bm.loggedInPersonal != null)
            {

                if (bm.loggedInAlumn is Alumn)
                {
                    MainAlumnForm mainAlumnForm = new MainAlumnForm();
                    mainAlumnForm.Show();
                    this.Hide();
                }
                else if (bm.loggedInPersonal is Personal)
                {
                    MainAdminForm mainAdminForm = new MainAdminForm();
                    mainAdminForm.Show();
                    this.Hide();
                }
                else
                {
                    varningLabel.Text = "Fel användarnamn eller lösenord!";
                }
            }

        }

        private void btnLogIn_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
