using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 14L, true, new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 15L, true, new DateTime(2022, 3, 28, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 16L, true, new DateTime(2022, 3, 28, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 17L, true, new DateTime(2022, 3, 28, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 18L, true, new DateTime(2022, 3, 28, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 19L, true, new DateTime(2022, 3, 28, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 20L, true, new DateTime(2022, 3, 28, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 21L, true, new DateTime(2022, 3, 28, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 22L, true, new DateTime(2022, 3, 28, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 23L, true, new DateTime(2022, 3, 28, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 24L, true, new DateTime(2022, 3, 28, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 25L, true, new DateTime(2022, 3, 28, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 26L, true, new DateTime(2022, 3, 28, 20, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 26L);
        }
    }
}
