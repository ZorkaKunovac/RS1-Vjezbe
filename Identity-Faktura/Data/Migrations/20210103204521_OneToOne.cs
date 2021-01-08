using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class OneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ime",
                table: "Studenti");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "Studenti");

            migrationBuilder.DropColumn(
                name: "Ime",
                table: "Nastavnici");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "Nastavnici");

            migrationBuilder.AddColumn<string>(
                name: "KorisnikID",
                table: "Studenti",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KorisnikID",
                table: "Nastavnici",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Studenti_KorisnikID",
                table: "Studenti",
                column: "KorisnikID",
                unique: true,
                filter: "[KorisnikID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Nastavnici_KorisnikID",
                table: "Nastavnici",
                column: "KorisnikID",
                unique: true,
                filter: "[KorisnikID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Nastavnici_AspNetUsers_KorisnikID",
                table: "Nastavnici",
                column: "KorisnikID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Studenti_AspNetUsers_KorisnikID",
                table: "Studenti",
                column: "KorisnikID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nastavnici_AspNetUsers_KorisnikID",
                table: "Nastavnici");

            migrationBuilder.DropForeignKey(
                name: "FK_Studenti_AspNetUsers_KorisnikID",
                table: "Studenti");

            migrationBuilder.DropIndex(
                name: "IX_Studenti_KorisnikID",
                table: "Studenti");

            migrationBuilder.DropIndex(
                name: "IX_Nastavnici_KorisnikID",
                table: "Nastavnici");

            migrationBuilder.DropColumn(
                name: "KorisnikID",
                table: "Studenti");

            migrationBuilder.DropColumn(
                name: "KorisnikID",
                table: "Nastavnici");

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "Studenti",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prezime",
                table: "Studenti",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "Nastavnici",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prezime",
                table: "Nastavnici",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
