using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pp_lab4_2.Migrations
{
    /// <inheritdoc />
    public partial class TotalRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "Movies",
                newName: "TotalRate");

            migrationBuilder.AddColumn<float>(
                name: "RatingCount",
                table: "Movies",
                type: "real"
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RatingCount",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "TotalRate",
                table: "Movies",
                newName: "Rate");
        }
    }
}
