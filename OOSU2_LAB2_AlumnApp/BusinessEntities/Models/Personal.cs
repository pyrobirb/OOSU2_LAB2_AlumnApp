﻿using BusinessEntities.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Models
{
    public class Personal : IPersonal
    {
        [Key]
        public int PersonalId { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Användarnamn { get; set; }
        public string Epost { get; set; }
        public string Lösenord { get; set; }
    }
}
