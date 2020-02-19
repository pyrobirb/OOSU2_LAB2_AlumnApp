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
        public Alumn loggedInAlumn { get; set; }
        public Personal loggedInPersonal { get; set; }

        public UnitOfWork uiw = new UnitOfWork(new DatabaseContext());

        public bool ControlLogin(string username, string password)
        {

            foreach (Alumn alumn in uiw.AlumnRepository.GetAll())
            {
                if ((username == alumn.Användarnamn) && (password == alumn.Lösenord))
                {
                    loggedInAlumn = alumn;
                    return true;
                }
            }
            foreach (Personal personal in uiw.PersonalRepository.GetAll())
            {
                if ((username == personal.Användarnamn) && (password == personal.Lösenord))
                {
                    loggedInPersonal = personal;
                    return true;
                }
            }
            return false;
        }

        

    }
}
