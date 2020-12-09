using Microsoft.EntityFrameworkCore.Migrations;

namespace podaci.Migrations
{
    public partial class NovekoloneuPrisustvuNaNastavi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPrisutan",
                table: "PrisustvoNaNastavi",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Komentar",
                table: "PrisustvoNaNastavi",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPrisutan",
                table: "PrisustvoNaNastavi");

            migrationBuilder.DropColumn(
                name: "Komentar",
                table: "PrisustvoNaNastavi");
        }
    }
}
