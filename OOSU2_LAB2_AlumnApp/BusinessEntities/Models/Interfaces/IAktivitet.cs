using BusinessEntities.Contexts.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Models.Interfaces
{
    interface IAktivitet
    {
        int AktivitetID { get; set; }
        string Titel { get; set; }
        string Kontaktperson { get; set; }
        string Ansvarig { get; set; }
        string Plats { get; set; }
        DateTime Startdatum { get; set; }
        DateTime Slutdatum { get; set; }
        string Beskrivning { get; set; }

        ICollection<InformationsutskickAktivitet> InformationsutskickAktivitet { get; set; }
        ICollection<AlumnAktivitet> AlumnAktiviteter { get; set; }


    }
}
