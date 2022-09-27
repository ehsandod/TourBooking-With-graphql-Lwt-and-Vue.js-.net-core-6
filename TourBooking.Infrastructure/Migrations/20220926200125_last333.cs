using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourBooking.Infrastructure.Migrations
{
    public partial class last333 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PartyLeaders",
                columns: table => new
                {
                    PartyLeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyLeaders", x => x.PartyLeaderId);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    StationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    city = table.Column<string>(type: "varchar(21)", unicode: false, maxLength: 21, nullable: true),
                    state = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    lat_n = table.Column<int>(type: "int", nullable: true),
                    long_w = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "waitlist",
                columns: table => new
                {
                    Waitlistid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    listname = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    firstname = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    lastname = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    created = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    PartyLeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Currency = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.PartyLeaderId);
                    table.ForeignKey(
                        name: "FK_Bookings_PartyLeaders_PartyLeaderId",
                        column: x => x.PartyLeaderId,
                        principalTable: "PartyLeaders",
                        principalColumn: "PartyLeaderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PartyLeaders",
                columns: new[] { "PartyLeaderId", "Name" },
                values: new object[,]
                {
                    { new Guid("5b8a57ee-b147-4f8c-b7e6-f8725119deb4"), "EliGasht" },
                    { new Guid("a1697955-bdc0-49f0-a704-08da73299f8d"), "MoreHami" },
                    { new Guid("d2fc8dea-e40c-4b09-805c-b19c99991f24"), "AliBaba" },
                    { new Guid("fb96e887-6582-4e75-d4da-08da7343ecea"), "DigiKala" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "PartyLeaderId", "BookingId", "CreateDate", "Currency", "Name", "Price", "Status" },
                values: new object[] { new Guid("a1697955-bdc0-49f0-a704-08da73299f8d"), new Guid("d2fc8dea-e40c-4b09-805c-b19c99891f24"), new DateTime(2020, 5, 9, 20, 11, 0, 0, DateTimeKind.Unspecified), (short)8, "Andreas", 1500, (short)1 });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "PartyLeaderId", "BookingId", "CreateDate", "Currency", "Name", "Price", "Status" },
                values: new object[] { new Guid("d2fc8dea-e40c-4b09-805c-b19c99991f24"), new Guid("8ad8d11d-01e7-454d-a2c9-f4e94ea991cd"), new DateTime(2020, 5, 9, 20, 11, 0, 0, DateTimeKind.Unspecified), (short)2, "Kiristin", 800, (short)1 });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "PartyLeaderId", "BookingId", "CreateDate", "Currency", "Name", "Price", "Status" },
                values: new object[] { new Guid("fb96e887-6582-4e75-d4da-08da7343ecea"), new Guid("d2fc8dea-e40c-4b05-805c-b19c97891f24"), new DateTime(1990, 2, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), (short)7, "Darush", 1200, (short)1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "waitlist");

            migrationBuilder.DropTable(
                name: "PartyLeaders");
        }
    }
}
