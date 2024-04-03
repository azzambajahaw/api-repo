using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositorypattrenwithUOW.Core.Interfaces;
using RepositorypattrenwithUOW.Core.Models;

namespace RepositorypattrenwithUOW.Core
{
    
    
        public interface IUnitOfWork : IDisposable
        {
            IBaseRepository<Level> Levels { get; }
           // IBaseRepository<Classe> Classes { get; }
            IClasseRepository Classes { get; }
            int Complate();

        }
    
}




