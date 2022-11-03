using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity_Frame_Work_Project.Migrations
{
    public partial class AddIsActiveTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 11, 3, 3, 19, 18, 987, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 11, 3, 3, 19, 18, 988, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 11, 3, 3, 19, 18, 988, DateTimeKind.Local).AddTicks(2051));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 11, 3, 2, 17, 40, 354, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 11, 3, 2, 17, 40, 355, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 11, 3, 2, 17, 40, 355, DateTimeKind.Local).AddTicks(301));
        }
    }
}
