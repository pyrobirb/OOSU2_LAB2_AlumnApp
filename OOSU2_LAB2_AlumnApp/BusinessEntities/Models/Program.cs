using BusinessEntities.Contexts.Junction;
using BusinessEntities.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Models
{
    public class Program : IProgram
    {
        [Key]
        public int ProgramId { get; set; }
        public string Namn { get; set; }
        public virtual ICollection<AlumnProgram> AlumnPrograms { get; set; }
    }
}
