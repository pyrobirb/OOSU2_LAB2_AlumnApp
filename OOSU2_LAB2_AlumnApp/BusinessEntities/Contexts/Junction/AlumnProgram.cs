﻿using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Contexts.Junction
{
    public class AlumnProgram
    {
        public int AlumnID { get; set; }
        public virtual Alumn Alumn { get; set; }

        public int ProgramID { get; set; }
        public virtual Program Program { get; set; }
    }
}
