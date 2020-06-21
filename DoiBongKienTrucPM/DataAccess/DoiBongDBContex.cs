using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DoiBongDBContex : DbContext
    {
        public DoiBongDBContex() : base("DoiBongDbContextConnectionString")
        {
            Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<eTeam> eTeams { get; set; }
        public DbSet<ePlayer> ePlayers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
