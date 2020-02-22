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
            AktivitetRepository = new AktivitetRepository(_context);
            KompetensRepository = new KompetensRepository(_context);
            ProgramRepository = new ProgramRepository(_context);
        }


        public IAlumnRepository AlumnRepository { get; set; }
        public IPersonalRepository PersonalRepository{ get; set; }
        public IAktivitetRepository AktivitetRepository { get; set; }
        public IKompetensRepository KompetensRepository { get; set; }
        public IProgramRepository ProgramRepository { get; set; }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
