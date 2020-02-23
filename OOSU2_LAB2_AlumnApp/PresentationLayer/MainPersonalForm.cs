using BusinessEntities.Contexts.Junction;
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
using ProgramClass = BusinessEntities.Models.Program;

namespace PresentationLayer
{
    public partial class MainPersonalForm : Form
    {
        BusinessManager bm = new BusinessManager();
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

            AktivitetCheckedListBox.Items.Clear();
            foreach (Aktivitet aktivitet in bm.uiw.AktivitetRepository.GetAll())
            {
                AktivitetCheckedListBox.Items.Add(aktivitet);
            }
            AktivitetCheckedListBox.ValueMember = "AktivitetID";
            AktivitetCheckedListBox.DisplayMember = "Titel";

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

            MessageBox.Show("Aktiviteten " + ändraTitelTxtBox.Text +  " har redigerats");
        }
    }
}
