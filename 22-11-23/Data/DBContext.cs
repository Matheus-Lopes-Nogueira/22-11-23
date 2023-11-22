using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _22_11_23.Models;

namespace _22_11_23.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<_22_11_23.Models.cadclientes> cadclientes { get; set; } = default!;

        public DbSet<_22_11_23.Models.cadmaquinas>? cadmaquinas { get; set; }

        public DbSet<_22_11_23.Models.inventario>? inventario { get; set; }
    }
}
