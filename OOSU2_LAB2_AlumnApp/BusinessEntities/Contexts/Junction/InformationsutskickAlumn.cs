using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Contexts.Junction
{
    public class InformationsutskickAlumn
    {
        public int AlumnID { get; set; }
        public virtual Alumn Alumn { get; set; }

        public int InformationsutskickID { get; set; }
        public virtual Informationsutskick Informationsutskick { get; set; }
    }
}
