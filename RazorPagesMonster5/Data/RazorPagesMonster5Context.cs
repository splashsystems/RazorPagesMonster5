using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMonster5.Models;

namespace RazorPagesMonster5.Data
{
    public class RazorPagesMonster5Context : DbContext
    {
        public RazorPagesMonster5Context (DbContextOptions<RazorPagesMonster5Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMonster5.Models.Monster> Monster { get; set; }
    }
}
