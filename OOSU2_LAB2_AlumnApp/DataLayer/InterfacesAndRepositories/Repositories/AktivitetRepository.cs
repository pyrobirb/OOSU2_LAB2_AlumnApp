using BusinessEntities.Models;
using DataLayer.Contexts;
using DataLayer.InterfacesAndRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterfacesAndRepositories.Repositories
{
    public class AktivitetRepository : Repository<Aktivitet>, IAktivitetRepository
    {
        public AktivitetRepository(DatabaseContext context) : base(context)
        {

        }

        public void UpdateAktivitet(Aktivitet aktivitet, Aktivitet nyaktivitet)
        {
            this.Context.Aktiviteter.Attach(aktivitet);
            aktivitet.Titel = nyaktivitet.Titel;
            aktivitet.Ansvarig = nyaktivitet.Ansvarig;
            aktivitet.Kontaktperson = nyaktivitet.Kontaktperson;
            aktivitet.Plats = nyaktivitet.Plats;
            aktivitet.Startdatum = nyaktivitet.Startdatum;
            aktivitet.Slutdatum = nyaktivitet.Slutdatum;
            aktivitet.Beskrivning = nyaktivitet.Beskrivning;

            this.Context.SaveChanges();
        }
    }
}
