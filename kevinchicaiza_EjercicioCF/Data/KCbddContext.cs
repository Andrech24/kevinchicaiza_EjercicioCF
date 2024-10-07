using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using kevinchicaiza_EjercicioCF.Models;

    public class KCbddContext : DbContext
    {
        public KCbddContext (DbContextOptions<KCbddContext> options)
            : base(options)
        {
        }

        public DbSet<kevinchicaiza_EjercicioCF.Models.Burger> Burger { get; set; } = default!;
    }
