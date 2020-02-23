using BusinessEntities.Contexts.Junction;
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

        public List<Alumn> HämtaAlumnerMedProgram(Program program)
        {
            List<Alumn> alumnerMedProgram = new List<Alumn>();
            foreach (AlumnProgram ap in uiw.AlumnRepository.HämtaAlumnerMedProgram(program))
            {
                alumnerMedProgram.Add(uiw.AlumnRepository.GetById(ap.AlumnID));
            }
            return alumnerMedProgram;
        }


        public void UpdateAktivitet(Aktivitet aktivitet, Aktivitet nyaktivitet)
        {
            uiw.AktivitetRepository.UpdateAktivitet(aktivitet, nyaktivitet);
        }

        //public List<Alumn> HämtaAlumnerMedKompetens(Kompetens kompetens)
        //{
        //    List<Alumn> alumnerMedKompetens = new List<Alumn>();
        //    foreach (AlumnKompetens ap in uiw.AlumnRepository.HämtaAlumnerMedKompetens(kompetens))
        //    {
        //        alumnerMedKompetens.Add(uiw.AlumnRepository.GetById(ap.AlumnID));
        //    }
        //    return alumnerMedKompetens;
        //}

        public void Commit()
        {
            uiw.Commit();
        }
    }
}
