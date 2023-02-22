using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UPDCFacilityManager.Modules.Auth.Core.Entities;

namespace UPDCFacilityManager.Modules.Auth.Core.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Email> Emails { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Resident> Residents{ get; set; }
        public DbSet<Clusta> Clusters { get; set; }

    }
}
