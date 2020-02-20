using BusinessEntities.Contexts.Junction;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models.Interfaces
{
    public interface IKompetens
    {
        int KompetensID { get; set; }
        string Beskrivning { get; set; }

        ICollection<AlumnKompetens> AlumnKompetenser { get; set; }

    }
}
