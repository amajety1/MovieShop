using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IncreaseOverviewLength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Overview",
                table: "Movies",
                type: "varchar(2084)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(512)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Overview",
                table: "Movies",
                type: "varchar(512)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2084)",
                oldNullable: true);
        }
    }
}
