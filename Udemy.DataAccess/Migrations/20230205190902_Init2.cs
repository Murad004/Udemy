using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Udemy.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Requirements",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requirements_CourseId",
                table: "Requirements",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requirements_Courses_CourseId",
                table: "Requirements",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requirements_Courses_CourseId",
                table: "Requirements");

            migrationBuilder.DropIndex(
                name: "IX_Requirements_CourseId",
                table: "Requirements");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Requirements");
        }
    }
}
