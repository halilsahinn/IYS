using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invo.izin.Yönetim.Sistemi.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class ReNamedIdToEmployeeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                schema: "Hr",
                table: "Employee");

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: " BranchOffice",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: " BranchOffice",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: " BranchOffice",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.InsertData(
                schema: "Hr",
                table: "Employee",
                columns: new[] { "EmployeeId", "BranchOfficeId", "CreatedDate", "DepartmentId", "Description", "EmployeeName", "EmployeeSurName", "IsActive", "IsHead", "LeavePermissionLevelId", "TitleId", "UpatedDate", "UserId" },
                values: new object[] { 2, (byte)2, new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(1517), (byte)2, null, "Ali", "ŞAHİN", true, false, (byte)2, (byte)2, null, 2 });

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeavePermissionLevel",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeavePermissionLevel",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeavePermissionLevel",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(542));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Hr",
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                schema: "Hr",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: " BranchOffice",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: " BranchOffice",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: " BranchOffice",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7868), 0 });

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeavePermissionLevel",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeavePermissionLevel",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeavePermissionLevel",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 3, 37, 0, 832, DateTimeKind.Local).AddTicks(7595));
        }
    }
}
