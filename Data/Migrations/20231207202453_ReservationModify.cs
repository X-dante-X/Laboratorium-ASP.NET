using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ReservationModify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3a8e4f4a-6bfe-4df2-83bb-c7bee1f3cc7c", "7dd56b9f-5948-4f0b-8c63-7871d8f01d73" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a8e4f4a-6bfe-4df2-83bb-c7bee1f3cc7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7dd56b9f-5948-4f0b-8c63-7871d8f01d73");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Adress_City = table.Column<string>(type: "TEXT", nullable: false),
                    Adress_Street = table.Column<string>(type: "TEXT", nullable: false),
                    Adress_PostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    Pokoj = table.Column<string>(type: "TEXT", nullable: false),
                    Wlasciciel = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Cena = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8767a0ef-6a75-4467-833b-31d88538e13f", "8767a0ef-6a75-4467-833b-31d88538e13f", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8c290f1a-6c6c-4f38-92da-181dcfd5872a", 0, "298c9674-76ae-4d35-b09b-673e47451f2c", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEKjMcscQzGjqWX6SpjcHcYAJPCFgcvNBuPu2byUpbriBN4xgZTT4jw3E9sL6uNrOJg==", null, false, "e9d6a1e3-82d4-4612-828b-b2b55301fddf", false, "adam" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "Cena", "Data", "Pokoj", "Wlasciciel", "Adress_City", "Adress_PostalCode", "Adress_Street" },
                values: new object[,]
                {
                    { 1, 190.23m, new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "13A", "Adam", "Krakow", "30-015", "Mazowiecka 12" },
                    { 2, 156.99m, new DateTime(2012, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", "Adam", "Krakow", "30-322", "Czarodziejska 2" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8767a0ef-6a75-4467-833b-31d88538e13f", "8c290f1a-6c6c-4f38-92da-181dcfd5872a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8767a0ef-6a75-4467-833b-31d88538e13f", "8c290f1a-6c6c-4f38-92da-181dcfd5872a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8767a0ef-6a75-4467-833b-31d88538e13f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c290f1a-6c6c-4f38-92da-181dcfd5872a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3a8e4f4a-6bfe-4df2-83bb-c7bee1f3cc7c", "3a8e4f4a-6bfe-4df2-83bb-c7bee1f3cc7c", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7dd56b9f-5948-4f0b-8c63-7871d8f01d73", 0, "74e23a11-dda7-4055-ae0a-91f19a8aa1bb", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEIL1+ACKYq5XXbhH1UaswCbKCUsTt5BX40WdzsWOUySNgtVvH+GLGV7VPD6JoZDt5w==", null, false, "7489623a-1206-4cb1-8894-88ab0ec6c872", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3a8e4f4a-6bfe-4df2-83bb-c7bee1f3cc7c", "7dd56b9f-5948-4f0b-8c63-7871d8f01d73" });
        }
    }
}
