using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Models.Interfaces
{
    interface IAlumn
    {

        string användarnamn { get; set; }
        string lösenord { get; set; }
        List<string> kompetenser { get; set; }

}
}
