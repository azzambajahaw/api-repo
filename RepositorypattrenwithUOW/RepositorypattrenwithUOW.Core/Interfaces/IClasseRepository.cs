using RepositorypattrenwithUOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorypattrenwithUOW.Core.Interfaces
{
    public interface IClasseRepository : IBaseRepository<Classe>
    {
        IEnumerable<Classe> sleep();
    }
}
