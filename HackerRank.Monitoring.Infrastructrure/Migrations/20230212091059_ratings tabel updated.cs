using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackerRank.Monitoring.Infrastructrure.Migrations
{
    /// <inheritdoc />
    public partial class ratingstabelupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ratings_topics_TopicsTopic_Id",
                table: "ratings");

            migrationBuilder.DropIndex(
                name: "IX_ratings_TopicsTopic_Id",
                table: "ratings");

            migrationBuilder.DropColumn(
                name: "TopicsTopic_Id",
                table: "ratings");

            migrationBuilder.CreateIndex(
                name: "IX_ratings_Topic_Id",
                table: "ratings",
                column: "Topic_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ratings_topics_Topic_Id",
                table: "ratings",
                column: "Topic_Id",
                principalTable: "topics",
                principalColumn: "Topic_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ratings_topics_Topic_Id",
                table: "ratings");

            migrationBuilder.DropIndex(
                name: "IX_ratings_Topic_Id",
                table: "ratings");

            migrationBuilder.AddColumn<int>(
                name: "TopicsTopic_Id",
                table: "ratings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ratings_TopicsTopic_Id",
                table: "ratings",
                column: "TopicsTopic_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ratings_topics_TopicsTopic_Id",
                table: "ratings",
                column: "TopicsTopic_Id",
                principalTable: "topics",
                principalColumn: "Topic_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
