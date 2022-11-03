using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity_Frame_Work_Project.Migrations
{
    public partial class AddDefaultColumnIsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 11, 3, 3, 22, 36, 335, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 11, 3, 3, 22, 36, 336, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 11, 3, 3, 22, 36, 336, DateTimeKind.Local).AddTicks(9048));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 11, 3, 3, 21, 50, 947, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 11, 3, 3, 21, 50, 948, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 11, 3, 3, 21, 50, 948, DateTimeKind.Local).AddTicks(4102));
        }
    }
}
