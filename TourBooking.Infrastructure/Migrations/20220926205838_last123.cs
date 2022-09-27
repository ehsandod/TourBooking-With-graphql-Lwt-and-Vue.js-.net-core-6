using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourBooking.Infrastructure.Migrations
{
    public partial class last123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "waitlist",
                newName: "Waitlists");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Stations",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Stations",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "long_w",
                table: "Stations",
                newName: "LongW");

            migrationBuilder.RenameColumn(
                name: "lat_n",
                table: "Stations",
                newName: "LatN");

            migrationBuilder.RenameColumn(
                name: "listname",
                table: "Waitlists",
                newName: "Listname");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "Waitlists",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "firstname",
                table: "Waitlists",
                newName: "Firstname");

            migrationBuilder.RenameColumn(
                name: "created",
                table: "Waitlists",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "Waitlistid",
                table: "Waitlists",
                newName: "WaitlistId");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Stations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Stations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(21)",
                oldUnicode: false,
                oldMaxLength: 21,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Listname",
                table: "Waitlists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldUnicode: false,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "Waitlists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldUnicode: false,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "Waitlists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldUnicode: false,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stations",
                table: "Stations",
                column: "StationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Waitlists",
                table: "Waitlists",
                column: "WaitlistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stations",
                table: "Stations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Waitlists",
                table: "Waitlists");

            migrationBuilder.RenameTable(
                name: "Waitlists",
                newName: "waitlist");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Stations",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Stations",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "LongW",
                table: "Stations",
                newName: "long_w");

            migrationBuilder.RenameColumn(
                name: "LatN",
                table: "Stations",
                newName: "lat_n");

            migrationBuilder.RenameColumn(
                name: "Listname",
                table: "waitlist",
                newName: "listname");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "waitlist",
                newName: "lastname");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "waitlist",
                newName: "firstname");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "waitlist",
                newName: "created");

            migrationBuilder.RenameColumn(
                name: "WaitlistId",
                table: "waitlist",
                newName: "Waitlistid");

            migrationBuilder.AlterColumn<string>(
                name: "state",
                table: "Stations",
                type: "varchar(2)",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "city",
                table: "Stations",
                type: "varchar(21)",
                unicode: false,
                maxLength: 21,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "listname",
                table: "waitlist",
                type: "varchar(max)",
                unicode: false,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                table: "waitlist",
                type: "varchar(max)",
                unicode: false,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "firstname",
                table: "waitlist",
                type: "varchar(max)",
                unicode: false,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
