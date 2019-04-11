using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tarea4Topicos.Models;

namespace Tarea4Topicos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Tarea4Topicos.Models.Usuario> Usuario { get; set; }
        public DbSet<Tarea4Topicos.Models.TipoVehiculo> TipoVehiculo { get; set; }
        public DbSet<Tarea4Topicos.Models.Parqueo> Parqueo { get; set; }
        public DbSet<Tarea4Topicos.Models.Vehiculo> Vehiculo { get; set; }
        public DbSet<Tarea4Topicos.Models.Estacionamiento> Estacionamiento { get; set; }
    }
}
