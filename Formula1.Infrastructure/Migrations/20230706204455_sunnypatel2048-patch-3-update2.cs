using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Formula1.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sunnypatel2048patch3update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Base",
                table: "Teams",
                newName: "BaseCountry");

            migrationBuilder.AddColumn<string>(
                name: "BaseCity",
                table: "Teams",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseCity",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "BaseCountry",
                table: "Teams",
                newName: "Base");
        }
    }
}
