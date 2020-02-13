using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Models.Interfaces
{
    interface IInformationsutskick
    {
        string utskicksId { get; set; }
        DateTime utskicksdatum { get; set; }


    }
}
