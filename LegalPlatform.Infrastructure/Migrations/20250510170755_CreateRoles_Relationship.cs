using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LegalPlatform.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateRoles_Relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("a21ee6c4-6d04-4239-ac72-38f9a2c46ec1"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("c29fa1c3-a19d-464b-9354-e4220261c48a"));

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: new Guid("92ebb603-abd1-4eab-b216-7becbdde57ac"));

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: new Guid("ec4a9cf4-e2e6-402f-906e-336cbdf18ce7"));

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: new Guid("46e571da-0ffc-440d-8789-27f8a5ad5770"));

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: new Guid("a1545214-7c92-42f7-a2a3-7af5fd1510a4"));

            migrationBuilder.DeleteData(
                table: "Articale",
                keyColumn: "Id",
                keyValue: new Guid("0585b0fd-990b-49d8-a63f-fca22ec86003"));

            migrationBuilder.DeleteData(
                table: "Articale",
                keyColumn: "Id",
                keyValue: new Guid("3f563d9d-c417-4549-8939-4585759ed41f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("141bf1b4-3c12-466e-b04a-e4d3539df540"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ef0b2a3c-bf86-4227-bbc4-de2b9764beaf"));

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LegalUserId",
                table: "IdentityUserToken",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LegalUserId",
                table: "IdentityUserRole",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LegalUserId",
                table: "IdentityUserLogin",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LegalUserId",
                table: "IdentityUserClaim",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Balance", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0a848e9d-590f-4510-9f71-874f4380eb59"), 0, "123 Main St, New York, NY", 500.75m, "039bfc19-6543-4e4e-8d56-d3e3d93ec034", "john.doe@example.com", true, null, false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN_DOE", null, "1234567890", true, null, false, "john_doe" },
                    { new Guid("a81b0008-d046-4696-a09f-c9812ae7760c"), 0, "456 Elm St, Los Angeles, CA", 1200.50m, "1cd87fed-895e-423c-b11d-369e16ce449f", "jane.smith@example.com", true, null, false, null, "JANE.SMITH@EXAMPLE.COM", "JANE_SMITH", null, "0987654321", true, null, false, "jane_smith" }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "Date", "Note", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("cd7e56aa-80bb-41b1-bdf9-d3b9d2dcd83f"), new DateTime(2025, 5, 17, 17, 7, 52, 959, DateTimeKind.Utc).AddTicks(2826), "Consultation for legal advice.", 0, new Guid("0a848e9d-590f-4510-9f71-874f4380eb59") },
                    { new Guid("cebdc156-e9a3-4384-b8c8-ee1e80a426ca"), new DateTime(2025, 5, 13, 17, 7, 52, 959, DateTimeKind.Utc).AddTicks(2831), "Consultation for legal advice.", 2, new Guid("a81b0008-d046-4696-a09f-c9812ae7760c") }
                });

            migrationBuilder.InsertData(
                table: "Articale",
                columns: new[] { "Id", "Content", "Title", "UploadedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("3f551cd6-4e22-427a-b175-77e760c30716"), "Content of legal policies article.", "Understanding Legal Policies", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a81b0008-d046-4696-a09f-c9812ae7760c") },
                    { new Guid("a7acbc2d-4817-47f5-8f20-5cb8c716aea2"), "Content of legal insights article.", "Legal Insights", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0a848e9d-590f-4510-9f71-874f4380eb59") }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Amount", "PaymentDate", "Reciever", "Sender", "UserId" },
                values: new object[,]
                {
                    { new Guid("8ad2b0a6-ec75-4f93-a573-8801d65dd52b"), 250.00m, new DateTime(2025, 5, 10, 17, 7, 52, 959, DateTimeKind.Utc).AddTicks(2792), new Guid("a81b0008-d046-4696-a09f-c9812ae7760c"), new Guid("0a848e9d-590f-4510-9f71-874f4380eb59"), new Guid("0a848e9d-590f-4510-9f71-874f4380eb59") },
                    { new Guid("ff1aca82-3035-49bd-bd78-8a6cee7771ea"), 100.00m, new DateTime(2025, 5, 5, 17, 7, 52, 959, DateTimeKind.Utc).AddTicks(2809), new Guid("0a848e9d-590f-4510-9f71-874f4380eb59"), new Guid("a81b0008-d046-4696-a09f-c9812ae7760c"), new Guid("a81b0008-d046-4696-a09f-c9812ae7760c") }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "AddedAt", "ArticaleId", "Text", "UserId" },
                values: new object[,]
                {
                    { new Guid("2d69fb0c-1d70-4b9d-9a7a-7285708f8fe9"), new DateTime(2025, 5, 10, 17, 7, 52, 959, DateTimeKind.Utc).AddTicks(2786), new Guid("3f551cd6-4e22-427a-b175-77e760c30716"), "Very informative!", new Guid("a81b0008-d046-4696-a09f-c9812ae7760c") },
                    { new Guid("785bd076-4cee-4bbc-a025-36ed9d524f58"), new DateTime(2025, 5, 10, 17, 7, 52, 959, DateTimeKind.Utc).AddTicks(2741), new Guid("a7acbc2d-4817-47f5-8f20-5cb8c716aea2"), "Great article!", new Guid("0a848e9d-590f-4510-9f71-874f4380eb59") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IdentityUserToken_LegalUserId",
                table: "IdentityUserToken",
                column: "LegalUserId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityUserRole_LegalUserId",
                table: "IdentityUserRole",
                column: "LegalUserId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityUserLogin_LegalUserId",
                table: "IdentityUserLogin",
                column: "LegalUserId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityUserClaim_LegalUserId",
                table: "IdentityUserClaim",
                column: "LegalUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim_User_LegalUserId",
                table: "IdentityUserClaim",
                column: "LegalUserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin_User_LegalUserId",
                table: "IdentityUserLogin",
                column: "LegalUserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole_User_LegalUserId",
                table: "IdentityUserRole",
                column: "LegalUserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserToken_User_LegalUserId",
                table: "IdentityUserToken",
                column: "LegalUserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserClaim_User_LegalUserId",
                table: "IdentityUserClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserLogin_User_LegalUserId",
                table: "IdentityUserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserRole_User_LegalUserId",
                table: "IdentityUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserToken_User_LegalUserId",
                table: "IdentityUserToken");

            migrationBuilder.DropIndex(
                name: "IX_IdentityUserToken_LegalUserId",
                table: "IdentityUserToken");

            migrationBuilder.DropIndex(
                name: "IX_IdentityUserRole_LegalUserId",
                table: "IdentityUserRole");

            migrationBuilder.DropIndex(
                name: "IX_IdentityUserLogin_LegalUserId",
                table: "IdentityUserLogin");

            migrationBuilder.DropIndex(
                name: "IX_IdentityUserClaim_LegalUserId",
                table: "IdentityUserClaim");

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("cd7e56aa-80bb-41b1-bdf9-d3b9d2dcd83f"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("cebdc156-e9a3-4384-b8c8-ee1e80a426ca"));

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: new Guid("2d69fb0c-1d70-4b9d-9a7a-7285708f8fe9"));

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: new Guid("785bd076-4cee-4bbc-a025-36ed9d524f58"));

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: new Guid("8ad2b0a6-ec75-4f93-a573-8801d65dd52b"));

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: new Guid("ff1aca82-3035-49bd-bd78-8a6cee7771ea"));

            migrationBuilder.DeleteData(
                table: "Articale",
                keyColumn: "Id",
                keyValue: new Guid("3f551cd6-4e22-427a-b175-77e760c30716"));

            migrationBuilder.DeleteData(
                table: "Articale",
                keyColumn: "Id",
                keyValue: new Guid("a7acbc2d-4817-47f5-8f20-5cb8c716aea2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0a848e9d-590f-4510-9f71-874f4380eb59"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a81b0008-d046-4696-a09f-c9812ae7760c"));

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LegalUserId",
                table: "IdentityUserToken");

            migrationBuilder.DropColumn(
                name: "LegalUserId",
                table: "IdentityUserRole");

            migrationBuilder.DropColumn(
                name: "LegalUserId",
                table: "IdentityUserLogin");

            migrationBuilder.DropColumn(
                name: "LegalUserId",
                table: "IdentityUserClaim");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Balance", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("141bf1b4-3c12-466e-b04a-e4d3539df540"), 0, "456 Elm St, Los Angeles, CA", 1200.50m, "80454743-4c97-4e79-a244-73af3708c361", "jane.smith@example.com", true, false, null, "JANE.SMITH@EXAMPLE.COM", "JANE_SMITH", null, "0987654321", true, null, false, "jane_smith" },
                    { new Guid("ef0b2a3c-bf86-4227-bbc4-de2b9764beaf"), 0, "123 Main St, New York, NY", 500.75m, "e890c1c5-977e-47db-ac95-12fbaa1ca1bf", "john.doe@example.com", true, false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN_DOE", null, "1234567890", true, null, false, "john_doe" }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "Date", "Note", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("a21ee6c4-6d04-4239-ac72-38f9a2c46ec1"), new DateTime(2025, 5, 12, 20, 4, 43, 372, DateTimeKind.Utc).AddTicks(6367), "Consultation for legal advice.", 2, new Guid("141bf1b4-3c12-466e-b04a-e4d3539df540") },
                    { new Guid("c29fa1c3-a19d-464b-9354-e4220261c48a"), new DateTime(2025, 5, 16, 20, 4, 43, 372, DateTimeKind.Utc).AddTicks(6359), "Consultation for legal advice.", 0, new Guid("ef0b2a3c-bf86-4227-bbc4-de2b9764beaf") }
                });

            migrationBuilder.InsertData(
                table: "Articale",
                columns: new[] { "Id", "Content", "Title", "UploadedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0585b0fd-990b-49d8-a63f-fca22ec86003"), "Content of legal policies article.", "Understanding Legal Policies", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("141bf1b4-3c12-466e-b04a-e4d3539df540") },
                    { new Guid("3f563d9d-c417-4549-8939-4585759ed41f"), "Content of legal insights article.", "Legal Insights", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ef0b2a3c-bf86-4227-bbc4-de2b9764beaf") }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Amount", "PaymentDate", "Reciever", "Sender", "UserId" },
                values: new object[,]
                {
                    { new Guid("46e571da-0ffc-440d-8789-27f8a5ad5770"), 250.00m, new DateTime(2025, 5, 9, 20, 4, 43, 372, DateTimeKind.Utc).AddTicks(6334), new Guid("141bf1b4-3c12-466e-b04a-e4d3539df540"), new Guid("ef0b2a3c-bf86-4227-bbc4-de2b9764beaf"), new Guid("ef0b2a3c-bf86-4227-bbc4-de2b9764beaf") },
                    { new Guid("a1545214-7c92-42f7-a2a3-7af5fd1510a4"), 100.00m, new DateTime(2025, 5, 4, 20, 4, 43, 372, DateTimeKind.Utc).AddTicks(6345), new Guid("ef0b2a3c-bf86-4227-bbc4-de2b9764beaf"), new Guid("141bf1b4-3c12-466e-b04a-e4d3539df540"), new Guid("141bf1b4-3c12-466e-b04a-e4d3539df540") }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "AddedAt", "ArticaleId", "Text", "UserId" },
                values: new object[,]
                {
                    { new Guid("92ebb603-abd1-4eab-b216-7becbdde57ac"), new DateTime(2025, 5, 9, 20, 4, 43, 372, DateTimeKind.Utc).AddTicks(6317), new Guid("3f563d9d-c417-4549-8939-4585759ed41f"), "Great article!", new Guid("ef0b2a3c-bf86-4227-bbc4-de2b9764beaf") },
                    { new Guid("ec4a9cf4-e2e6-402f-906e-336cbdf18ce7"), new DateTime(2025, 5, 9, 20, 4, 43, 372, DateTimeKind.Utc).AddTicks(6326), new Guid("0585b0fd-990b-49d8-a63f-fca22ec86003"), "Very informative!", new Guid("141bf1b4-3c12-466e-b04a-e4d3539df540") }
                });
        }
    }
}
