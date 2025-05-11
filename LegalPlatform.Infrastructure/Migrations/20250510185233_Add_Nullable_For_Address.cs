using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LegalPlatform.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_Nullable_For_Address : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
