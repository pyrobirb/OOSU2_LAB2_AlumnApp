﻿using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterfacesAndRepositories.Interfaces
{
    public interface IAktivitetRepository : IRepository<Aktivitet>
    {
        void UpdateAktivitet(Aktivitet aktivitet, Aktivitet nyaktivitet);
        
    }
}
