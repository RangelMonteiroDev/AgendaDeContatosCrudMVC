using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaDeContadosCrudMVC.Migrations;
using AgendaDeContadosCrudMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaDeContadosCrudMVC.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(

            DbContextOptions<AppDbContext> options
        ) : base (options) {}

       public DbSet<Models.Usuarios> Usuarios {get; set;} 

       public DbSet<Models.Login> Login {get; set;} 
    }
}