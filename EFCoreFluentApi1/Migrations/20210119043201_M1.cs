using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreFluentApi1.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Audit",
                columns: table => new
                {
                    AuditId = table.Column<string>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audit", x => x.AuditId);
                    table.ForeignKey(
                        name: "FK_Audit_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                column: "EmployeeId",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4
                });

            migrationBuilder.InsertData(
                table: "Audit",
                columns: new[] { "AuditId", "EmployeeId" },
                values: new object[,]
                {
                    { "Audit1", 1 },
                    { "Audit2", 1 },
                    { "Audit3", 1 },
                    { "Audit4", 2 },
                    { "Audit5", 3 },
                    { "Audit6", 3 },
                    { "Audit7", 4 },
                    { "Audit8", 4 },
                    { "Audit9", 4 },
                    { "Audit10", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Audit_EmployeeId",
                table: "Audit",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audit");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
