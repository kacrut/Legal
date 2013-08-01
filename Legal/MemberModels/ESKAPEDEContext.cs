using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Legal.Models.Mapping;

namespace Legal.Models
{
    public partial class ESKAPEDEContext : DbContext
    {
        static ESKAPEDEContext()
        {
            Database.SetInitializer<ESKAPEDEContext>(null);
        }

        public ESKAPEDEContext()
            : base("Name=ESKAPEDEContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<webpages_Membership> webpages_Membership { get; set; }
        public DbSet<webpages_Roles> webpages_Roles { get; set; }
        public DbSet<webpages_UsersInRoles> webpages_UsersInRoles { get; set; }
        public DbSet<vwUserProfile> vwUserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new webpages_MembershipMap());
            modelBuilder.Configurations.Add(new webpages_RolesMap());
            modelBuilder.Configurations.Add(new webpages_UsersInRolesMap());
            modelBuilder.Configurations.Add(new vwUserProfileMap());
        }
    }
}
