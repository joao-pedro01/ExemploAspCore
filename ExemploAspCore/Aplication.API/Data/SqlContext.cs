using Aplication.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication.API.Data
{
    public class SqlContext : DbContext
    {
        public DbSet<Contatos> Contato { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
