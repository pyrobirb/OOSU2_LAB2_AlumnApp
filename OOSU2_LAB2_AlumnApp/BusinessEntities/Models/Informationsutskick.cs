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
    public class Informationsutskick : IInformationsutskick
    {
        [Key]
        public string utskicksID { get; set; }
        public DateTime utskicksdatum { get; set; }
        public virtual ICollection<InformationsutskickAlumn> InformationsutskickAlumn { get; set; }
        public virtual ICollection<InformationsutskickAktivitet> InformationsutskickAktivitet { get; set; }
        public virtual ICollection<PersonalInformationsutskick> PersonalInformationsutskick { get; set; }

    }
}
