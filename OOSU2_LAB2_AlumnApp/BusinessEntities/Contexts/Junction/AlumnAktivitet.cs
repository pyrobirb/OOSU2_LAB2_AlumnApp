using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Contexts.Junction
{
    public class AlumnAktivitet
    {
        public int AlumnID {get;set;}
        public virtual Alumn Alumn { get; set; }

        public int AktivitetID { get; set; }
        public virtual Aktivitet Aktivitet { get; set; }
    }
}
