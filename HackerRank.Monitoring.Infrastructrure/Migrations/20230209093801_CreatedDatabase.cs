using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackerRank.Monitoring.Infrastructrure.Migrations
{
    /// <inheritdoc />
    public partial class CreatedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hackerRank_Profiles",
                columns: table => new
                {
                    UserId = table.Column<int>(name: "User_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HRUserName = table.Column<string>(name: "HR_UserName", type: "nvarchar(max)", nullable: true),
                    HREmail = table.Column<string>(name: "HR_Email", type: "nvarchar(max)", nullable: false),
                    HRBadges = table.Column<int>(name: "HR_Badges", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hackerRank_Profiles", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "topics",
                columns: table => new
                {
                    TopicId = table.Column<int>(name: "Topic_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topics", x => x.TopicId);
                });

            migrationBuilder.CreateTable(
                name: "algorithm_Questions",
                columns: table => new
                {
                    QusId = table.Column<int>(name: "Qus_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QusLevel = table.Column<string>(name: "Qus_Level", type: "nvarchar(max)", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopicId = table.Column<int>(name: "Topic_Id", type: "int", nullable: false),
                    TopicsTopicId = table.Column<int>(name: "TopicsTopic_Id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_algorithm_Questions", x => x.QusId);
                    table.ForeignKey(
                        name: "FK_algorithm_Questions_topics_TopicsTopic_Id",
                        column: x => x.TopicsTopicId,
                        principalTable: "topics",
                        principalColumn: "Topic_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dataStructure_Questions",
                columns: table => new
                {
                    QusId = table.Column<int>(name: "Qus_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QusLevel = table.Column<string>(name: "Qus_Level", type: "nvarchar(max)", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopicId = table.Column<int>(name: "Topic_Id", type: "int", nullable: false),
                    TopicsTopicId = table.Column<int>(name: "TopicsTopic_Id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dataStructure_Questions", x => x.QusId);
                    table.ForeignKey(
                        name: "FK_dataStructure_Questions_topics_TopicsTopic_Id",
                        column: x => x.TopicsTopicId,
                        principalTable: "topics",
                        principalColumn: "Topic_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(name: "Rating_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubmittedDate = table.Column<DateTime>(name: "Submitted_Date", type: "datetime2", nullable: false),
                    TimeTook = table.Column<string>(name: "Time_Took", type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopicId = table.Column<int>(name: "Topic_Id", type: "int", nullable: false),
                    TopicsTopicId = table.Column<int>(name: "TopicsTopic_Id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_ratings_topics_TopicsTopic_Id",
                        column: x => x.TopicsTopicId,
                        principalTable: "topics",
                        principalColumn: "Topic_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_algorithm_Questions_TopicsTopic_Id",
                table: "algorithm_Questions",
                column: "TopicsTopic_Id");

            migrationBuilder.CreateIndex(
                name: "IX_dataStructure_Questions_TopicsTopic_Id",
                table: "dataStructure_Questions",
                column: "TopicsTopic_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ratings_TopicsTopic_Id",
                table: "ratings",
                column: "TopicsTopic_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "algorithm_Questions");

            migrationBuilder.DropTable(
                name: "dataStructure_Questions");

            migrationBuilder.DropTable(
                name: "hackerRank_Profiles");

            migrationBuilder.DropTable(
                name: "ratings");

            migrationBuilder.DropTable(
                name: "topics");
        }
    }
}
