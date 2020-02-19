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
        public AlumnRepository(AlumnKontaktContext context) : base(context)
        {

        }
    }
}
