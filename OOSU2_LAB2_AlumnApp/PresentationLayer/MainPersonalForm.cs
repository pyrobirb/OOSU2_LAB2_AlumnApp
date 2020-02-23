using BusinessEntities.Contexts.Junction;
using BusinessEntities.Models;
using BusinessLayer;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramClass = BusinessEntities.Models.Program;

namespace PresentationLayer
{
    public partial class MainPersonalForm : Form
    {
        BusinessManager bm = new BusinessManager();
        DatabaseContext dbc = new DatabaseContext();

        public MainPersonalForm()
        {
            InitializeComponent();
        }

        private void tabControlMainAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {


            //Fyll Redigera aktivitet
            VäljAktivitetComboBox.DataSource = bm.uiw.AktivitetRepository.GetAll();
            VäljAktivitetComboBox.DisplayMember = "Titel";
            VäljAktivitetComboBox.ValueMember = "AktivitetID";


            FyllAktivitetsfält();

            AktivitetCmbBox.Items.Clear();
            foreach (Aktivitet aktivitet in bm.uiw.AktivitetRepository.GetAll())
            {
                AktivitetCmbBox.Items.Add(aktivitet);
            }
            AktivitetCmbBox.ValueMember = "AktivitetID";
            AktivitetCmbBox.DisplayMember = "Titel";

            programFilterCmbBox.DataSource = bm.uiw.ProgramRepository.GetAll();
            programFilterCmbBox.DisplayMember = "Titel";
            programFilterCmbBox.ValueMember = "Namn";


            //AktuellaAlumner ska vara de valda 
            AlumnCheckedListBox.Items.Clear();

            foreach (Alumn alumn in AlumnerMedProgramFilter())
            {
                if (alumn != null)
                {

                    AlumnCheckedListBox.Items.Add(alumn);
                }
            }

            AlumnCheckedListBox.DisplayMember = "Förnamn";
            AlumnCheckedListBox.ValueMember = "AnvändarID";
            //AktuellaAktiviteter är valda aktiviteter

        }

        private void SkapaAktivitetKnapp_Click(object sender, EventArgs e)
        {
            if (TitelAktivitetTxtBox.Text == "" || AnsvarigPersonTxtBox.Text == "" || KontaktPersonTxtBox.Text == "" || PlatsTxtBox.Text == "" || PlatsTxtBox.Text == "")
                MessageBox.Show("Var vänlig fyll i alla textrutor");
            else
            {
                Aktivitet aktivitet = new Aktivitet()
                {
                    Titel = TitelAktivitetTxtBox.Text,
                    Ansvarig = AnsvarigPersonTxtBox.Text,
                    Kontaktperson = KontaktPersonTxtBox.Text,
                    Plats = PlatsTxtBox.Text,
                    Startdatum = StarttidDateTimePicker.Value,
                    Slutdatum = SluttidDateTimePicker.Value,
                    Beskrivning = PlatsTxtBox.Text,
                    InformationsutskickAktivitet = new List<InformationsutskickAktivitet>(),
                    AlumnAktiviteter = new List<AlumnAktivitet>()
                };

                bm.uiw.AktivitetRepository.Add(aktivitet);
                MessageBox.Show("Aktiviteten har skapats");
                bm.Commit();

            }
        }

        private void VäljAktivitetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FyllAktivitetsfält();
        }

        public void FyllAktivitetsfält()
        {
            Aktivitet AktuellAktivitet = bm.uiw.AktivitetRepository.GetById(((Aktivitet)VäljAktivitetComboBox.SelectedItem).AktivitetID);
            ändraTitelTxtBox.Text = AktuellAktivitet.Titel;
            ändraAnsvarigPersonTxtBox.Text = AktuellAktivitet.Ansvarig;
            ändraAnsvarigKontaktTxtBox.Text = AktuellAktivitet.Kontaktperson;
            ändraPlatsTxtBox.Text = AktuellAktivitet.Plats;
            ändraStarttidDateTime.Value = AktuellAktivitet.Startdatum;
            ändraSlutdatumDateTime.Value = AktuellAktivitet.Slutdatum;
            ändraBeskrivningTextBox.Text = AktuellAktivitet.Beskrivning;
        }

        private void programFilterCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlumnCheckedListBox.Items.Clear();
            foreach (Alumn alumn in AlumnerMedProgramFilter())
            {
                if (alumn != null)
                {

                    AlumnCheckedListBox.Items.Add(alumn);
                }
            }

            AlumnCheckedListBox.DisplayMember = "Förnamn";
            AlumnCheckedListBox.ValueMember = "AnvändarID";

        }

        public List<Alumn> AlumnerMedProgramFilter()
        {
            return bm.HämtaAlumnerMedProgram((ProgramClass)programFilterCmbBox.SelectedItem);
        }

        //public List<Alumn> AlumnerMedKompetensFilter()
        //{
        //    return bm.HämtaAlumnerMedKompetens((Kompetens)KompetensFilterCmbBox.SelectedItem);
        //}
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            GLOBALS.inloggadAlumn = null;
            GLOBALS.inloggadPersonal = null;
        }

        private void KompetensFilterCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Aktivitet uppdateradAktivitet = new Aktivitet()
            {
                Titel = ändraTitelTxtBox.Text,
                Ansvarig = ändraAnsvarigPersonTxtBox.Text,
                Kontaktperson = ändraAnsvarigKontaktTxtBox.Text,
                Plats = ändraPlatsTxtBox.Text,
                Startdatum = ändraStarttidDateTime.Value,
                Slutdatum = ändraSlutdatumDateTime.Value,
                Beskrivning = ändraBeskrivningTextBox.Text,
                InformationsutskickAktivitet = new List<InformationsutskickAktivitet>(),
                AlumnAktiviteter = new List<AlumnAktivitet>()
            };

            Aktivitet aktivitetAttTaBort = bm.uiw.AktivitetRepository.GetById(((Aktivitet)VäljAktivitetComboBox.SelectedItem).AktivitetID);


            bm.UpdateAktivitet(aktivitetAttTaBort, uppdateradAktivitet);
            bm.Commit();

            MessageBox.Show("Aktiviteten " + ändraTitelTxtBox.Text + " har redigerats");
        }

        private void btnCreateAlumnCSV_Click(object sender, EventArgs e)
        {
            Informationsutskick informationsutskick = new Informationsutskick()
            {
                utskicksdatum = DateTime.Now
            };
            bm.uiw.InformationsutskickRepository.Add(informationsutskick);
            bm.Commit();

            InformationsutskickAktivitet informationsutskickAktivitet = new InformationsutskickAktivitet()
            {
                AktivitetID = (bm.uiw.AktivitetRepository.GetById(((Aktivitet)AktivitetCmbBox.SelectedItem).AktivitetID)).AktivitetID,
                InformationsutskickID = informationsutskick.utskicksID
            };
            dbc.InformationsutskickAktivitet.Add(informationsutskickAktivitet);
            dbc.SaveChanges();

            foreach (Alumn alumn in valdaAlumnerListBox.Items)
            {
                InformationsutskickAlumn informationsutskickAlumn = new InformationsutskickAlumn()
                {
                    AlumnID = (bm.uiw.AlumnRepository.GetById(alumn.AnvändarID)).AnvändarID,
                    InformationsutskickID = (bm.uiw.InformationsutskickRepository.GetById(informationsutskick.utskicksID)).utskicksID
                };
                dbc.InformationsutskickAlumn.Add(informationsutskickAlumn);
            }

            bm.Commit();
            dbc.SaveChanges();

            List<Alumn> alumner = new List<Alumn>();
            foreach (Alumn alumn in valdaAlumnerListBox.Items)
            {
                alumner.Add(alumn);
            }

            bm.SkrivaAlumnAktivitetTillCSVFil(((Aktivitet)AktivitetCmbBox.SelectedItem).Titel, alumner);
            MessageBox.Show("Aktivitetens titel och Alumnernas eposadresser har blivit skrivna till CSV Filen!");
        }


        
        private void AlumnCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void flyttaÖverAlumnBtn_Click(object sender, EventArgs e)
        {
            foreach (Alumn alumn in AlumnCheckedListBox.CheckedItems)
            {
                if (!valdaAlumnerListBox.Items.Contains(alumn))
                {
                    List<Alumn> alumner = new List<Alumn>();
                    foreach (Alumn alumn1 in valdaAlumnerListBox.Items)
                    {
                        alumner.Add(alumn1);
                    }
                    alumner.Add(alumn);
                    valdaAlumnerListBox.DataSource = alumner;
                    valdaAlumnerListBox.DisplayMember = "Förnamn";
                    valdaAlumnerListBox.ValueMember = "AnvändarID";
                }
            }


            foreach (Alumn alumn1 in valdaAlumnerListBox.Items)
            {
                if (!AlumnCheckedListBox.CheckedItems.Contains(alumn1))
                {
                    List<Alumn> valdaAlumner = new List<Alumn>();
                    foreach (Alumn alumn in valdaAlumnerListBox.Items)
                    {
                        valdaAlumner.Add(alumn);
                    }

                    valdaAlumner.Remove(alumn1);

                    valdaAlumnerListBox.DataSource = valdaAlumner;

                }
            }

            valdaAlumnerListBox.ValueMember = "AnvändarID";
            valdaAlumnerListBox.DisplayMember = "Förnamn";

        }
    }
}
