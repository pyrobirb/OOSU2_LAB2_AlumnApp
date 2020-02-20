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
        private readonly DatabaseContext _context;
        public UnitOfWork(DatabaseContext databaseContext)
        {
            _context = databaseContext;
            AlumnRepository = new AlumnRepository(_context);
            PersonalRepository = new PersonalRepository(_context);
        }


        public IAlumnRepository AlumnRepository { get; set; }
        public IPersonalRepository PersonalRepository{ get; set; }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
