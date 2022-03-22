using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1L,
                column: "Time",
                value: new DateTime(2022, 3, 27, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 2L, true, new DateTime(2022, 3, 27, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 3L, true, new DateTime(2022, 3, 27, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 4L, true, new DateTime(2022, 3, 27, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 5L, true, new DateTime(2022, 3, 27, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 6L, true, new DateTime(2022, 3, 27, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 7L, true, new DateTime(2022, 3, 27, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 8L, true, new DateTime(2022, 3, 27, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 9L, true, new DateTime(2022, 3, 27, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 10L, true, new DateTime(2022, 3, 27, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 11L, true, new DateTime(2022, 3, 27, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 12L, true, new DateTime(2022, 3, 27, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Available", "Time" },
                values: new object[] { 13L, true, new DateTime(2022, 3, 27, 20, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 13L);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1L,
                column: "Time",
                value: new DateTime(2008, 4, 10, 6, 30, 0, 0, DateTimeKind.Local));
        }
    }
}
