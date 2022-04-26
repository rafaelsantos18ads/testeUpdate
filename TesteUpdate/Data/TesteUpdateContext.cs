#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesteUpdate.Models;

namespace TesteUpdate.Data
{
    public class TesteUpdateContext : DbContext
    {
        public TesteUpdateContext (DbContextOptions<TesteUpdateContext> options)
            : base(options)
        {
        }

        public DbSet<TesteUpdate.Models.Department> Department { get; set; }
    }
}
