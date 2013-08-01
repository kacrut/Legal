using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Legal.Models.Mapping;

namespace Legal.Models
{
    public partial class LegalMailerContext : DbContext
    {
        static LegalMailerContext()
        {
            Database.SetInitializer<LegalMailerContext>(null);
        }

        public LegalMailerContext()
            : base("Name=LegalMailerContext")
        {
        }

        public DbSet<BUEventLog> BUEventLogs { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<LegalEventLog> LegalEventLogs { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<vwEmail> vwEmails { get; set; }
        public DbSet<vwGetBUExpired> vwGetBUExpireds { get; set; }
        public DbSet<vwREFKC> vwREFKCs { get; set; }
        public DbSet<vwSendEmail> vwSendEmails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BUEventLogMap());
            modelBuilder.Configurations.Add(new EmailMap());
            modelBuilder.Configurations.Add(new LegalEventLogMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new vwEmailMap());
            modelBuilder.Configurations.Add(new vwGetBUExpiredMap());
            modelBuilder.Configurations.Add(new vwREFKCMap());
            modelBuilder.Configurations.Add(new vwSendEmailMap());
        }
    }
}
