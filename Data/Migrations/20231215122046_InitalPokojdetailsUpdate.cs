using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class InitalPokojdetailsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "03c99e3b-1916-449c-a1fc-f7adc579c2c5", "86d66475-243e-45a0-9074-7e607e5ee072" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03c99e3b-1916-449c-a1fc-f7adc579c2c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86d66475-243e-45a0-9074-7e607e5ee072");

            migrationBuilder.DropColumn(
                name: "Wlasciciel",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Wlasciciel",
                table: "Reservations",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03c99e3b-1916-449c-a1fc-f7adc579c2c5", "03c99e3b-1916-449c-a1fc-f7adc579c2c5", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "86d66475-243e-45a0-9074-7e607e5ee072", 0, "29ad235a-1957-4907-b8ba-0f948bff9203", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEN8/kOIPq6JLx3CUBELSome6sV+OmsvZ1sz7e8KfXEsNeYZt3XzDvCNI35HLC+Fenw==", null, false, "c9ccb9c2-195f-44af-ba99-00b6bfa5a50e", false, "adam" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationEntityId",
                keyValue: 1,
                column: "Wlasciciel",
                value: "Adam");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationEntityId",
                keyValue: 2,
                column: "Wlasciciel",
                value: "Adam");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "03c99e3b-1916-449c-a1fc-f7adc579c2c5", "86d66475-243e-45a0-9074-7e607e5ee072" });
        }
    }
}
