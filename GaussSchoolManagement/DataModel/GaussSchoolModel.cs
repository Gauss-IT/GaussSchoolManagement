using System.Data.Entity;

namespace GaussSchoolManagement.DataModel
{
    public partial class GaussSchoolModel : DbContext
    {
        public GaussSchoolModel()
            : base(ConnectionStringBuilder.Construct())
        {
        }

        public virtual DbSet<Instruktore> Instruktores { get; set; }
        public virtual DbSet<InstruktoreKurse> InstruktoreKurses { get; set; }
        public virtual DbSet<InstruktorePagesa> InstruktorePagesas{ get; set; }
        public virtual DbSet<Kurse> Kurses { get; set; }
        public virtual DbSet<Nxene> Nxenes { get; set; }
        public virtual DbSet<NxenesKurse> NxenesKurses { get; set; }
        public virtual DbSet<NxenesPagesa> NxenesPagesas { get; set; }
        public virtual DbSet<Pagesa> Pagesas { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Prinder> Prinders { get; set; }
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

            modelBuilder.Entity<NxenesKurse>()
                .HasOptional(nk => nk.Nxene)
                .WithMany(n => n.NxenesKurses)
                .HasForeignKey(nk => nk.NxenesId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Nxene>()
                .Property(e => e.Klasa)
                .IsUnicode(false);

            modelBuilder.Entity<Pagesa>()
                .Property(e => e.FormaPageses)
                .IsUnicode(false);

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

            modelBuilder.Entity<Shkolla>()
                .Property(e => e.ShkollaEmri)
                .IsUnicode(false);

            modelBuilder.Entity<Shkolla>()
                .Property(e => e.ShkollaTipi)
                .IsUnicode(false);
        }
    }
}
