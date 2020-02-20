using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Contexts.Junction
{
    public class PersonalInformationsutskick
    {
        public int PersonalID { get; set; }
        public virtual Personal Personal { get; set; }

        public int InformationsutskickID { get; set; }
        public virtual Informationsutskick Informationsutskick { get; set; }

    }
}
