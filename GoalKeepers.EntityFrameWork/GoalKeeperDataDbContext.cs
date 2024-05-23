using GoalKeepers.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GoalKeepers.EntityFrameWork
{
    public class GoalKeeperDataDbContext : DbContext
    {
        public DbSet<GoalKeeperData> keepers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source = DAMIR ; Initial Catalog = GoalKeeperDB; \nIntegrated Security = True;TrustServerCertificate = True;");

        }
    }
}