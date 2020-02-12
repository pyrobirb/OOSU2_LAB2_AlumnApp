using BusinessEntities.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Models
{
    public class Program : IProgram
    {
        public int programId { get; set; }
        public string namn { get; set; }
       
    }
}
