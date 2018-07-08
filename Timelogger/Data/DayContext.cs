using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Timelogger.Models
{
    public class DayContext : DbContext
    {
        public DayContext (DbContextOptions<DayContext> options)
            : base(options)
        {
        }

        public DbSet<Timelogger.Models.Day> Day { get; set; }
    }
}
