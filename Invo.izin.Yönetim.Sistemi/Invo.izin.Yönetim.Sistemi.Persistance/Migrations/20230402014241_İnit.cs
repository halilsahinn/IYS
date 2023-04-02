using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Invo.izin.Yönetim.Sistemi.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class İnit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Hr");

            migrationBuilder.CreateTable(
                name: " BranchOfficeName",
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
                    table.PrimaryKey("PK_ BranchOfficeName", x => x.Id);
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
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmployeeSurName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    HeadId = table.Column<int>(type: "int", nullable: true),
                    BranchOfficeId = table.Column<byte>(type: "tinyint", nullable: true),
                    LeavePermissionLevelId = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_ BranchOfficeName_BranchOfficeId",
                        column: x => x.BranchOfficeId,
                        principalSchema: "Hr",
                        principalTable: " BranchOfficeName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employee_LeavePermissionLevel_LeavePermissionLevelId",
                        column: x => x.LeavePermissionLevelId,
                        principalSchema: "Hr",
                        principalTable: "LeavePermissionLevel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: " DepartmentOfHead",
                schema: "Hr",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<byte>(type: "tinyint", nullable: false),
                    LeavePermissionLevelId = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ DepartmentOfHead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ DepartmentOfHead_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "Hr",
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ DepartmentOfHead_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "Hr",
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ DepartmentOfHead_LeavePermissionLevel_LeavePermissionLevelId",
                        column: x => x.LeavePermissionLevelId,
                        principalSchema: "Hr",
                        principalTable: "LeavePermissionLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Hr",
                table: " BranchOfficeName",
                columns: new[] { "Id", "BranchOfficeName", "CreatedDate", "Description", "IsActive", "UpatedDate" },
                values: new object[,]
                {
                    { (byte)1, "İstanbul", new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9812), null, true, null },
                    { (byte)2, "Ankara", new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9813), null, true, null },
                    { (byte)3, "İzmir", new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9814), null, true, null }
                });

            migrationBuilder.InsertData(
                schema: "Hr",
                table: "Department",
                columns: new[] { "Id", "CreatedDate", "DepartmentName", "Description", "IsActive", "UpatedDate" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 4, 2, 4, 42, 41, 541, DateTimeKind.Local).AddTicks(16), "Bilgi İşlem", "", true, null },
                    { (byte)2, new DateTime(2023, 4, 2, 4, 42, 41, 541, DateTimeKind.Local).AddTicks(19), "Finans", "", true, null },
                    { (byte)3, new DateTime(2023, 4, 2, 4, 42, 41, 541, DateTimeKind.Local).AddTicks(20), "Muhasebe", "", true, null },
                    { (byte)4, new DateTime(2023, 4, 2, 4, 42, 41, 541, DateTimeKind.Local).AddTicks(21), "Satış / Pazarlama", "", true, null },
                    { (byte)5, new DateTime(2023, 4, 2, 4, 42, 41, 541, DateTimeKind.Local).AddTicks(21), "Sevkiyat", "", true, null },
                    { (byte)6, new DateTime(2023, 4, 2, 4, 42, 41, 541, DateTimeKind.Local).AddTicks(22), "Üretim", "", true, null },
                    { (byte)7, new DateTime(2023, 4, 2, 4, 42, 41, 541, DateTimeKind.Local).AddTicks(22), "Hukuk", "", true, null },
                    { (byte)8, new DateTime(2023, 4, 2, 4, 42, 41, 541, DateTimeKind.Local).AddTicks(23), "Halkla İlişkiler", "", true, null },
                    { (byte)9, new DateTime(2023, 4, 2, 4, 42, 41, 541, DateTimeKind.Local).AddTicks(24), "İnsan Kaynakları", "", true, null },
                    { (byte)10, new DateTime(2023, 4, 2, 4, 42, 41, 541, DateTimeKind.Local).AddTicks(24), "Ar-Ge", "", true, null }
                });

            migrationBuilder.InsertData(
                schema: "Hr",
                table: "EmployeeTitle",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "Title", "UpatedDate" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9963), null, true, "Müdür", null },
                    { (byte)2, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9964), null, true, "Şef", null },
                    { (byte)3, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9965), null, true, "Uzman", null },
                    { (byte)4, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9966), null, true, "Stajyer", null },
                    { (byte)5, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9966), null, true, "Genel Müdür", null },
                    { (byte)6, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9967), null, true, "CEO", null }
                });

            migrationBuilder.InsertData(
                schema: "Hr",
                table: "LeavePermissionLevel",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "Level", "UpatedDate" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9868), null, true, "Birinci Seviye", null },
                    { (byte)2, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9869), null, true, "İkinci Seviye", null },
                    { (byte)3, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9869), null, true, "Üçüncü Seviye", null }
                });

            migrationBuilder.InsertData(
                schema: "Hr",
                table: "LeaveType",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "LeaveTypeName", "UpatedDate" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9643), null, true, "Yıllık İzin", null },
                    { (byte)2, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9656), null, true, "Süt İzni", null },
                    { (byte)3, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9657), null, true, "Mazeret İzni", null },
                    { (byte)4, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9657), null, true, "Doğum Sonrası İzin", null },
                    { (byte)5, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9658), null, true, "Evilik İzni", null },
                    { (byte)6, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9659), null, true, "Hastalık İzni", null },
                    { (byte)7, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9659), null, true, "Askerlik", null },
                    { (byte)9, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9660), null, true, "Ücretsiz İzin", null },
                    { (byte)10, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9661), null, true, "Taşınma İzni", null },
                    { (byte)11, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9661), null, true, "Devamsızlık", null },
                    { (byte)12, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9662), null, true, "Hizmete Ara Verme", null },
                    { (byte)13, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9662), null, true, "Zorunluluk Hali", null },
                    { (byte)14, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9663), null, true, "Yol İzni", null },
                    { (byte)15, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9663), null, true, "Mesai İzni", null },
                    { (byte)16, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9664), null, true, "İş Aktivitesi", null }
                });

            migrationBuilder.InsertData(
                schema: "Hr",
                table: "Employee",
                columns: new[] { "Id", "BranchOfficeId", "CreatedDate", "Description", "EmployeeName", "EmployeeSurName", "HeadId", "IsActive", "LeavePermissionLevelId", "UpatedDate", "UserId" },
                values: new object[] { 1, (byte)1, new DateTime(2023, 4, 2, 4, 42, 41, 541, DateTimeKind.Local).AddTicks(74), null, "Halil", "ŞAHİN", null, true, (byte)1, null, null });

            migrationBuilder.InsertData(
                schema: "Hr",
                table: " DepartmentOfHead",
                columns: new[] { "Id", "CreatedDate", "DepartmentId", "Description", "EmployeeId", "IsActive", "LeavePermissionLevelId", "UpatedDate" },
                values: new object[] { (byte)1, new DateTime(2023, 4, 2, 4, 42, 41, 540, DateTimeKind.Local).AddTicks(9913), (byte)1, null, 1, true, (byte)1, null });

            migrationBuilder.CreateIndex(
                name: "IX_ DepartmentOfHead_DepartmentId",
                schema: "Hr",
                table: " DepartmentOfHead",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ DepartmentOfHead_EmployeeId",
                schema: "Hr",
                table: " DepartmentOfHead",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ DepartmentOfHead_LeavePermissionLevelId",
                schema: "Hr",
                table: " DepartmentOfHead",
                column: "LeavePermissionLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BranchOfficeId",
                schema: "Hr",
                table: "Employee",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_LeavePermissionLevelId",
                schema: "Hr",
                table: "Employee",
                column: "LeavePermissionLevelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: " DepartmentOfHead",
                schema: "Hr");

            migrationBuilder.DropTable(
                name: " LeaveRequest",
                schema: "Hr");

            migrationBuilder.DropTable(
                name: "EmployeeTitle",
                schema: "Hr");

            migrationBuilder.DropTable(
                name: "LeaveType",
                schema: "Hr");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "Hr");

            migrationBuilder.DropTable(
                name: "Employee",
                schema: "Hr");

            migrationBuilder.DropTable(
                name: " BranchOfficeName",
                schema: "Hr");

            migrationBuilder.DropTable(
                name: "LeavePermissionLevel",
                schema: "Hr");
        }
    }
}
