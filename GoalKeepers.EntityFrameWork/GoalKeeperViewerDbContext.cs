using GoalKeepers.EntityFrameWork.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalKeepers.EntityFrameWork
{
    public class GoalKeeperViewerDbContext : DbContext
    {
        public DbSet<GoalKeeperViewerDto> GoalKeeperViewers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source = DAMIR ; Initial Catalog = GoalKeeperViewerDB; \nIntegrated Security = True;TrustServerCertificate = True;");

        }
    }
}
