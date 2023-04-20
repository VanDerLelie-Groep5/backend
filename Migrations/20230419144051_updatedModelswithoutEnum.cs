using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Groep5VanDerLelieApi.Migrations
{
    /// <inheritdoc />
    public partial class updatedModelswithoutEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_customerId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "OrderLines");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "Orders",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_customerId",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.RenameColumn(
                name: "number",
                table: "Departments",
                newName: "departmentNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_number",
                table: "Departments",
                newName: "IX_Departments_departmentNumber");

            migrationBuilder.AddColumn<string>(
                name: "customerGroup",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "entryDate",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fabricName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "priority",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "product",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ready",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "reference",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "shiftId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "space",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "units",
                table: "Orders",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_departmentId",
                table: "Orders",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_shiftId",
                table: "Orders",
                column: "shiftId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Departments_departmentId",
                table: "Orders",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shifts_shiftId",
                table: "Orders",
                column: "shiftId",
                principalTable: "Shifts",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Departments_departmentId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shifts_shiftId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_departmentId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_shiftId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "customerGroup",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "entryDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "fabricName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "priority",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "product",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ready",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "reference",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "shiftId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "space",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "units",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Orders",
                newName: "customerId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                newName: "IX_Orders_customerId");

            migrationBuilder.RenameColumn(
                name: "departmentNumber",
                table: "Departments",
                newName: "number");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_departmentNumber",
                table: "Departments",
                newName: "IX_Departments_number");

            migrationBuilder.CreateTable(
                name: "OrderLines",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departmentId = table.Column<int>(type: "int", nullable: true),
                    orderId = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLines", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderLines_Departments_departmentId",
                        column: x => x.departmentId,
                        principalTable: "Departments",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_OrderLines_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderLineId = table.Column<int>(type: "int", nullable: false),
                    shiftId = table.Column<int>(type: "int", nullable: true),
                    priority = table.Column<int>(type: "int", nullable: true),
                    value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.id);
                    table.ForeignKey(
                        name: "FK_Units_OrderLines_orderLineId",
                        column: x => x.orderLineId,
                        principalTable: "OrderLines",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Units_Shifts_shiftId",
                        column: x => x.shiftId,
                        principalTable: "Shifts",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_departmentId",
                table: "OrderLines",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_orderId",
                table: "OrderLines",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_orderLineId",
                table: "Units",
                column: "orderLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_shiftId",
                table: "Units",
                column: "shiftId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_customerId",
                table: "Orders",
                column: "customerId",
                principalTable: "Customers",
                principalColumn: "id");
        }
    }
}
