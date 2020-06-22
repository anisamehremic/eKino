using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eKino.WebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "FilmskeUloge",
                columns: table => new
                {
                    FilmskaUlogaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 30, nullable: false),
                    Opis = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmskeUloge", x => x.FilmskaUlogaID);
                });

            migrationBuilder.CreateTable(
                name: "Gledaoci",
                columns: table => new
                {
                    GledalacID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Telefon = table.Column<string>(maxLength: 20, nullable: false),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(maxLength: 500, nullable: false),
                    LozinkaSalt = table.Column<string>(maxLength: 500, nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gledaoci", x => x.GledalacID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Telefon = table.Column<string>(maxLength: 20, nullable: true),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(maxLength: 500, nullable: false),
                    LozinkaSalt = table.Column<string>(maxLength: 500, nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikID);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    SalaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 20, nullable: false),
                    BrojSjedista = table.Column<int>(nullable: false),
                    Opis = table.Column<string>(maxLength: 50, nullable: true),
                    Slika = table.Column<byte[]>(nullable: false),
                    SlikaThumb = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.SalaID);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 30, nullable: false),
                    Opis = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaID);
                });

            migrationBuilder.CreateTable(
                name: "VrsteProjekcije",
                columns: table => new
                {
                    VrstaProjekcijeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 10, nullable: false),
                    Opis = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrsteProjekcije", x => x.VrstaProjekcijeId);
                });

            migrationBuilder.CreateTable(
                name: "Zanrovi",
                columns: table => new
                {
                    ZanrID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 20, nullable: false),
                    Opis = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zanrovi", x => x.ZanrID);
                });

            migrationBuilder.CreateTable(
                name: "Filmovi",
                columns: table => new
                {
                    FilmID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    DatumSnimanja = table.Column<DateTime>(type: "datetime", nullable: false),
                    Opis = table.Column<string>(maxLength: 2000, nullable: false),
                    Trajanje = table.Column<int>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: false),
                    SlikaThumb = table.Column<byte[]>(nullable: false),
                    DrzavaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmovi", x => x.FilmID);
                    table.ForeignKey(
                        name: "FK_Filmovi_Drzave",
                        column: x => x.DrzavaID,
                        principalTable: "Drzave",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmskeLicnosti",
                columns: table => new
                {
                    FilmskaLicnostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    Slika = table.Column<byte[]>(nullable: false),
                    SlikaThumb = table.Column<byte[]>(nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime", nullable: false),
                    DrzavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmskeLicnosti", x => x.FilmskaLicnostID);
                    table.ForeignKey(
                        name: "FK_FilmskeLicnosti_Drzave",
                        column: x => x.DrzavaId,
                        principalTable: "Drzave",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Novosti",
                columns: table => new
                {
                    NovostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(maxLength: 500, nullable: false),
                    Sadrzaj = table.Column<string>(maxLength: 2000, nullable: false),
                    DatumObjave = table.Column<DateTime>(type: "datetime", nullable: false),
                    KorisnikID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novosti", x => x.NovostID);
                    table.ForeignKey(
                        name: "FK_Novosti_Korisnici",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sjedista",
                columns: table => new
                {
                    SjedisteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(maxLength: 50, nullable: true),
                    SalaID = table.Column<int>(nullable: false),
                    Red = table.Column<string>(maxLength: 10, nullable: false),
                    Kolona = table.Column<string>(maxLength: 10, nullable: false),
                    Zauzeto = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sjedista", x => x.SjedisteID);
                    table.ForeignKey(
                        name: "FK_Sjedista_Sale",
                        column: x => x.SalaID,
                        principalTable: "Sale",
                        principalColumn: "SalaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisnickeUloge",
                columns: table => new
                {
                    KorisnikUlogaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(nullable: false),
                    UlogaID = table.Column<int>(nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnickeUloge", x => x.KorisnikUlogaID);
                    table.ForeignKey(
                        name: "FK_KorisnickeUloge_Korisnici",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KorisnickeUloge_Uloge",
                        column: x => x.UlogaID,
                        principalTable: "Uloge",
                        principalColumn: "UlogaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pretplate",
                columns: table => new
                {
                    PretplataID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZanrID = table.Column<int>(nullable: false),
                    GledalacID = table.Column<int>(nullable: false),
                    DatumPretplate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Otkazana = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pretplate", x => x.PretplataID);
                    table.ForeignKey(
                        name: "FK_Pretplate_Gledaoci",
                        column: x => x.GledalacID,
                        principalTable: "Gledaoci",
                        principalColumn: "GledalacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pretplate_Zanrovi",
                        column: x => x.ZanrID,
                        principalTable: "Zanrovi",
                        principalColumn: "ZanrID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmoviZanrovi",
                columns: table => new
                {
                    FilmZanrID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmID = table.Column<int>(nullable: false),
                    ZanrID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmoviZanrovi", x => x.FilmZanrID);
                    table.ForeignKey(
                        name: "FK_FilmoviZanrovi_Filmovi",
                        column: x => x.FilmID,
                        principalTable: "Filmovi",
                        principalColumn: "FilmID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FilmoviZanrovi_Zanrovi",
                        column: x => x.ZanrID,
                        principalTable: "Zanrovi",
                        principalColumn: "ZanrID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    OcjenaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmID = table.Column<int>(nullable: false),
                    GledalacID = table.Column<int>(nullable: false),
                    Ocjena = table.Column<int>(nullable: false),
                    DatumOcjenjivanja = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjene", x => x.OcjenaID);
                    table.ForeignKey(
                        name: "FK_Ocjene_Gledaoci",
                        column: x => x.FilmID,
                        principalTable: "Filmovi",
                        principalColumn: "FilmID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ocjene_Gledaoc",
                        column: x => x.GledalacID,
                        principalTable: "Gledaoci",
                        principalColumn: "GledalacID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projekcije",
                columns: table => new
                {
                    ProjekcijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmID = table.Column<int>(nullable: false),
                    SalaID = table.Column<int>(nullable: false),
                    DatumVrijemeOdrzavanja = table.Column<DateTime>(type: "datetime", nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    VrstaProjekcijeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekcije", x => x.ProjekcijaID);
                    table.ForeignKey(
                        name: "FK_Projekcije_Filmovi",
                        column: x => x.FilmID,
                        principalTable: "Filmovi",
                        principalColumn: "FilmID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projekcije_Sale",
                        column: x => x.SalaID,
                        principalTable: "Sale",
                        principalColumn: "SalaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projekcije_VrsteProjekcije",
                        column: x => x.VrstaProjekcijeId,
                        principalTable: "VrsteProjekcije",
                        principalColumn: "VrstaProjekcijeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmoviFilmskeLicnosti",
                columns: table => new
                {
                    FilmFilmskaLicnostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmID = table.Column<int>(nullable: false),
                    FilmskaLicnostID = table.Column<int>(nullable: false),
                    FilmskaUlogaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmoviFilmskeLicnosti", x => x.FilmFilmskaLicnostID);
                    table.ForeignKey(
                        name: "FK_FilmoviFilmskeLicnosti_Filmovi",
                        column: x => x.FilmID,
                        principalTable: "Filmovi",
                        principalColumn: "FilmID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FilmoviFilmskeLicnosti_FilmskeLicnosti",
                        column: x => x.FilmskaLicnostID,
                        principalTable: "FilmskeLicnosti",
                        principalColumn: "FilmskaLicnostID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FilmoviFilmskeLicnosti_FilmskeUloge",
                        column: x => x.FilmskaUlogaID,
                        principalTable: "FilmskeUloge",
                        principalColumn: "FilmskaUlogaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notifikacije",
                columns: table => new
                {
                    NotifikacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NovostID = table.Column<int>(nullable: true),
                    Naslov = table.Column<string>(maxLength: 200, nullable: true),
                    DatumSlanja = table.Column<DateTime>(type: "datetime", nullable: false),
                    GledalacID = table.Column<int>(nullable: false),
                    Procitana = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikacije", x => x.NotifikacijaID);
                    table.ForeignKey(
                        name: "FK_Notifikacije_Gledaoci",
                        column: x => x.GledalacID,
                        principalTable: "Gledaoci",
                        principalColumn: "GledalacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifikacije_Novosti",
                        column: x => x.NovostID,
                        principalTable: "Novosti",
                        principalColumn: "NovostID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacije",
                columns: table => new
                {
                    RezervacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GledalacID = table.Column<int>(nullable: true),
                    ProjekcijaID = table.Column<int>(nullable: false),
                    DatumRezervacije = table.Column<DateTime>(type: "datetime", nullable: false),
                    BrojKarata = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: true),
                    Cijena = table.Column<decimal>(type: "decimal(5, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacije", x => x.RezervacijaID);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Gledaoci",
                        column: x => x.GledalacID,
                        principalTable: "Gledaoci",
                        principalColumn: "GledalacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Projekcije",
                        column: x => x.ProjekcijaID,
                        principalTable: "Projekcije",
                        principalColumn: "ProjekcijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ulaznice",
                columns: table => new
                {
                    UlaznicaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezervacijaId = table.Column<int>(nullable: true),
                    ProjekcijaId = table.Column<int>(nullable: false),
                    QRcode = table.Column<byte[]>(nullable: false),
                    SjedisteId = table.Column<int>(nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    Status = table.Column<bool>(nullable: true),
                    GledalacId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulaznice", x => x.UlaznicaId);
                    table.ForeignKey(
                        name: "FK_Ulaznice_Projekcije",
                        column: x => x.ProjekcijaId,
                        principalTable: "Projekcije",
                        principalColumn: "ProjekcijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ulaznice_Rezervacije",
                        column: x => x.RezervacijaId,
                        principalTable: "Rezervacije",
                        principalColumn: "RezervacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ulaznice_Sjedista",
                        column: x => x.SjedisteId,
                        principalTable: "Sjedista",
                        principalColumn: "SjedisteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmovi_DrzavaID",
                table: "Filmovi",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_FilmoviFilmskeLicnosti_FilmID",
                table: "FilmoviFilmskeLicnosti",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_FilmoviFilmskeLicnosti_FilmskaLicnostID",
                table: "FilmoviFilmskeLicnosti",
                column: "FilmskaLicnostID");

            migrationBuilder.CreateIndex(
                name: "IX_FilmoviFilmskeLicnosti_FilmskaUlogaID",
                table: "FilmoviFilmskeLicnosti",
                column: "FilmskaUlogaID");

            migrationBuilder.CreateIndex(
                name: "IX_FilmoviZanrovi_FilmID",
                table: "FilmoviZanrovi",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_FilmoviZanrovi_ZanrID",
                table: "FilmoviZanrovi",
                column: "ZanrID");

            migrationBuilder.CreateIndex(
                name: "IX_FilmskeLicnosti_DrzavaId",
                table: "FilmskeLicnosti",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "UQ_Email",
                table: "Gledaoci",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ_G_KorisnickoIme",
                table: "Gledaoci",
                column: "KorisnickoIme",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_K_Email",
                table: "Korisnici",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ_KorisnickoIme",
                table: "Korisnici",
                column: "KorisnickoIme",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KorisnickeUloge_KorisnikID",
                table: "KorisnickeUloge",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnickeUloge_UlogaID",
                table: "KorisnickeUloge",
                column: "UlogaID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacije_GledalacID",
                table: "Notifikacije",
                column: "GledalacID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacije_NovostID",
                table: "Notifikacije",
                column: "NovostID");

            migrationBuilder.CreateIndex(
                name: "IX_Novosti_KorisnikID",
                table: "Novosti",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_FilmID",
                table: "Ocjene",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_GledalacID",
                table: "Ocjene",
                column: "GledalacID");

            migrationBuilder.CreateIndex(
                name: "IX_Pretplate_GledalacID",
                table: "Pretplate",
                column: "GledalacID");

            migrationBuilder.CreateIndex(
                name: "IX_Pretplate_ZanrID",
                table: "Pretplate",
                column: "ZanrID");

            migrationBuilder.CreateIndex(
                name: "IX_Projekcije_FilmID",
                table: "Projekcije",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Projekcije_SalaID",
                table: "Projekcije",
                column: "SalaID");

            migrationBuilder.CreateIndex(
                name: "IX_Projekcije_VrstaProjekcijeId",
                table: "Projekcije",
                column: "VrstaProjekcijeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_GledalacID",
                table: "Rezervacije",
                column: "GledalacID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_ProjekcijaID",
                table: "Rezervacije",
                column: "ProjekcijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Sjedista_SalaID",
                table: "Sjedista",
                column: "SalaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ulaznice_ProjekcijaId",
                table: "Ulaznice",
                column: "ProjekcijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ulaznice_RezervacijaId",
                table: "Ulaznice",
                column: "RezervacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ulaznice_SjedisteId",
                table: "Ulaznice",
                column: "SjedisteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmoviFilmskeLicnosti");

            migrationBuilder.DropTable(
                name: "FilmoviZanrovi");

            migrationBuilder.DropTable(
                name: "KorisnickeUloge");

            migrationBuilder.DropTable(
                name: "Notifikacije");

            migrationBuilder.DropTable(
                name: "Ocjene");

            migrationBuilder.DropTable(
                name: "Pretplate");

            migrationBuilder.DropTable(
                name: "Ulaznice");

            migrationBuilder.DropTable(
                name: "FilmskeLicnosti");

            migrationBuilder.DropTable(
                name: "FilmskeUloge");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Novosti");

            migrationBuilder.DropTable(
                name: "Zanrovi");

            migrationBuilder.DropTable(
                name: "Rezervacije");

            migrationBuilder.DropTable(
                name: "Sjedista");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Gledaoci");

            migrationBuilder.DropTable(
                name: "Projekcije");

            migrationBuilder.DropTable(
                name: "Filmovi");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "VrsteProjekcije");

            migrationBuilder.DropTable(
                name: "Drzave");
        }
    }
}
