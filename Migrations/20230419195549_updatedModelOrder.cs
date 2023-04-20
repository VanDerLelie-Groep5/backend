using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Groep5VanDerLelieApi.Migrations
{
    /// <inheritdoc />
    public partial class updatedModelOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Departments_departmentId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_departmentId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "Orders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_departmentId",
                table: "Orders",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Departments_departmentId",
                table: "Orders",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
