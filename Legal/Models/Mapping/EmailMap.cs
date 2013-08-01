using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Legal.Models.Mapping
{
    public class EmailMap : EntityTypeConfiguration<Email>
    {
        public EmailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.kdkc, t.nmkc });

            // Properties
            this.Property(t => t.kdkc)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.nmkc)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.email1)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Email");
            this.Property(t => t.kdkc).HasColumnName("kdkc");
            this.Property(t => t.nmkc).HasColumnName("nmkc");
            this.Property(t => t.email1).HasColumnName("email");
        }
    }
}
