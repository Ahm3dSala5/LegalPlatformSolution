using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LegalPlatform.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateUserAndClientConfigs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("67ff139c-26d8-4e3d-96cf-e7087dcaa95c"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("eb61dc52-8f3a-4fed-bb15-0b3be326022f"));

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: new Guid("0d71462c-2fdc-4145-b3c1-7cfa9aa86799"));

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: new Guid("4d7c41a2-1fb7-4bff-8756-76a80bf30f82"));

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: new Guid("16ad0fd7-968c-45dd-90ef-9acec77f5cb2"));

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: new Guid("7d7f9408-1782-4945-8849-b5702f074a2d"));

            migrationBuilder.DeleteData(
                table: "Articale",
                keyColumn: "Id",
                keyValue: new Guid("89bec3a4-06fe-4eb6-b620-a76a284f518d"));

            migrationBuilder.DeleteData(
                table: "Articale",
                keyColumn: "Id",
                keyValue: new Guid("a465293d-c03b-4b9e-bd40-a9223f1398e8"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("46652bc5-8b3e-4d2e-bb06-b5ede371078a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cb85c865-ec34-4c26-9399-e8be9f2a9dc6"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Lawyer",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Client",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Lawyer_UserId",
                table: "Lawyer",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_UserId",
                table: "Client",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_User_UserId",
                table: "Client",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyer_User_UserId",
                table: "Lawyer",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_User_UserId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Lawyer_User_UserId",
                table: "Lawyer");

            migrationBuilder.DropIndex(
                name: "IX_Lawyer_UserId",
                table: "Lawyer");

            migrationBuilder.DropIndex(
                name: "IX_Client_UserId",
                table: "Client");

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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Lawyer");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Client");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Balance", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("46652bc5-8b3e-4d2e-bb06-b5ede371078a"), 0, "123 Main St, New York, NY", 500.75m, "dcf609cd-fce8-4615-8059-1beb9a6b5b52", "john.doe@example.com", true, false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN_DOE", null, "1234567890", true, null, false, "john_doe" },
                    { new Guid("cb85c865-ec34-4c26-9399-e8be9f2a9dc6"), 0, "456 Elm St, Los Angeles, CA", 1200.50m, "cc639b9a-467d-4613-aaaf-d5c9cb1a96a4", "jane.smith@example.com", true, false, null, "JANE.SMITH@EXAMPLE.COM", "JANE_SMITH", null, "0987654321", true, null, false, "jane_smith" }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "Date", "Note", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("67ff139c-26d8-4e3d-96cf-e7087dcaa95c"), new DateTime(2025, 5, 16, 19, 56, 37, 494, DateTimeKind.Utc).AddTicks(1620), "Consultation for legal advice.", 0, new Guid("46652bc5-8b3e-4d2e-bb06-b5ede371078a") },
                    { new Guid("eb61dc52-8f3a-4fed-bb15-0b3be326022f"), new DateTime(2025, 5, 12, 19, 56, 37, 494, DateTimeKind.Utc).AddTicks(1630), "Consultation for legal advice.", 2, new Guid("cb85c865-ec34-4c26-9399-e8be9f2a9dc6") }
                });

            migrationBuilder.InsertData(
                table: "Articale",
                columns: new[] { "Id", "Content", "Title", "UploadedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("89bec3a4-06fe-4eb6-b620-a76a284f518d"), "Content of legal insights article.", "Legal Insights", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("46652bc5-8b3e-4d2e-bb06-b5ede371078a") },
                    { new Guid("a465293d-c03b-4b9e-bd40-a9223f1398e8"), "Content of legal policies article.", "Understanding Legal Policies", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cb85c865-ec34-4c26-9399-e8be9f2a9dc6") }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Amount", "PaymentDate", "Reciever", "Sender", "UserId" },
                values: new object[,]
                {
                    { new Guid("16ad0fd7-968c-45dd-90ef-9acec77f5cb2"), 100.00m, new DateTime(2025, 5, 4, 19, 56, 37, 494, DateTimeKind.Utc).AddTicks(1603), new Guid("46652bc5-8b3e-4d2e-bb06-b5ede371078a"), new Guid("cb85c865-ec34-4c26-9399-e8be9f2a9dc6"), new Guid("cb85c865-ec34-4c26-9399-e8be9f2a9dc6") },
                    { new Guid("7d7f9408-1782-4945-8849-b5702f074a2d"), 250.00m, new DateTime(2025, 5, 9, 19, 56, 37, 494, DateTimeKind.Utc).AddTicks(1593), new Guid("cb85c865-ec34-4c26-9399-e8be9f2a9dc6"), new Guid("46652bc5-8b3e-4d2e-bb06-b5ede371078a"), new Guid("46652bc5-8b3e-4d2e-bb06-b5ede371078a") }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "AddedAt", "ArticaleId", "Text", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d71462c-2fdc-4145-b3c1-7cfa9aa86799"), new DateTime(2025, 5, 9, 19, 56, 37, 494, DateTimeKind.Utc).AddTicks(1574), new Guid("89bec3a4-06fe-4eb6-b620-a76a284f518d"), "Great article!", new Guid("46652bc5-8b3e-4d2e-bb06-b5ede371078a") },
                    { new Guid("4d7c41a2-1fb7-4bff-8756-76a80bf30f82"), new DateTime(2025, 5, 9, 19, 56, 37, 494, DateTimeKind.Utc).AddTicks(1585), new Guid("a465293d-c03b-4b9e-bd40-a9223f1398e8"), "Very informative!", new Guid("cb85c865-ec34-4c26-9399-e8be9f2a9dc6") }
                });
        }
    }
}
