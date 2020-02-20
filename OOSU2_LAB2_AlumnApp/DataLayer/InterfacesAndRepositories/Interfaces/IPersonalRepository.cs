﻿using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterfacesAndRepositories.Interfaces
{
    public interface IPersonalRepository : IRepository<Personal>
    {
        Personal HämtaPersonalKonto(string användarnamn, string lösenord);
    }
}
