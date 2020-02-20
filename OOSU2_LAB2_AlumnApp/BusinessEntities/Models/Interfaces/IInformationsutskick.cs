using BusinessEntities.Contexts.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Models.Interfaces
{
    interface IInformationsutskick
    {
        int utskicksID { get; set; }
        DateTime utskicksdatum { get; set; }

        ICollection<InformationsutskickAlumn> InformationsutskickAlumn { get; set; }
        ICollection<InformationsutskickAktivitet> InformationsutskickAktivitet { get; set; }
        ICollection<PersonalInformationsutskick> PersonalInformationsutskick { get; set; }


    }
}
