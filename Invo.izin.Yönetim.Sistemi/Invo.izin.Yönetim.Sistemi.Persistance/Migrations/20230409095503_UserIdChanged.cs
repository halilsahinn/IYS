using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invo.izin.Yönetim.Sistemi.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class UserIdChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "Hr",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: " BranchOffice",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: " BranchOffice",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: " BranchOffice",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(8474), "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(8479), "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeavePermissionLevel",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeavePermissionLevel",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeavePermissionLevel",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(7606));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                schema: "Hr",
                table: "Employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(1513), 1 });

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2023, 4, 8, 14, 21, 16, 287, DateTimeKind.Local).AddTicks(1517), 2 });

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
    }
}
