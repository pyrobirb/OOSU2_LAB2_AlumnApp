using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Contexts.Junction
{
    public class AlumnKompetens
    {
        public int AlumnID { get; set; }
        public virtual Alumn Alumn { get; set; }

        public int KompetensID { get; set; }
        public virtual Kompetens Kompetens { get; set; }
    }
}
