using Model.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SOPDbContext : DbContext
    {
        public SOPDbContext() : base("SOPDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<ComponentCategory> ComponantCategorys { get; set; }
        public DbSet<ComponentDetail> ComponantDetails { get; set; }
        public DbSet<EF.SOPModel> SOPModels { get; set; }
        public DbSet<SOP> SOPs { get; set; }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            //builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
            //builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }
    }
}
