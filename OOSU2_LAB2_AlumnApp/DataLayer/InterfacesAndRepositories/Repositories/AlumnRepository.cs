using BusinessEntities.Contexts.Junction;
using BusinessEntities.Models;
using DataLayer.Contexts;
using DataLayer.InterfacesAndRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterfacesAndRepositories.Repositories
{
    public class AlumnRepository : Repository<Alumn>, IAlumnRepository
    {
        public AlumnRepository(DatabaseContext context) : base(context)
        {

        }

        public Alumn HämtaAlumnKonto(string användarnamn, string lösenord)
        {
            using (var db = new DatabaseContext())
            {
                return db.Alumner.Where(x => x.Användarnamn.ToLower() == användarnamn.ToLower() && x.Lösenord == lösenord).FirstOrDefault();
            }
        }

        public IQueryable<AlumnProgram> HämtaAlumnerMedProgram(Program program)
        {
            var db = new DatabaseContext();

            return db.AlumnPrograms.Where(x => x.Program == program);
        }

        //public IQueryable<AlumnKompetens> HämtaAlumnerMedKompetens(Kompetens kompetens)
        //{
        //    var db = new DatabaseContext();

        //    return db.AlumnKompetens.Where(x => x.Kompetens == kompetens);
        //}

    }
}
