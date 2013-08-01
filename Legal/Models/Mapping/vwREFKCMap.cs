using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Legal.Models.Mapping
{
    public class vwREFKCMap : EntityTypeConfiguration<vwREFKC>
    {
        public vwREFKCMap()
        {
            // Primary Key
            this.HasKey(t => new { t.KDKC, t.KDKR, t.NMKC });

            // Properties
            this.Property(t => t.KDKC)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.KDKR)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.NMKC)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.ALMTKC)
                .HasMaxLength(30);

            this.Property(t => t.RTKC)
                .HasMaxLength(3);

            this.Property(t => t.RWKC)
                .HasMaxLength(3);

            this.Property(t => t.KELKC)
                .HasMaxLength(25);

            this.Property(t => t.KECKC)
                .HasMaxLength(25);

            this.Property(t => t.DATI2KC)
                .HasMaxLength(25);

            this.Property(t => t.DATI1KC)
                .HasMaxLength(25);

            this.Property(t => t.KPOSKC)
                .HasMaxLength(5);

            this.Property(t => t.TLPKC)
                .HasMaxLength(12);

            this.Property(t => t.FAXKC)
                .HasMaxLength(12);

            this.Property(t => t.NOURUTKCK)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("vwREFKC");
            this.Property(t => t.KDKC).HasColumnName("KDKC");
            this.Property(t => t.KDKR).HasColumnName("KDKR");
            this.Property(t => t.NMKC).HasColumnName("NMKC");
            this.Property(t => t.ALMTKC).HasColumnName("ALMTKC");
            this.Property(t => t.RTKC).HasColumnName("RTKC");
            this.Property(t => t.RWKC).HasColumnName("RWKC");
            this.Property(t => t.KELKC).HasColumnName("KELKC");
            this.Property(t => t.KECKC).HasColumnName("KECKC");
            this.Property(t => t.DATI2KC).HasColumnName("DATI2KC");
            this.Property(t => t.DATI1KC).HasColumnName("DATI1KC");
            this.Property(t => t.KPOSKC).HasColumnName("KPOSKC");
            this.Property(t => t.TLPKC).HasColumnName("TLPKC");
            this.Property(t => t.FAXKC).HasColumnName("FAXKC");
            this.Property(t => t.NOURUTKCK).HasColumnName("NOURUTKCK");
        }
    }
}
