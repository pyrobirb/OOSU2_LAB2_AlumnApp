using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Models.Interfaces
{
    interface IAlumn
    {
        int användarId { get; set; }
        string förnamn { get; set; }
        string efternamn { get; set; }
        string användarnamn { get; set; }
        string lösenord { get; set; }
        ICollection<Program> program { get; set; }

}
}
