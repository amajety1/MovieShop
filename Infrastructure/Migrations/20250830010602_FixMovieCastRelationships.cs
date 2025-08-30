using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixMovieCastRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieCasts_Casts_CastId1",
                table: "MovieCasts");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCasts_Movies_MovieId1",
                table: "MovieCasts");

            migrationBuilder.DropIndex(
                name: "IX_MovieCasts_CastId1",
                table: "MovieCasts");

            migrationBuilder.DropIndex(
                name: "IX_MovieCasts_MovieId1",
                table: "MovieCasts");

            migrationBuilder.DropColumn(
                name: "CastId1",
                table: "MovieCasts");

            migrationBuilder.DropColumn(
                name: "MovieId1",
                table: "MovieCasts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CastId1",
                table: "MovieCasts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieId1",
                table: "MovieCasts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovieCasts_CastId1",
                table: "MovieCasts",
                column: "CastId1");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCasts_MovieId1",
                table: "MovieCasts",
                column: "MovieId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCasts_Casts_CastId1",
                table: "MovieCasts",
                column: "CastId1",
                principalTable: "Casts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCasts_Movies_MovieId1",
                table: "MovieCasts",
                column: "MovieId1",
                principalTable: "Movies",
                principalColumn: "Id");
        }
    }
}
