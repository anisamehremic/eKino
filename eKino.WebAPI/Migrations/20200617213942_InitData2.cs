using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eKino.WebAPI.Migrations
{
    public partial class InitData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FilmoviZanrovi",
                columns: new[] { "FilmZanrID", "FilmID", "ZanrID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "KorisnickeUloge",
                columns: new[] { "KorisnikUlogaID", "DatumIzmjene", "KorisnikID", "UlogaID" },
                values: new object[] { 1, new DateTime(2020, 6, 17, 23, 39, 41, 326, DateTimeKind.Local).AddTicks(7102), 1, 1 });

            migrationBuilder.InsertData(
                table: "Pretplate",
                columns: new[] { "PretplataID", "DatumPretplate", "GledalacID", "Otkazana", "ZanrID" },
                values: new object[] { 1, new DateTime(2020, 6, 1, 14, 29, 18, 167, DateTimeKind.Local).AddTicks(8190), 1, false, 1 });

            migrationBuilder.InsertData(
                table: "Projekcije",
                columns: new[] { "ProjekcijaID", "Cijena", "DatumVrijemeOdrzavanja", "FilmID", "SalaID", "VrstaProjekcijeId" },
                values: new object[,]
                {
                    { 1, 5m, new DateTime(2020, 7, 1, 14, 29, 18, 167, DateTimeKind.Local).AddTicks(8190), 1, 1, 1 },
                    { 2, 5m, new DateTime(2020, 7, 1, 14, 29, 18, 167, DateTimeKind.Local).AddTicks(8190), 2, 1, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmoviZanrovi",
                keyColumn: "FilmZanrID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FilmoviZanrovi",
                keyColumn: "FilmZanrID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KorisnickeUloge",
                keyColumn: "KorisnikUlogaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pretplate",
                keyColumn: "PretplataID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projekcije",
                keyColumn: "ProjekcijaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projekcije",
                keyColumn: "ProjekcijaID",
                keyValue: 2);
        }
    }
}
