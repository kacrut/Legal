using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Legal.Models.Mapping
{
    public class vwGetBUExpiredMap : EntityTypeConfiguration<vwGetBUExpired>
    {
        public vwGetBUExpiredMap()
        {
            // Primary Key
            this.HasKey(t => new { t.KDKC, t.NMKC, t.PKSKD, t.PKSNM, t.KDCRBYR, t.CREATEDDATE });

            // Properties
            this.Property(t => t.KDKC)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.NMKC)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.PKSKD)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.PKSNM)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.NOMOR)
                .HasMaxLength(25);

            this.Property(t => t.KDCRBYR)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.MENUNAME)
                .HasMaxLength(100);

            this.Property(t => t.KETERANGAN)
                .HasMaxLength(500);

            this.Property(t => t.EMAIL)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("vwGetBUExpired");
            this.Property(t => t.KDKC).HasColumnName("KDKC");
            this.Property(t => t.NMKC).HasColumnName("NMKC");
            this.Property(t => t.PKSKD).HasColumnName("PKSKD");
            this.Property(t => t.PKSNM).HasColumnName("PKSNM");
            this.Property(t => t.NOMOR).HasColumnName("NOMOR");
            this.Property(t => t.PKSKE).HasColumnName("PKSKE");
            this.Property(t => t.PKSTGLML).HasColumnName("PKSTGLML");
            this.Property(t => t.PKSTGLAKH).HasColumnName("PKSTGLAKH");
            this.Property(t => t.KDCRBYR).HasColumnName("KDCRBYR");
            this.Property(t => t.KDLAPSE).HasColumnName("KDLAPSE");
            this.Property(t => t.MENUNAME).HasColumnName("MENUNAME");
            this.Property(t => t.KETERANGAN).HasColumnName("KETERANGAN");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");
            this.Property(t => t.CREATEDDATE).HasColumnName("CREATEDDATE");
            this.Property(t => t.MINGGU).HasColumnName("MINGGU");
            this.Property(t => t.TAHUN).HasColumnName("TAHUN");
        }
    }
}
