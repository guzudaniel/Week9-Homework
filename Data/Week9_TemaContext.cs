using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Week9_Tema.Models;

namespace Week9_Tema.Data
{
    public class Week9_TemaContext : DbContext
    {
        public Week9_TemaContext (DbContextOptions<Week9_TemaContext> options)
            : base(options)
        {
        }

        public DbSet<Week9_Tema.Models.Movie> Movie { get; set; }
    }
}
