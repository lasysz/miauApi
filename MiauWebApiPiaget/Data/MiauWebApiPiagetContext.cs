using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entities;

namespace MiauWebApiPiaget.Data
{
    public class MiauWebApiPiagetContext : DbContext
    {
        public MiauWebApiPiagetContext (DbContextOptions<MiauWebApiPiagetContext> options)
            : base(options)
        {
        }

        public DbSet<Entities.Aluno> Aluno { get; set; } = default!;
    }
}
