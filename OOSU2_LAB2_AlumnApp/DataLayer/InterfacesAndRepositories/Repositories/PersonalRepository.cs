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
    public class PersonalRepository : Repository<Personal>, IPersonalRepository
    {
        public PersonalRepository(DatabaseContext context) : base(context)
        {

        }

        public Personal HämtaPersonalKonto(string användarnamn, string lösenord)
        {
            using (var db = new DatabaseContext())
            {
                return db.Personal.Where(x => x.Användarnamn.ToLower() == användarnamn.ToLower() && x.Lösenord == lösenord.ToString()).FirstOrDefault();
            }
        }
    }
}
