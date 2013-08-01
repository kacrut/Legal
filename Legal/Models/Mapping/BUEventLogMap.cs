using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Legal.Models.Mapping
{
    public class BUEventLogMap : EntityTypeConfiguration<BUEventLog>
    {
        public BUEventLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.KDKC)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.NMKC)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PKSKD)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.PKSNM)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.NOMOR)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.MENUNAME)
                .HasMaxLength(100);

            this.Property(t => t.KETERANGAN)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("BUEventLog");
            this.Property(t => t.ID).HasColumnName("ID");
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
            this.Property(t => t.CREATEDDATE).HasColumnName("CREATEDDATE");
            this.Property(t => t.MODIFIEDDATE).HasColumnName("MODIFIEDDATE");
            this.Property(t => t.MINGGU).HasColumnName("MINGGU");
            this.Property(t => t.TAHUN).HasColumnName("TAHUN");
        }
    }
}
