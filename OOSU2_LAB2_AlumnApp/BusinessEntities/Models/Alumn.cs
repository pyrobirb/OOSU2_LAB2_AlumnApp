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
        public string användarnamn { get; set; }
        public string lösenord { get; set; }
        public List<string> kompetenser { get; set; }
    }
}
