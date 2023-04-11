using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invo.izin.Yönetim.Sistemi.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                schema: "Hr",
                table: " LeaveRequest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: " BranchOffice",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: " BranchOffice",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: " BranchOffice",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Department",
                keyColumn: "Id",
                keyValue: (byte)10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "EmployeeTitle",
                keyColumn: "Id",
                keyValue: (byte)6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeavePermissionLevel",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeavePermissionLevel",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeavePermissionLevel",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "LeaveType",
                keyColumn: "Id",
                keyValue: (byte)15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 4, 38, 6, 609, DateTimeKind.Local).AddTicks(8408));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                schema: "Hr",
                table: " LeaveRequest");

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
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                schema: "Hr",
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 9, 12, 55, 3, 664, DateTimeKind.Local).AddTicks(8479));

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
    }
}
