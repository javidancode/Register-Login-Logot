using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity_Frame_Work_Project.Migrations
{
    public partial class AddIsActiveDefaultColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
