using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositorypattrenwithUOW.Core;
using RepositorypattrenwithUOW.Core.Interfaces;
using RepositorypattrenwithUOW.Core.Models;
using RepositorypattrenwithUOW.EF.Repositories;

namespace RepositorypattrenwithUOW.EF
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IBaseRepository<Level> Levels { get; private set; }
        //public IBaseRepository<Classe> Classes { get; private set; }
        public IClasseRepository Classes { get; private set; }


        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Levels = new BaseRepository<Level>(_context);
            //Classes = new BaseRepository<Classe>(_context);
            Classes = new ClasseRepository(_context);
        }
        public int Complate()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
             _context.Dispose();
        }


    }
}
