using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ContactAddCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c0bb7131-b835-42a2-8b53-8bae7a0fd538", "9c484dfb-fedb-45da-a247-5097fdf5dd25" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0bb7131-b835-42a2-8b53-8bae7a0fd538");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c484dfb-fedb-45da-a247-5097fdf5dd25");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "contacts",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "467ff5e2-59ff-408b-bf6f-f10879d64056", "467ff5e2-59ff-408b-bf6f-f10879d64056", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "69756a28-2d88-460e-87a6-f3a0cc1fc11f", 0, "5300a8a0-929e-422d-9113-f86fd99c79a0", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEJSWh0ew480029U+31UB5t4irQW22GZhNB87bLNC9v1qmxSlf+GQ0usrAxax2p+MwQ==", null, false, "451bc90b-9267-4c38-97db-0c8560fec374", false, "adam" });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                columns: new[] { "Birth", "Created" },
                values: new object[] { new DateTime(2000, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                columns: new[] { "Birth", "Created" },
                values: new object[] { new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "467ff5e2-59ff-408b-bf6f-f10879d64056", "69756a28-2d88-460e-87a6-f3a0cc1fc11f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "467ff5e2-59ff-408b-bf6f-f10879d64056", "69756a28-2d88-460e-87a6-f3a0cc1fc11f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "467ff5e2-59ff-408b-bf6f-f10879d64056");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69756a28-2d88-460e-87a6-f3a0cc1fc11f");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "contacts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0bb7131-b835-42a2-8b53-8bae7a0fd538", "c0bb7131-b835-42a2-8b53-8bae7a0fd538", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9c484dfb-fedb-45da-a247-5097fdf5dd25", 0, "2c1eb32d-effc-46a6-a19e-f4bb4a7de697", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEAItFiSmMaSUSaxrMP2Zi2oN9d53Y5YbkPA/cHlhQyuK54Vy0A60ikhr7S5wrjiy6g==", null, false, "04bb9a16-2ef7-427a-872b-1d7edba3f4a4", false, "adam" });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "Birth",
                value: new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "Birth",
                value: new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c0bb7131-b835-42a2-8b53-8bae7a0fd538", "9c484dfb-fedb-45da-a247-5097fdf5dd25" });
        }
    }
}
