using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class whoopdiscoop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1L,
                column: "Available",
                value: false);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2L,
                column: "Available",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1L,
                column: "Available",
                value: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2L,
                column: "Available",
                value: true);
        }
    }
}
