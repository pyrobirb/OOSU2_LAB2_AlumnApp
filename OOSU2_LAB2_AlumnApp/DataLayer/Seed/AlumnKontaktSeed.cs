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
            //Alumner

            Alumn alumn1 = new Alumn()
            {
                Användarnamn = "kalle1",
                Förnamn = "Kalle",
                Efternamn = "Nalle",
                Epost = "kalle@nalle.se",
                Lösenord = "kalle1"
            };

            Alumn alumn2 = new Alumn()
            {
                Användarnamn = "Lalle1",
                Förnamn = "Lalle",
                Efternamn = "Halle",
                Epost = "Lalle@Halle.se",
                Lösenord = "LalleHalle"
            };

            databaseContext.Alumner.Add(alumn1);
            databaseContext.Alumner.Add(alumn2);



            //Program
            Program program1 = new Program()
            {
                Namn = "Systemvetare"
            }; 
            Program program2 = new Program()
            {
                Namn = "Systemarkitekt"
            };

            databaseContext.Programs.Add(program1);
            databaseContext.Programs.Add(program2);

            //Kompetens
            Kompetens kompetens1 = new Kompetens()
            {
                Beskrivning = "C#"
            };
            Kompetens kompetens2 = new Kompetens()
            {
                Beskrivning = "Java"
            };
            Kompetens kompetens3 = new Kompetens()
            {
                Beskrivning = "HTML"
            };
            databaseContext.Kompetenser.Add(kompetens1);
            databaseContext.Kompetenser.Add(kompetens2);
            databaseContext.Kompetenser.Add(kompetens3);


            //AlumnProgram
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

            //AlumnKompetens

            databaseContext.AlumnKompetens.Add(new AlumnKompetens()
            {
                Alumn = alumn1,
                Kompetens = kompetens1
            });
            databaseContext.AlumnKompetens.Add(new AlumnKompetens()
            {
                Alumn = alumn1,
                Kompetens = kompetens2
            }); 
            databaseContext.AlumnKompetens.Add(new AlumnKompetens()
            {
                Alumn = alumn2,
                Kompetens = kompetens3
            });

            //Personal
            Personal personal1 = new Personal()
            {
                Användarnamn = "einar1",
                Förnamn = "Einar",
                Efternamn = "Svensson",
                Epost = "einar@alumnpersonal.se",
                Lösenord = "einar2"

            };
            databaseContext.Personal.Add(personal1);


            //Aktivitet
            Aktivitet aktivitet1 = new Aktivitet()
            {
                Titel = "Företagsmässa för nyexaminerade",
                Ansvarig = "Milla Trop",
                Kontaktperson = "Loki Foi",
                Plats = "Högskolan i Borås",
                Startdatum = new DateTime(2020, 08, 01),
                Slutdatum = new DateTime(2020, 08, 02),
                Beskrivning = "Träffa företag som är i behov av just dig! Knyt kontakter och maxa dina möjligheter",
                InformationsutskickAktivitet = new List<InformationsutskickAktivitet>(),
                AlumnAktiviteter = new List<AlumnAktivitet>()                
            };
            databaseContext.Aktiviteter.Add(aktivitet1);



            //SaveDb
            databaseContext.SaveChanges();

        }
    }
}
