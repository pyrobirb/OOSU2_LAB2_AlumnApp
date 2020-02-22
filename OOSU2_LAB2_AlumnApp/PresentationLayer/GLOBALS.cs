using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public static class GLOBALS
    {
        public static Alumn inloggadAlumn { get; set; }
        public static Personal inloggadPersonal { get; set; }
        public static Aktivitet AktuellAktivitet { get; set; }
    }
}
