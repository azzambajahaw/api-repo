using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RepositorypattrenwithUOW.Core;
using RepositorypattrenwithUOW.Core.Interfaces;
using RepositorypattrenwithUOW.Core.Models;

namespace RepositorypattrenwithUOW.EF.Repositories
{
    public class ClasseRepository : BaseRepository<Classe> , IClasseRepository
    {
        private readonly AppDbContext _context;
        public ClasseRepository(AppDbContext context) :base(context)
        {
            
        }

        public IEnumerable<Classe> sleep()
        {
            throw new NotImplementedException();
        }
    }
}
