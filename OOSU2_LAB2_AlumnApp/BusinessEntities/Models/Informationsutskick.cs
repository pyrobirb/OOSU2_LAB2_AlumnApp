using BusinessEntities.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Models
{
    public class Informationsutskick : IInformationsutskick
    {
        [Key]
        public string utskicksId { get; set; }
        public DateTime utskicksdatum { get; set; }
    }
}
