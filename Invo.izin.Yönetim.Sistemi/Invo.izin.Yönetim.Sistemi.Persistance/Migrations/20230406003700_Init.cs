using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Invo.izin.Yönetim.Sistemi.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Hr");

            migrationBuilder.CreateTable(
                name: " BranchOffice",
                schema: "Hr",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchOfficeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ BranchOffice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: " LeaveRequest",
                schema: "Hr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    LeaveTypeId = table.Column<byte>(type: "tinyint", nullable: false),
                    LeaveTime = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ LeaveRequest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                schema: "Hr",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTitle",
                schema: "Hr",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTitle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeavePermissionLevel",
                schema: "Hr",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeavePermissionLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveType",
                schema: "Hr",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                schema: "Hr",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmployeeSurName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHead = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<byte>(type: "tinyint", nullable: false),
                    TitleId = table.Column<byte>(type: "tinyint", nullable: false),
                    BranchOfficeId = table.Column<byte>(type: "tinyint", nullable: true),
                    LeavePermissionLevelId = table.Column<byte>(type: "tinyint", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_ BranchOffice_BranchOfficeId",
                        column: x => x.BranchOfficeId,
                        principalSchema: "Hr",
                        principalTable: " BranchOffice",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "Hr",
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeeTitle_TitleId",
                        column: x => x.TitleId,
                        principalSchema: "Hr",
                        principalTable: "EmployeeTitle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_LeavePermissionLevel_LeavePermissionLevelId",
                        column: x => x.LeavePermissionLevelId,
                        principalSchema: "Hr",
                        principalTable: "LeavePermissionLevel",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Hr",
                table: " BranchOffice",
                columns: new[] { "Id", "BranchOfficeName", "CreatedDate", "Description", "IsActive", "UpatedDate" },
                values: new object[,]
                {
                    { (byte)1, "İstanbul", new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7654), null, true, null },
                    { (byte)2, "Ankara", new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7656), null, true, null },
                    { (byte)3, "İzmir", new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7656), null, true, null }
                });

            migrationBuilder.InsertData(
                schema: "Hr",
                table: "Department",
                columns: new[] { "Id", "CreatedDate", "DepartmentName", "Description", "IsActive", "UpatedDate" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7371), "Bilgi İşlem", "", true, null },
                    { (byte)2, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7386), "Finans", "", true, null },
                    { (byte)3, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7387), "Muhasebe", "", true, null },
                    { (byte)4, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7388), "Satış / Pazarlama", "", true, null },
                    { (byte)5, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7389), "Sevkiyat", "", true, null },
                    { (byte)6, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7390), "Üretim", "", true, null },
                    { (byte)7, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7391), "Hukuk", "", true, null },
                    { (byte)8, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7392), "Halkla İlişkiler", "", true, null },
                    { (byte)9, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7393), "İnsan Kaynakları", "", true, null },
                    { (byte)10, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7393), "Ar-Ge", "", true, null }
                });

            migrationBuilder.InsertData(
                schema: "Hr",
                table: "EmployeeTitle",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "TitleName", "UpatedDate" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7774), null, true, "Müdür", null },
                    { (byte)2, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7776), null, true, "Şef", null },
                    { (byte)3, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7777), null, true, "Uzman", null },
                    { (byte)4, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7807), null, true, "Stajyer", null },
                    { (byte)5, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7809), null, true, "Genel Müdür", null },
                    { (byte)6, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7810), null, true, "CEO", null }
                });

            migrationBuilder.InsertData(
                schema: "Hr",
                table: "LeavePermissionLevel",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "Level", "UpatedDate" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7721), null, true, "Birinci Seviye", null },
                    { (byte)2, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7722), null, true, "İkinci Seviye", null },
                    { (byte)3, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7722), null, true, "Üçüncü Seviye", null }
                });

            migrationBuilder.InsertData(
                schema: "Hr",
                table: "LeaveType",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "LeaveTypeName", "UpatedDate" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7586), null, true, "Yıllık İzin", null },
                    { (byte)2, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7587), null, true, "Süt İzni", null },
                    { (byte)3, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7588), null, true, "Mazeret İzni", null },
                    { (byte)4, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7588), null, true, "Doğum Sonrası İzin", null },
                    { (byte)5, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7589), null, true, "Evilik İzni", null },
                    { (byte)6, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7590), null, true, "Hastalık İzni", null },
                    { (byte)7, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7590), null, true, "Askerlik", null },
                    { (byte)8, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7591), null, true, "Ücretsiz İzin", null },
                    { (byte)9, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7592), null, true, "Taşınma İzni", null },
                    { (byte)10, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7592), null, true, "Devamsızlık", null },
                    { (byte)11, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7593), null, true, "Hizmete Ara Verme", null },
                    { (byte)12, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7593), null, true, "Zorunluluk Hali", null },
                    { (byte)13, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7594), null, true, "Yol İzni", null },
                    { (byte)14, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7595), null, true, "Mesai İzni", null },
                    { (byte)15, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7595), null, true, "İş Aktivitesi", null }
                });

            migrationBuilder.InsertData(
                schema: "Hr",
                table: "Employee",
                columns: new[] { "EmployeeId", "BranchOfficeId", "CreatedDate", "DepartmentId", "Description", "EmployeeName", "EmployeeSurName", "Id", "IsActive", "IsHead", "LeavePermissionLevelId", "TitleId", "UpatedDate", "UserId" },
                values: new object[] { 1, (byte)1, new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7868), (byte)1, null, "Halil", "ŞAHİN", 0, true, true, (byte)1, (byte)1, null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BranchOfficeId",
                schema: "Hr",
                table: "Employee",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                schema: "Hr",
                table: "Employee",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_LeavePermissionLevelId",
                schema: "Hr",
                table: "Employee",
                column: "LeavePermissionLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_TitleId",
                schema: "Hr",
                table: "Employee",
                column: "TitleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: " LeaveRequest",
                schema: "Hr");

            migrationBuilder.DropTable(
                name: "Employee",
                schema: "Hr");

            migrationBuilder.DropTable(
                name: "LeaveType",
                schema: "Hr");

            migrationBuilder.DropTable(
                name: " BranchOffice",
                schema: "Hr");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "Hr");

            migrationBuilder.DropTable(
                name: "EmployeeTitle",
                schema: "Hr");

            migrationBuilder.DropTable(
                name: "LeavePermissionLevel",
                schema: "Hr");
        }
    }
}
