using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackerRank.Monitoring.Infrastructrure.Migrations
{
    /// <inheritdoc />
    public partial class updatedratingstabel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ratings_dataStructure_Questions_Qus_Id",
                table: "ratings");

            migrationBuilder.AlterColumn<int>(
                name: "Qus_Id",
                table: "ratings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ratings_dataStructure_Questions_Qus_Id",
                table: "ratings",
                column: "Qus_Id",
                principalTable: "dataStructure_Questions",
                principalColumn: "Qus_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ratings_dataStructure_Questions_Qus_Id",
                table: "ratings");

            migrationBuilder.AlterColumn<int>(
                name: "Qus_Id",
                table: "ratings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ratings_dataStructure_Questions_Qus_Id",
                table: "ratings",
                column: "Qus_Id",
                principalTable: "dataStructure_Questions",
                principalColumn: "Qus_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
