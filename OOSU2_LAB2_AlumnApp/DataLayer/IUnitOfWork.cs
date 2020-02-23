using BusinessEntities.Models;
using DataLayer.InterfacesAndRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IUnitOfWork
    {
        IAlumnRepository AlumnRepository { get; set; }
        IPersonalRepository PersonalRepository{ get; set; }
        IAktivitetRepository AktivitetRepository { get; set; }
        IInformationsutskickRepository InformationsutskickRepository { get; set; }

        void Commit();
    }
}
