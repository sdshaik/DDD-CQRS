using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackerRank.Monitoring.Infrastructrure.Migrations
{
    /// <inheritdoc />
    public partial class updatedratingstabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Qus_Id",
                table: "ratings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ratings_Qus_Id",
                table: "ratings",
                column: "Qus_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ratings_dataStructure_Questions_Qus_Id",
                table: "ratings",
                column: "Qus_Id",
                principalTable: "dataStructure_Questions",
                principalColumn: "Qus_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ratings_dataStructure_Questions_Qus_Id",
                table: "ratings");

            migrationBuilder.DropIndex(
                name: "IX_ratings_Qus_Id",
                table: "ratings");

            migrationBuilder.DropColumn(
                name: "Qus_Id",
                table: "ratings");
        }
    }
}
