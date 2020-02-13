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
        public static void Populate(AlumnKontaktContext alumnKontaktContext)
        {

            //Alumn-seed
            AlumnKontaktContext akc = new AlumnKontaktContext();
            if (alumnKontaktContext.Alumner.Count() == 0)
            {
                try
                {
                    StreamReader inputFile = new StreamReader("GeneratedAlumns.csv");

                    while (true)
                    {
                        string row = inputFile.ReadLine();
                        if (row == null || row == "") break;

                        string[] parts = row.Split(',');

                        Alumn a = new Alumn();
                        a.Förnamn = parts[0];
                        a.Efternamn = parts[1];
                        a.Användarnamn = parts[2];
                        a.Epost = parts[3];
                        a.Lösenord = parts[4];

                        akc.Alumner.Add(a);

                    }
                    inputFile.Close();
                    akc.SaveChanges();
                }
                catch (Exception)
                {
                    Console.WriteLine("Kunde ej ladda Alumner från CSV-fil!");
                    throw;
                }
            }

            //Program-seed
            if (alumnKontaktContext.Programs.Count() == 0)
            {
                try
                {
                    StreamReader inputFile = new StreamReader("GeneratedPrograms.csv");

                    while (true)
                    {
                        string row = inputFile.ReadLine();
                        if (row == null || row == "") break;

                        string[] parts = row.Split(',');

                        Program p = new Program();
                        p.Namn = parts[0];
                        

                        akc.Programs.Add(p);

                    }
                    inputFile.Close();
                    akc.SaveChanges();
                }
                catch (Exception)
                {
                    Console.WriteLine("Kunde ej ladda Program från CSV-fil!");
                    throw;
                }


                //AlumnProgram-seed

                foreach (Alumn alumn in akc.Alumner)
                {
                    foreach (Program program in akc.Programs)
                    {
                        AlumnProgram ap = new AlumnProgram()
                        {
                            Alumn = alumn,
                            Program = program,
                            AlumnId = alumn.AnvändarId,
                            ProgramID = program.ProgramId
                        };

                        if (alumn.AlumnPrograms == null || program.AlumnPrograms == null)
                        {
                            ICollection<AlumnProgram> apc = new List<AlumnProgram>();
                            alumn.AlumnPrograms = apc;
                            program.AlumnPrograms = apc;
                        }

                        alumn.AlumnPrograms.Add(ap);
                        program.AlumnPrograms.Add(ap);
                        akc.AlumnPrograms.Add(ap);
                        continue;
                    }
                    continue;
                }

            }


        }






    }
}
