using Microsoft.EntityFrameworkCore.Migrations;

namespace TechJobsPersistent.Migrations
{
    public partial class newTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "Employers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employers_EmployerId",
                table: "Employers",
                column: "EmployerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employers_Employers_EmployerId",
                table: "Employers",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employers_Employers_EmployerId",
                table: "Employers");

            migrationBuilder.DropIndex(
                name: "IX_Employers_EmployerId",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "Employers");
        }
    }
}
