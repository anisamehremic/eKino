using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eKino.WebAPI.Database
{
    public partial class eKinoContext : DbContext
    {
        public eKinoContext()
        {
        }

        public eKinoContext(DbContextOptions<eKinoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Drzave> Drzave { get; set; }
        public virtual DbSet<Filmovi> Filmovi { get; set; }
        public virtual DbSet<FilmoviFilmskeLicnosti> FilmoviFilmskeLicnosti { get; set; }
        public virtual DbSet<FilmoviZanrovi> FilmoviZanrovi { get; set; }
        public virtual DbSet<FilmskeLicnosti> FilmskeLicnosti { get; set; }
        public virtual DbSet<FilmskeUloge> FilmskeUloge { get; set; }
        public virtual DbSet<Gledaoci> Gledaoci { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<KorisnickeUloge> KorisnickeUloge { get; set; }
        public virtual DbSet<Notifikacije> Notifikacije { get; set; }
        public virtual DbSet<Novosti> Novosti { get; set; }
        public virtual DbSet<Ocjene> Ocjene { get; set; }
        public virtual DbSet<Pretplate> Pretplate { get; set; }
        public virtual DbSet<Projekcije> Projekcije { get; set; }
        public virtual DbSet<Rezervacije> Rezervacije { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<Sjedista> Sjedista { get; set; }
        public virtual DbSet<Ulaznice> Ulaznice { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
        public virtual DbSet<VrsteProjekcije> VrsteProjekcije { get; set; }
        public virtual DbSet<Zanrovi> Zanrovi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=eKino;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drzave>(entity =>
            {
                entity.HasKey(e => e.DrzavaId);

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Filmovi>(entity =>
            {
                entity.HasKey(e => e.FilmId);

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.Property(e => e.DatumSnimanja).HasColumnType("datetime");

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Slika).IsRequired();

                entity.Property(e => e.SlikaThumb).IsRequired();

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Filmovi)
                    .HasForeignKey(d => d.DrzavaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Filmovi_Drzave");
            });

            modelBuilder.Entity<FilmoviFilmskeLicnosti>(entity =>
            {
                entity.HasKey(e => e.FilmFilmskaLicnostId);

                entity.Property(e => e.FilmFilmskaLicnostId).HasColumnName("FilmFilmskaLicnostID");

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.Property(e => e.FilmskaLicnostId).HasColumnName("FilmskaLicnostID");

                entity.Property(e => e.FilmskaUlogaId).HasColumnName("FilmskaUlogaID");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmoviFilmskeLicnosti)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilmoviFilmskeLicnosti_Filmovi");

                entity.HasOne(d => d.FilmskaLicnost)
                    .WithMany(p => p.FilmoviFilmskeLicnosti)
                    .HasForeignKey(d => d.FilmskaLicnostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilmoviFilmskeLicnosti_FilmskeLicnosti");

                entity.HasOne(d => d.FilmskaUloga)
                    .WithMany(p => p.FilmoviFilmskeLicnosti)
                    .HasForeignKey(d => d.FilmskaUlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilmoviFilmskeLicnosti_FilmskeUloge");
            });

            modelBuilder.Entity<FilmoviZanrovi>(entity =>
            {
                entity.HasKey(e => e.FilmZanrId);

                entity.Property(e => e.FilmZanrId).HasColumnName("FilmZanrID");

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.Property(e => e.ZanrId).HasColumnName("ZanrID");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmoviZanrovi)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilmoviZanrovi_Filmovi");

                entity.HasOne(d => d.Zanr)
                    .WithMany(p => p.FilmoviZanrovi)
                    .HasForeignKey(d => d.ZanrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilmoviZanrovi_Zanrovi");
            });

            modelBuilder.Entity<FilmskeLicnosti>(entity =>
            {
                entity.HasKey(e => e.FilmskaLicnostId);

                entity.Property(e => e.FilmskaLicnostId).HasColumnName("FilmskaLicnostID");

                entity.Property(e => e.DatumRodjenja).HasColumnType("datetime");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Slika).IsRequired();

                entity.Property(e => e.SlikaThumb).IsRequired();

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.FilmskeLicnosti)
                    .HasForeignKey(d => d.DrzavaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilmskeLicnosti_Drzave");
            });

            modelBuilder.Entity<FilmskeUloge>(entity =>
            {
                entity.HasKey(e => e.FilmskaUlogaId);

                entity.Property(e => e.FilmskaUlogaId).HasColumnName("FilmskaUlogaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Opis).HasMaxLength(100);
            });

            modelBuilder.Entity<Gledaoci>(entity =>
            {
                entity.HasKey(e => e.GledalacId);

                entity.HasIndex(e => e.Email)
                    .HasName("UQ_Email")
                    .IsUnique();

                entity.HasIndex(e => e.KorisnickoIme)
                    .HasName("UQ_G_KorisnickoIme")
                    .IsUnique();

                entity.Property(e => e.GledalacId).HasColumnName("GledalacID");

                entity.Property(e => e.DatumRodjenja).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(500);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.HasIndex(e => e.Email)
                    .HasName("UQ_K_Email")
                    .IsUnique();

                entity.HasIndex(e => e.KorisnickoIme)
                    .HasName("UQ_KorisnickoIme")
                    .IsUnique();

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.DatumRodjenja).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(500);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(20);
            });

            modelBuilder.Entity<KorisnickeUloge>(entity =>
            {
                entity.HasKey(e => e.KorisnikUlogaId);

                entity.Property(e => e.KorisnikUlogaId).HasColumnName("KorisnikUlogaID");

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisnickeUloge)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisnickeUloge_Korisnici");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisnickeUloge)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisnickeUloge_Uloge");
            });

            modelBuilder.Entity<Notifikacije>(entity =>
            {
                entity.HasKey(e => e.NotifikacijaId);

                entity.Property(e => e.NotifikacijaId).HasColumnName("NotifikacijaID");

                entity.Property(e => e.DatumSlanja).HasColumnType("datetime");

                entity.Property(e => e.GledalacId).HasColumnName("GledalacID");

                entity.Property(e => e.Naslov).HasMaxLength(200);

                entity.Property(e => e.NovostId).HasColumnName("NovostID");

                entity.HasOne(d => d.Gledalac)
                    .WithMany(p => p.Notifikacije)
                    .HasForeignKey(d => d.GledalacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notifikacije_Gledaoci");

                entity.HasOne(d => d.Novost)
                    .WithMany(p => p.Notifikacije)
                    .HasForeignKey(d => d.NovostId)
                    .HasConstraintName("FK_Notifikacije_Novosti");
            });

            modelBuilder.Entity<Novosti>(entity =>
            {
                entity.HasKey(e => e.NovostId);

                entity.Property(e => e.NovostId).HasColumnName("NovostID");

                entity.Property(e => e.DatumObjave).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Naslov)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Sadrzaj)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Novosti)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Novosti_Korisnici");
            });

            modelBuilder.Entity<Ocjene>(entity =>
            {
                entity.HasKey(e => e.OcjenaId);

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.DatumOcjenjivanja).HasColumnType("datetime");

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.Property(e => e.GledalacId).HasColumnName("GledalacID");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ocjene_Gledaoci");

                entity.HasOne(d => d.Gledalac)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.GledalacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ocjene_Gledaoc");
            });

            modelBuilder.Entity<Pretplate>(entity =>
            {
                entity.HasKey(e => e.PretplataId);

                entity.Property(e => e.PretplataId).HasColumnName("PretplataID");

                entity.Property(e => e.DatumPretplate).HasColumnType("datetime");

                entity.Property(e => e.GledalacId).HasColumnName("GledalacID");

                entity.Property(e => e.ZanrId).HasColumnName("ZanrID");

                entity.HasOne(d => d.Gledalac)
                    .WithMany(p => p.Pretplate)
                    .HasForeignKey(d => d.GledalacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pretplate_Gledaoci");

                entity.HasOne(d => d.Zanr)
                    .WithMany(p => p.Pretplate)
                    .HasForeignKey(d => d.ZanrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pretplate_Zanrovi");
            });

            modelBuilder.Entity<Projekcije>(entity =>
            {
                entity.HasKey(e => e.ProjekcijaId);

                entity.Property(e => e.ProjekcijaId).HasColumnName("ProjekcijaID");

                entity.Property(e => e.Cijena).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DatumVrijemeOdrzavanja).HasColumnType("datetime");

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.Property(e => e.SalaId).HasColumnName("SalaID");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.Projekcije)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projekcije_Filmovi");

                entity.HasOne(d => d.Sala)
                    .WithMany(p => p.Projekcije)
                    .HasForeignKey(d => d.SalaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projekcije_Sale");

                entity.HasOne(d => d.VrstaProjekcije)
                    .WithMany(p => p.Projekcije)
                    .HasForeignKey(d => d.VrstaProjekcijeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projekcije_VrsteProjekcije");
            });

            modelBuilder.Entity<Rezervacije>(entity =>
            {
                entity.HasKey(e => e.RezervacijaId);

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.Property(e => e.Cijena).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DatumRezervacije).HasColumnType("datetime");

                entity.Property(e => e.GledalacId).HasColumnName("GledalacID");

                entity.Property(e => e.ProjekcijaId).HasColumnName("ProjekcijaID");

                entity.HasOne(d => d.Gledalac)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.GledalacId)
                    .HasConstraintName("FK_Rezervacije_Gledaoci");

                entity.HasOne(d => d.Projekcija)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.ProjekcijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacije_Projekcije");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => e.SalaId);

                entity.Property(e => e.SalaId).HasColumnName("SalaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Opis).HasMaxLength(50);

                entity.Property(e => e.Slika).IsRequired();

                entity.Property(e => e.SlikaThumb).IsRequired();
            });

            modelBuilder.Entity<Sjedista>(entity =>
            {
                entity.HasKey(e => e.SjedisteId);

                entity.Property(e => e.SjedisteId).HasColumnName("SjedisteID");

                entity.Property(e => e.Kolona)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Opis).HasMaxLength(50);

                entity.Property(e => e.Red)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SalaId).HasColumnName("SalaID");

                entity.HasOne(d => d.Sala)
                    .WithMany(p => p.Sjedista)
                    .HasForeignKey(d => d.SalaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sjedista_Sale");
            });

            modelBuilder.Entity<Ulaznice>(entity =>
            {
                entity.HasKey(e => e.UlaznicaId);

                entity.Property(e => e.Cijena).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Qrcode)
                    .IsRequired()
                    .HasColumnName("QRcode");

                entity.HasOne(d => d.Projekcija)
                    .WithMany(p => p.Ulaznice)
                    .HasForeignKey(d => d.ProjekcijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ulaznice_Projekcije");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.Ulaznice)
                    .HasForeignKey(d => d.RezervacijaId)
                    .HasConstraintName("FK_Ulaznice_Rezervacije");

                entity.HasOne(d => d.Sjediste)
                    .WithMany(p => p.Ulaznice)
                    .HasForeignKey(d => d.SjedisteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ulaznice_Sjedista");
            });

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.HasKey(e => e.UlogaId);

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Opis).HasMaxLength(100);
            });

            modelBuilder.Entity<VrsteProjekcije>(entity =>
            {
                entity.HasKey(e => e.VrstaProjekcijeId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Opis).HasMaxLength(500);
            });

            modelBuilder.Entity<Zanrovi>(entity =>
            {
                entity.HasKey(e => e.ZanrId);

                entity.Property(e => e.ZanrId).HasColumnName("ZanrID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Opis).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
