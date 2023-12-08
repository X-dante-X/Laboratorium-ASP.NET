using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ReservationUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "34a34bcf-7dad-49a2-91f2-65d9344d5905", "b977a819-cf2f-44ae-8cc0-2aaaa9845d95" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34a34bcf-7dad-49a2-91f2-65d9344d5905");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b977a819-cf2f-44ae-8cc0-2aaaa9845d95");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "34a34bcf-7dad-49a2-91f2-65d9344d5905", "34a34bcf-7dad-49a2-91f2-65d9344d5905", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b977a819-cf2f-44ae-8cc0-2aaaa9845d95", 0, "1f5eb080-1ca0-411f-8d4c-5c95ec779af6", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEAjmOibuPWj3Jf8SPbwpRc634D1ihyubaY3S5wU1Zyu7lGnqe1r2NvdgOFDusSwp8Q==", null, false, "7030c9bb-9a25-402d-adeb-18b536265b7c", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "34a34bcf-7dad-49a2-91f2-65d9344d5905", "b977a819-cf2f-44ae-8cc0-2aaaa9845d95" });
        }
    }
}
