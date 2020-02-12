using BusinessEntities.Models;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Seed
{
    public class AlumnKontaktSeed
    {
        public static void Populate(AlumnKontaktContext alumnKontaktContext)
        {

            Program systemvetpr = new Program()
            {
                namn = "Systemvetare"
            };
            Program programDekon = new Program()
            {
                namn = "Dataekonom"
            };
            Program Dataing = new Program()
            {
                namn = "Dataingenjör"
            };
            Program Sysark = new Program()
            {
                namn = "Systemarkitekt"
            };

            alumnKontaktContext.Alumner.Add(new Alumn()
            {
                användarnamn = "kalle123",
                förnamn = "Kalle",
                efternamn = "Larsson",
                lösenord = "123kalle",
                program = new List<Program>()
                {
                    programDekon,
                    Dataing

                }

            });
            alumnKontaktContext.Alumner.Add(new Alumn()
            {
                användarnamn = "petra12",
                förnamn = "Petra",
                efternamn = "Klarsson",
                lösenord = "petra123",
                program = new List<Program>()
                {
                    new Program()
                    {
                        namn = "Högskoleingenjör"
                    },
                    systemvetpr

                }
            });
            alumnKontaktContext.Alumner.Add(new Alumn()
            {
                användarnamn = "Petter1",
                förnamn = "Petter",
                efternamn = "Dessne",
                lösenord = "pdessnen",
                program = new List<Program>()
                {
                    new Program()
                    {
                        namn = "Dataekonom"
                    },
                    new Program()
                    {
                        namn = "Dataingenjör"
                    },
                    systemvetpr
                }
            });


            alumnKontaktContext.Programs.Add(systemvetpr);
            alumnKontaktContext.Programs.Add(programDekon);
            alumnKontaktContext.Programs.Add(Dataing);
            alumnKontaktContext.Programs.Add(Sysark);









        }






    }
}
