using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Contexts.Junction
{
    class AlumnProgram
    {
        public int AlumnId { get; set; }
        public Alumn Alumn { get; set; }

        public int ProgramID { get; set; }
        public Program Program { get; set; }

    }
}
