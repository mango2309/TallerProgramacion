using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerProgramacion.Models;

namespace TallerProgramacion.Data
{
    public class TallerProgramacionContext : DbContext
    {
        public TallerProgramacionContext (DbContextOptions<TallerProgramacionContext> options)
            : base(options)
        {
        }

        public DbSet<TallerProgramacion.Models.Burguer> Burguer { get; set; } = default!;
    }
}
