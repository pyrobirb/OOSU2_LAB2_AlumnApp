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
    public class Alumn : IAlumn
    {
        [Key]
        public int AnvändarID { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Användarnamn { get; set; }
        public string Epost { get; set; }
        public string Lösenord { get; set; }
        public virtual ICollection<AlumnProgram> AlumnPrograms { get; set; }
        public virtual ICollection<AlumnKompetens> AlumnKompetenser { get; set; }
        public virtual ICollection<InformationsutskickAlumn> InformationsutskickAlumn { get; set; }
        public virtual ICollection<AlumnAktivitet> AlumnAktiviteter { get; set; }

    }
}
