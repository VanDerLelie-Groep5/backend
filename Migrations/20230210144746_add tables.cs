using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Groep5VanDerLelieApi.Migrations
{
    /// <inheritdoc />
    public partial class addtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLine_Departments_departmentId",
                table: "OrderLine");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLine_Orders_orderId",
                table: "OrderLine");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_OrderLine_orderLineId",
                table: "Unit");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Shifts_shiftId",
                table: "Unit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Unit",
                table: "Unit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderLine",
                table: "OrderLine");

            migrationBuilder.RenameTable(
                name: "Unit",
                newName: "Units");

            migrationBuilder.RenameTable(
                name: "OrderLine",
                newName: "OrderLines");

            migrationBuilder.RenameIndex(
                name: "IX_Unit_shiftId",
                table: "Units",
                newName: "IX_Units_shiftId");

            migrationBuilder.RenameIndex(
                name: "IX_Unit_orderLineId",
                table: "Units",
                newName: "IX_Units_orderLineId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLine_orderId",
                table: "OrderLines",
                newName: "IX_OrderLines_orderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLine_departmentId",
                table: "OrderLines",
                newName: "IX_OrderLines_departmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderLines",
                table: "OrderLines",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Departments_departmentId",
                table: "OrderLines",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Orders_orderId",
                table: "OrderLines",
                column: "orderId",
                principalTable: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_OrderLines_orderLineId",
                table: "Units",
                column: "orderLineId",
                principalTable: "OrderLines",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Shifts_shiftId",
                table: "Units",
                column: "shiftId",
                principalTable: "Shifts",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Departments_departmentId",
                table: "OrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Orders_orderId",
                table: "OrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_OrderLines_orderLineId",
                table: "Units");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_Shifts_shiftId",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderLines",
                table: "OrderLines");

            migrationBuilder.RenameTable(
                name: "Units",
                newName: "Unit");

            migrationBuilder.RenameTable(
                name: "OrderLines",
                newName: "OrderLine");

            migrationBuilder.RenameIndex(
                name: "IX_Units_shiftId",
                table: "Unit",
                newName: "IX_Unit_shiftId");

            migrationBuilder.RenameIndex(
                name: "IX_Units_orderLineId",
                table: "Unit",
                newName: "IX_Unit_orderLineId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLines_orderId",
                table: "OrderLine",
                newName: "IX_OrderLine_orderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLines_departmentId",
                table: "OrderLine",
                newName: "IX_OrderLine_departmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unit",
                table: "Unit",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderLine",
                table: "OrderLine",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLine_Departments_departmentId",
                table: "OrderLine",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLine_Orders_orderId",
                table: "OrderLine",
                column: "orderId",
                principalTable: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_OrderLine_orderLineId",
                table: "Unit",
                column: "orderLineId",
                principalTable: "OrderLine",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Shifts_shiftId",
                table: "Unit",
                column: "shiftId",
                principalTable: "Shifts",
                principalColumn: "id");
        }
    }
}
