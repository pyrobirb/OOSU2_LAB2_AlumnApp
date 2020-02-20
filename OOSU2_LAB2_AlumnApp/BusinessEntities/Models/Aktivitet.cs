using BusinessEntities.Contexts.Junction;
using BusinessEntities.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Models
{
    public class Aktivitet : IAktivitet
    {
        [Key]
        public string AktivitetID { get; set; }
        public string Titel { get; set; }
        public string Kontaktperson { get; set; }
        public string Ansvarig { get; set; }
        public string Plats { get; set; }
        public DateTime Startdatum { get; set; }
        public DateTime Slutdatum { get; set; }
        public string Beskrivning { get; set; }

        public virtual ICollection<InformationsutskickAktivitet> InformationsutskickAktivitet { get; set; }
        public virtual ICollection<AlumnAktivitet> AlumnAktiviteter { get; set; }
        
    }
}
