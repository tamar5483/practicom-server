using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Context.Migrations
{
    /// <inheritdoc />
    public partial class Translations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Kupach",
                table: "Users",
                newName: "HMO");

            migrationBuilder.RenameColumn(
                name: "Kind",
                table: "Users",
                newName: "Gender");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HMO",
                table: "Users",
                newName: "Kupach");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Users",
                newName: "Kind");
        }
    }
}
