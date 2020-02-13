using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Models.Interfaces
{
    interface IPersonal
    {

        int PersonalId { get; set; }
        string Förnamn { get; set; }
        string Efternamn { get; set; }
        string Användarnamn { get; set; }
        string Epost { get; set; }
        string Lösenord { get; set; }
    }
}
