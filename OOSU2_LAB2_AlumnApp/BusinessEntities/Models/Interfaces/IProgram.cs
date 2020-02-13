using BusinessEntities.Contexts.Junction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Models.Interfaces
{
    interface IProgram
    {
        int ProgramId { get; set; }
        string Namn { get; set; }
        ICollection<AlumnProgram> AlumnPrograms { get; set; }
    }
}
