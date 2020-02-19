using DataLayer.Contexts;
using DataLayer.InterfacesAndRepositories.Interfaces;
using DataLayer.InterfacesAndRepositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AlumnKontaktContext _context;
        public UnitOfWork(AlumnKontaktContext alumnKontaktContext)
        {
            _context = alumnKontaktContext;
            AlumnRepository = new AlumnRepository(_context);
        }


        public IAlumnRepository AlumnRepository { get; set; }

        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}
