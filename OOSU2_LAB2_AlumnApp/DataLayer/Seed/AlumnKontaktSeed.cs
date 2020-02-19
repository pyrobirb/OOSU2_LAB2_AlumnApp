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

        public static void PopulateAlumner(DatabaseContext alumnKontaktContext)
        {
            //if (alumnKontaktContext.Alumner.Count() == 0)
            //{
            //    try
            //    {
            //        StreamReader inputFile = new StreamReader("GeneratedAlumns.csv");

            //        while (true)
            //        {
            //            string row = inputFile.ReadLine();
            //            if (row == null || row == "") break;

            //            string[] parts = row.Split(',');

            //            Alumn a = new Alumn();
            //            a.Förnamn = parts[0];
            //            a.Efternamn = parts[1];
            //            a.Användarnamn = parts[2];
            //            a.Epost = parts[3];
            //            a.Lösenord = parts[4];

            //            alumnKontaktContext.Alumner.Add(a);

            //        }
            //        inputFile.Close();
            //        //alumnKontaktContext.SaveChanges();
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Kunde ej ladda Alumner från CSV-fil!");
            //        throw;
            //    }
            //}
        }
        public static void PopulatePrograms(DatabaseContext alumnKontaktContext)
        {
            //if (alumnKontaktContext.Programs.Count() == 0)
            //{
            //    try
            //    {
            //        StreamReader inputFile = new StreamReader("GeneratedPrograms.csv");

            //        while (true)
            //        {
            //            string row = inputFile.ReadLine();
            //            if (row == null || row == "") break;

            //            string[] parts = row.Split(',');

            //            Program p = new Program();
            //            p.Namn = parts[0];


            //            alumnKontaktContext.Programs.Add(p);

            //        }
            //        inputFile.Close();
            //        //alumnKontaktContext.SaveChanges();
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Kunde ej ladda Program från CSV-fil!");
            //        throw;
            //    }

            //}
        }
        public static void PopulateAlumnPrograms(DatabaseContext alumnKontaktContext)
        {

            //if (alumnKontaktContext.AlumnPrograms.Count() == 0)
            //{

            //    foreach (Alumn alumn in alumnKontaktContext.Alumner)
            //    {
            //        foreach (Program program in alumnKontaktContext.Programs)
            //        {
            //            AlumnProgram ap = new AlumnProgram()
            //            {
            //                Alumn = alumn,
            //                Program = program,
            //                AlumnId = alumn.AnvändarId,
            //                ProgramID = program.ProgramId
            //            };

            //            if (alumn.AlumnPrograms == null || program.AlumnPrograms == null)
            //            {
            //                ICollection<AlumnProgram> apc = new List<AlumnProgram>();
            //                alumn.AlumnPrograms = apc;
            //                //program.AlumnPrograms = apc;
            //            }

            //            alumn.AlumnPrograms.Add(ap);
            //            //program.AlumnPrograms.Add(ap);
            //            alumnKontaktContext.AlumnPrograms.Add(ap);
            //            continue;
            //        }
            //    }
            //}
        }






    }
}
