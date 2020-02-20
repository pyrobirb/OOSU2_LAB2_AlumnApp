using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessManager
    {
       
        public UnitOfWork uiw = new UnitOfWork(new DatabaseContext());


        public Alumn HämtaAlumnKonto(string username, string password)
        {
            return uiw.AlumnRepository.HämtaAlumnKonto(username, password);
        }

        public Personal HämtaPersonalKonto(string username, string password)
        {
            return uiw.PersonalRepository.HämtaPersonalKonto(username, password);
        }
        public void LäggTillAlumn(Alumn alumn)
        {
            uiw.AlumnRepository.Add(alumn);
        }
        public void LäggTillPersonal(Personal personal)
        {
            uiw.PersonalRepository.Add(personal);
        }
    }
}
