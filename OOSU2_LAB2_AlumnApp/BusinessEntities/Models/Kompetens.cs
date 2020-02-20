using BusinessEntities.Contexts.Junction;
using BusinessEntities.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models
{
    public class Kompetens : IKompetens
    {
        public int KompetensID { get; set; }
        public string Beskrivning { get; set; }
        public ICollection<AlumnKompetens> AlumnKompetenser { get; set; }
    }
}
