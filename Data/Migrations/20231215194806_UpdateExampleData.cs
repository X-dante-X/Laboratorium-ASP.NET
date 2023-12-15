using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UpdateExampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3b9bbd0e-d59b-4e0c-8250-f9973efada35", "a1defe9e-5d43-486b-a583-877c6a732e01" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b9bbd0e-d59b-4e0c-8250-f9973efada35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1defe9e-5d43-486b-a583-877c6a732e01");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed959497-a4e9-4d8a-b3ba-8c4fac5376fd", "ed959497-a4e9-4d8a-b3ba-8c4fac5376fd", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a53138a6-5445-4cbb-94b0-b61974d34357", 0, "2e69b1ff-2ae4-4bd5-959f-c9a4c74db53c", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEA9u6kNLCKMuo2XnWv+Gd9jzS/BrFR69iJln0MXXFgpq1D5/WDgIvtngYTnkNrvt0w==", null, false, "f4c743d2-13e3-4036-8dbb-2934322259e5", false, "adam" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationEntityId",
                keyValue: 2,
                columns: new[] { "ContactEntityContactId", "ContactName" },
                values: new object[] { 3, "Alice" });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                columns: new[] { "Birth", "Created", "Email", "name", "OrganizationId", "Phone", "Priority" },
                values: new object[] { new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 15, 19, 48, 6, 232, DateTimeKind.Utc).AddTicks(2513), "john@email.com", "John", 101, "987654321", 0 });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                columns: new[] { "Birth", "Created", "Email", "name", "Phone" },
                values: new object[] { new DateTime(1990, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 15, 19, 48, 6, 232, DateTimeKind.Utc).AddTicks(2518), "alice@email.com", "Alice", "123456789" });

            migrationBuilder.InsertData(
                table: "contacts",
                columns: new[] { "ContactId", "Birth", "Created", "Email", "name", "OrganizationId", "Phone", "Priority" },
                values: new object[] { 4, new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 15, 19, 48, 6, 232, DateTimeKind.Utc).AddTicks(2521), "bob@email.com", "Bob", 102, "555555555", 2 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ed959497-a4e9-4d8a-b3ba-8c4fac5376fd", "a53138a6-5445-4cbb-94b0-b61974d34357" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed959497-a4e9-4d8a-b3ba-8c4fac5376fd", "a53138a6-5445-4cbb-94b0-b61974d34357" });

            migrationBuilder.DeleteData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed959497-a4e9-4d8a-b3ba-8c4fac5376fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a53138a6-5445-4cbb-94b0-b61974d34357");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b9bbd0e-d59b-4e0c-8250-f9973efada35", "3b9bbd0e-d59b-4e0c-8250-f9973efada35", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a1defe9e-5d43-486b-a583-877c6a732e01", 0, "d9e1e41d-86f6-463c-9809-bb95ed7cb6ae", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEECjCF9+0XMCDKXv2xNzg8k32+1eQ8AJfBczLGsDi6h+TboVJgQu3tcxK2abUrdLYw==", null, false, "20ae9648-2151-4c6c-9c2c-affdb6d3504b", false, "adam" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationEntityId",
                keyValue: 2,
                columns: new[] { "ContactEntityContactId", "ContactName" },
                values: new object[] { 2, "Adam" });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                columns: new[] { "Birth", "Created", "Email", "name", "OrganizationId", "Phone", "Priority" },
                values: new object[] { new DateTime(2000, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "adam@wsei.edu.pl", "Adam", 102, "124124234", 1 });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                columns: new[] { "Birth", "Created", "Email", "name", "Phone" },
                values: new object[] { new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "adam@wsei.edu.pl", "Adam", "124124234" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3b9bbd0e-d59b-4e0c-8250-f9973efada35", "a1defe9e-5d43-486b-a583-877c6a732e01" });
        }
    }
}
