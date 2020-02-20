using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Contexts.Junction
{
    public class InformationsutskickAktivitet
    {
        public int InformationsutskickID { get; set; }
        public virtual Informationsutskick Informationsutskick { get; set; }

        public int AktivitetID { get; set; }
        public virtual Aktivitet Aktivitet { get; set; }

    }
}
