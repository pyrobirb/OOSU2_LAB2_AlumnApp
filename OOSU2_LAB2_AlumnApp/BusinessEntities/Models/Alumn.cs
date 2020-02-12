using BusinessEntities.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Models
{
    public class Alumn : IAlumn
    {
        public int användarId { get; set; }
        public string förnamn { get; set; }
        public string efternamn { get; set; }
        public string användarnamn { get; set; }
        public string lösenord { get; set; }
        public ICollection<Program> program { get; set; }
    }
}
