using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UpdateReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ace2c0e-f484-4bc7-9fc2-6cd5b39c458c", "233604f2-7278-4698-8b24-8c51183e58d2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ace2c0e-f484-4bc7-9fc2-6cd5b39c458c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "233604f2-7278-4698-8b24-8c51183e58d2");

            migrationBuilder.AddColumn<string>(
                name: "ContactName",
                table: "Reservations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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
                keyValue: 1,
                column: "ContactName",
                value: "Adam");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationEntityId",
                keyValue: 2,
                column: "ContactName",
                value: "Adam");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3b9bbd0e-d59b-4e0c-8250-f9973efada35", "a1defe9e-5d43-486b-a583-877c6a732e01" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ContactName",
                table: "Reservations");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ace2c0e-f484-4bc7-9fc2-6cd5b39c458c", "5ace2c0e-f484-4bc7-9fc2-6cd5b39c458c", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "233604f2-7278-4698-8b24-8c51183e58d2", 0, "c15651fd-3ac9-45b7-be96-860dc8766eb7", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEI8rZoyF22Zy3R6GoEFzez6E613s/y4QL4dzQx9cTQdN9UroeGlDsbvxQMy0W0oKJw==", null, false, "65719fc0-c09b-4cdc-8764-6599b5e520f3", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5ace2c0e-f484-4bc7-9fc2-6cd5b39c458c", "233604f2-7278-4698-8b24-8c51183e58d2" });
        }
    }
}
