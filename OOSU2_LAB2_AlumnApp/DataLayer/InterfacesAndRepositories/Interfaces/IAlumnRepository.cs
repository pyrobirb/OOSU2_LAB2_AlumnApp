using BusinessEntities.Contexts.Junction;
using BusinessEntities.Models;
using DataLayer.InterfacesAndRepositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterfacesAndRepositories.Interfaces
{
    public interface IAlumnRepository : IRepository<Alumn>
    {
        Alumn HämtaAlumnKonto(string användarnamn, string lösenord);
        IQueryable<AlumnProgram> HämtaAlumnerMedProgram(Program program);
        //IQueryable<AlumnKompetens> HämtaAlumnerMedKompetens(Kompetens kompetens);


    }
}
