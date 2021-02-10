using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EdgarAparicio.APIAsyncRestFul.Manager.Entity.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Bedrooms = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Age = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDepartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDepartments_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDepartments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Active", "Bedrooms", "CreatedAt", "Level", "Name", "UpdatedAt" },
                values: new object[] { 1, true, 3, new DateTime(2021, 2, 9, 20, 44, 51, 546, DateTimeKind.Local).AddTicks(4242), 1, "Azul", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "Age", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { 1, true, 20, new DateTime(2021, 2, 9, 20, 44, 51, 542, DateTimeKind.Local).AddTicks(89), "Edgar", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "Age", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { 2, true, 54, new DateTime(2021, 2, 9, 20, 44, 51, 544, DateTimeKind.Local).AddTicks(8009), "Catalina", null });

            migrationBuilder.InsertData(
                table: "UserDepartments",
                columns: new[] { "Id", "Active", "CreatedAt", "DepartmentId", "UpdatedAt", "UserId" },
                values: new object[] { 1, true, new DateTime(2021, 2, 9, 20, 44, 51, 546, DateTimeKind.Local).AddTicks(5869), 1, null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_UserDepartments_DepartmentId",
                table: "UserDepartments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDepartments_UserId",
                table: "UserDepartments",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDepartments");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
