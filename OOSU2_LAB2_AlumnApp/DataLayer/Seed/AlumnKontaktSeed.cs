using BusinessEntities.Models;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BusinessEntities.Contexts.Junction;

namespace DataLayer.Seed
{
    public class AlumnKontaktSeed
    {
        public static void Populate(DatabaseContext databaseContext)
        {

            Alumn alumn1 = new Alumn()
            {
                Användarnamn = "kalle1",
                Förnamn = "Kalle",
                Efternamn = "Nalle",
                Epost = "kalle@nalle.se",
                Lösenord = "kalle1"
            };
            databaseContext.Alumner.Add(alumn1);

            Alumn alumn2 = new Alumn()
            {
                Användarnamn = "Lalle1",
                Förnamn = "Lalle",
                Efternamn = "Halle",
                Epost = "Lalle@Halle.se",
                Lösenord = "LalleHalle"
            };
            databaseContext.Alumner.Add(alumn2);


            Program program1 = new Program()
            {
                Namn = "Systemvetare"
                
            }; 
            Program program2 = new Program()
            {
                Namn = "Systemarkitekt"

            };

            databaseContext.AlumnPrograms.Add(new AlumnProgram()
            {
                Alumn = alumn1,
                Program = program1
            });
            databaseContext.AlumnPrograms.Add(new AlumnProgram()
            {
                Alumn = alumn1,
                Program = program2
            });
            databaseContext.AlumnPrograms.Add(new AlumnProgram()
            {
                Alumn = alumn2,
                Program = program1
            });


            Personal personal1 = new Personal()
            {
                Användarnamn = "einar1",
                Förnamn = "Einar",
                Efternamn = "Svensson",
                Epost = "einar@alumnpersonal.se",
                Lösenord = "einar2"

            };
            databaseContext.Personal.Add(personal1);

            databaseContext.SaveChanges();

        }

       
    }
}
