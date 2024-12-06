using Microsoft.EntityFrameworkCore;
using BrewMaster.Models;
using BrewMaster.Models;
using System.Collections.Generic;

namespace BrewMaster.Data
{
    public class BrewMasterDbContext : DbContext
    {
        public BrewMasterDbContext(DbContextOptions<BrewMasterDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Machine> Machine { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Statistic> Statistic { get; set; }
    }
}
