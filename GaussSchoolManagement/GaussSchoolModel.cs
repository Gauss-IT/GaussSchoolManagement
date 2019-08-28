namespace GaussSchoolManagement
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GaussSchoolModel : DbContext
    {
        public GaussSchoolModel()
            : base("name=GaussSchoolEntity")
        {
        }

        public virtual DbSet<Instruktore> Instruktores { get; set; }
        public virtual DbSet<InstruktoreKurse> InstruktoreKurses { get; set; }
        public virtual DbSet<Kurse> Kurses { get; set; }
        public virtual DbSet<Nxene> Nxenes { get; set; }
        public virtual DbSet<NxenesKurse> NxenesKurses { get; set; }
        public virtual DbSet<NxenesPagesa> NxenesPagesas { get; set; }
        public virtual DbSet<Pagesa> Pagesas { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Prinder> Prinders { get; set; }
        public virtual DbSet<Sherbimet> Sherbimets { get; set; }
        public virtual DbSet<Shkolla> Shkollas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kurse>()
                .Property(e => e.ShifraKursit)
                .IsUnicode(false);

            modelBuilder.Entity<Kurse>()
                .Property(e => e.EmriKursit)
                .IsUnicode(false);

            modelBuilder.Entity<Kurse>()
                .Property(e => e.Pershkrimi)
                .IsUnicode(false);

            modelBuilder.Entity<Kurse>()
                .Property(e => e.Niveli)
                .IsUnicode(false);

            modelBuilder.Entity<Kurse>()
                .Property(e => e.VitiShkollor)
                .IsUnicode(false);

            modelBuilder.Entity<Nxene>()
                .Property(e => e.Klasa)
                .IsUnicode(false);

            modelBuilder.Entity<Pagesa>()
                .Property(e => e.FormaPageses)
                .IsUnicode(false);

            modelBuilder.Entity<Pagesa>()
                .Property(e => e.SasiaSherbimeve)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Pagesa>()
                .Property(e => e.ShumaPaguar)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Pagesa>()
                .Property(e => e.Zbritje)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Emri)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Mbiemri)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.EmailAdresa)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Telefoni)
                .IsUnicode(false);

            modelBuilder.Entity<Persona>()
                .Property(e => e.Adresa)
                .IsFixedLength();

            modelBuilder.Entity<Sherbimet>()
                .Property(e => e.Cmimi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sherbimet>()
                .Property(e => e.Pershkrimi)
                .IsUnicode(false);

            modelBuilder.Entity<Shkolla>()
                .Property(e => e.ShkollaEmri)
                .IsUnicode(false);

            modelBuilder.Entity<Shkolla>()
                .Property(e => e.ShkollaTipi)
                .IsUnicode(false);
        }
    }
}
