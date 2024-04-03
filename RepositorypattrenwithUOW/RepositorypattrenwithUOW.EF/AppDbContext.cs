using Microsoft.EntityFrameworkCore;
using RepositorypattrenwithUOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorypattrenwithUOW.EF
{
    public class AppDbContext : DbContext   
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Classe> Classes { get; set; }


    }
}
