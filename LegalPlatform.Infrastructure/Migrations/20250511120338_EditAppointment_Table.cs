using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LegalPlatform.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EditAppointment_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_User_UserId",
                table: "Appointment");

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("02cc605d-9245-4352-b990-458a2f64cc15"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("6ffc2628-a06a-4449-8f60-b0a1a7ba245d"));

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: new Guid("10da4a68-5949-46dd-a6e5-0be030b96f38"));

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: new Guid("7c575943-3fac-41db-b9a5-133ed0d5c133"));

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: new Guid("307681ae-f726-4647-b901-50d1f50a7c96"));

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: new Guid("b0e7bce6-67d0-46a0-91e0-7ec379e90ed2"));

            migrationBuilder.DeleteData(
                table: "Articale",
                keyColumn: "Id",
                keyValue: new Guid("1553a5c2-8cf4-4f27-901e-d5a27c656ca1"));

            migrationBuilder.DeleteData(
                table: "Articale",
                keyColumn: "Id",
                keyValue: new Guid("c7c34645-c5bf-4427-9392-a59f2122c722"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("11d729e6-f6d6-4a63-a8ec-fe3abf5287a5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e56906f1-8b46-44f9-997f-49d2d2fadc55"));

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Appointment",
                newName: "LawerId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_UserId",
                table: "Appointment",
                newName: "IX_Appointment_LawerId");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "Appointment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "LegalUserId",
                table: "Appointment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ClientId",
                table: "Appointment",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_LegalUserId",
                table: "Appointment",
                column: "LegalUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Client_ClientId",
                table: "Appointment",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Lawyer_LawerId",
                table: "Appointment",
                column: "LawerId",
                principalTable: "Lawyer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_User_LegalUserId",
                table: "Appointment",
                column: "LegalUserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Client_ClientId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Lawyer_LawerId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_User_LegalUserId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_ClientId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_LegalUserId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "LegalUserId",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "LawerId",
                table: "Appointment",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_LawerId",
                table: "Appointment",
                newName: "IX_Appointment_UserId");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Balance", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("11d729e6-f6d6-4a63-a8ec-fe3abf5287a5"), 0, "456 Elm St, Los Angeles, CA", 1200.50m, "8f378822-af75-44f0-832c-31b4b1660fec", "jane.smith@example.com", true, null, false, null, "JANE.SMITH@EXAMPLE.COM", "JANE_SMITH", null, "0987654321", true, null, false, "jane_smith" },
                    { new Guid("e56906f1-8b46-44f9-997f-49d2d2fadc55"), 0, "123 Main St, New York, NY", 500.75m, "12f1ce56-9546-4b9e-857d-7aed29790790", "john.doe@example.com", true, null, false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN_DOE", null, "1234567890", true, null, false, "john_doe" }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "Date", "Note", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("02cc605d-9245-4352-b990-458a2f64cc15"), new DateTime(2025, 5, 17, 18, 52, 31, 729, DateTimeKind.Utc).AddTicks(987), "Consultation for legal advice.", 0, new Guid("e56906f1-8b46-44f9-997f-49d2d2fadc55") },
                    { new Guid("6ffc2628-a06a-4449-8f60-b0a1a7ba245d"), new DateTime(2025, 5, 13, 18, 52, 31, 729, DateTimeKind.Utc).AddTicks(1010), "Consultation for legal advice.", 2, new Guid("11d729e6-f6d6-4a63-a8ec-fe3abf5287a5") }
                });

            migrationBuilder.InsertData(
                table: "Articale",
                columns: new[] { "Id", "Content", "Title", "UploadedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1553a5c2-8cf4-4f27-901e-d5a27c656ca1"), "Content of legal policies article.", "Understanding Legal Policies", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11d729e6-f6d6-4a63-a8ec-fe3abf5287a5") },
                    { new Guid("c7c34645-c5bf-4427-9392-a59f2122c722"), "Content of legal insights article.", "Legal Insights", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e56906f1-8b46-44f9-997f-49d2d2fadc55") }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Amount", "PaymentDate", "Reciever", "Sender", "UserId" },
                values: new object[,]
                {
                    { new Guid("307681ae-f726-4647-b901-50d1f50a7c96"), 100.00m, new DateTime(2025, 5, 5, 18, 52, 31, 729, DateTimeKind.Utc).AddTicks(965), new Guid("e56906f1-8b46-44f9-997f-49d2d2fadc55"), new Guid("11d729e6-f6d6-4a63-a8ec-fe3abf5287a5"), new Guid("11d729e6-f6d6-4a63-a8ec-fe3abf5287a5") },
                    { new Guid("b0e7bce6-67d0-46a0-91e0-7ec379e90ed2"), 250.00m, new DateTime(2025, 5, 10, 18, 52, 31, 729, DateTimeKind.Utc).AddTicks(947), new Guid("11d729e6-f6d6-4a63-a8ec-fe3abf5287a5"), new Guid("e56906f1-8b46-44f9-997f-49d2d2fadc55"), new Guid("e56906f1-8b46-44f9-997f-49d2d2fadc55") }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "AddedAt", "ArticaleId", "Text", "UserId" },
                values: new object[,]
                {
                    { new Guid("10da4a68-5949-46dd-a6e5-0be030b96f38"), new DateTime(2025, 5, 10, 18, 52, 31, 729, DateTimeKind.Utc).AddTicks(911), new Guid("c7c34645-c5bf-4427-9392-a59f2122c722"), "Great article!", new Guid("e56906f1-8b46-44f9-997f-49d2d2fadc55") },
                    { new Guid("7c575943-3fac-41db-b9a5-133ed0d5c133"), new DateTime(2025, 5, 10, 18, 52, 31, 729, DateTimeKind.Utc).AddTicks(931), new Guid("1553a5c2-8cf4-4f27-901e-d5a27c656ca1"), "Very informative!", new Guid("11d729e6-f6d6-4a63-a8ec-fe3abf5287a5") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_User_UserId",
                table: "Appointment",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
