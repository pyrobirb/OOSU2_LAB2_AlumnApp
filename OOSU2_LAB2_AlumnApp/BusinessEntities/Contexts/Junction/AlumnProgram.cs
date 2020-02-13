using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Contexts.Junction
{
    public class AlumnProgram
    {
        public int AlumnId { get; set; }
        public Alumn Alumn { get; set; }

        public int ProgramID { get; set; }
        public Program Program { get; set; }
    }
}
