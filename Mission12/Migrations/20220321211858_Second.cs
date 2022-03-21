using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 1L, true, new DateTime(2008, 4, 10, 6, 30, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "AppointmentId", "Email", "Name", "Phone", "Size" },
                values: new object[] { 1L, 1L, "thomas@thomas.com", "thomas", "9999999", 12 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1L);
        }
    }
}
