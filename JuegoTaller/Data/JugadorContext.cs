using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JuegoTaller.Models;

    public class JugadorContext : DbContext
    {
        public JugadorContext (DbContextOptions<JugadorContext> options)
            : base(options)
        {
        }

        public DbSet<JuegoTaller.Models.Jugador> Jugador { get; set; } = default!;
    }
