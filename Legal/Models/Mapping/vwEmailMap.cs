using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Legal.Models.Mapping
{
    public class vwEmailMap : EntityTypeConfiguration<vwEmail>
    {
        public vwEmailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.KDKC, t.NMKC, t.Email });

            // Properties
            this.Property(t => t.KDKC)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.NMKC)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(22);

            // Table & Column Mappings
            this.ToTable("vwEmail");
            this.Property(t => t.KDKC).HasColumnName("KDKC");
            this.Property(t => t.NMKC).HasColumnName("NMKC");
            this.Property(t => t.Email).HasColumnName("Email");
        }
    }
}
