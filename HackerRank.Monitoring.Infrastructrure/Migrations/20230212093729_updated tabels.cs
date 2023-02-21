using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackerRank.Monitoring.Infrastructrure.Migrations
{
    /// <inheritdoc />
    public partial class updatedtabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_algorithm_Questions_topics_TopicsTopic_Id",
                table: "algorithm_Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_dataStructure_Questions_topics_TopicsTopic_Id",
                table: "dataStructure_Questions");

            migrationBuilder.DropIndex(
                name: "IX_dataStructure_Questions_TopicsTopic_Id",
                table: "dataStructure_Questions");

            migrationBuilder.DropIndex(
                name: "IX_algorithm_Questions_TopicsTopic_Id",
                table: "algorithm_Questions");

            migrationBuilder.DropColumn(
                name: "TopicsTopic_Id",
                table: "dataStructure_Questions");

            migrationBuilder.DropColumn(
                name: "TopicsTopic_Id",
                table: "algorithm_Questions");

            migrationBuilder.CreateIndex(
                name: "IX_dataStructure_Questions_Topic_Id",
                table: "dataStructure_Questions",
                column: "Topic_Id");

            migrationBuilder.CreateIndex(
                name: "IX_algorithm_Questions_Topic_Id",
                table: "algorithm_Questions",
                column: "Topic_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_algorithm_Questions_topics_Topic_Id",
                table: "algorithm_Questions",
                column: "Topic_Id",
                principalTable: "topics",
                principalColumn: "Topic_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dataStructure_Questions_topics_Topic_Id",
                table: "dataStructure_Questions",
                column: "Topic_Id",
                principalTable: "topics",
                principalColumn: "Topic_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_algorithm_Questions_topics_Topic_Id",
                table: "algorithm_Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_dataStructure_Questions_topics_Topic_Id",
                table: "dataStructure_Questions");

            migrationBuilder.DropIndex(
                name: "IX_dataStructure_Questions_Topic_Id",
                table: "dataStructure_Questions");

            migrationBuilder.DropIndex(
                name: "IX_algorithm_Questions_Topic_Id",
                table: "algorithm_Questions");

            migrationBuilder.AddColumn<int>(
                name: "TopicsTopic_Id",
                table: "dataStructure_Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TopicsTopic_Id",
                table: "algorithm_Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_dataStructure_Questions_TopicsTopic_Id",
                table: "dataStructure_Questions",
                column: "TopicsTopic_Id");

            migrationBuilder.CreateIndex(
                name: "IX_algorithm_Questions_TopicsTopic_Id",
                table: "algorithm_Questions",
                column: "TopicsTopic_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_algorithm_Questions_topics_TopicsTopic_Id",
                table: "algorithm_Questions",
                column: "TopicsTopic_Id",
                principalTable: "topics",
                principalColumn: "Topic_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dataStructure_Questions_topics_TopicsTopic_Id",
                table: "dataStructure_Questions",
                column: "TopicsTopic_Id",
                principalTable: "topics",
                principalColumn: "Topic_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
