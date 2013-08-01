using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Legal.Models.Mapping
{
    public class vwSendEmailMap : EntityTypeConfiguration<vwSendEmail>
    {
        public vwSendEmailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.KDKC, t.NMKC, t.PKSKD, t.PKSNM, t.NOMOR, t.PKSKE, t.PKSTGLML, t.PKSTGLAKH, t.KDCRBYR, t.TAHUN });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.PKSKE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KDCRBYR)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MENUNAME)
                .HasMaxLength(100);

            this.Property(t => t.KETERANGAN)
                .HasMaxLength(500);

            this.Property(t => t.TAHUN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.email)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("vwSendEmail");
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
            this.Property(t => t.MINGGU).HasColumnName("MINGGU");
            this.Property(t => t.TAHUN).HasColumnName("TAHUN");
            this.Property(t => t.BULAN).HasColumnName("BULAN");
            this.Property(t => t.email).HasColumnName("email");
        }
    }
}
