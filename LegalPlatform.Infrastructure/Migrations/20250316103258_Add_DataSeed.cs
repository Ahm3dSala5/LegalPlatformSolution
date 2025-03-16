using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LegalPlatform.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: new Guid("428937b9-2acc-46df-9a94-2ba10fefa89a"));

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: new Guid("80f9cdc3-ec47-465d-871e-706f87acfa7e"));

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: new Guid("50aff29e-d272-4017-871f-d8c94230e7e2"));

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: new Guid("c1ff726b-6aaf-45e1-a73e-ac88d439a9d2"));

            migrationBuilder.DeleteData(
                table: "Articale",
                keyColumn: "Id",
                keyValue: new Guid("133dcaeb-a659-4ada-9869-42573fa02739"));

            migrationBuilder.DeleteData(
                table: "Articale",
                keyColumn: "Id",
                keyValue: new Guid("ea8d2f13-fd5e-4adb-944c-998aabfd5985"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("374185dc-a96d-4e87-ada1-60efa7fe71e2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bcccd887-9858-4f32-9c91-b4889035793f"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Balance", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("04cf622f-e9c3-4b60-a217-3f958e27226f"), 0, "123 Main St, New York, NY", 500.75m, "7d37dfc8-1482-47fd-b5a4-f294cd2d9787", "john.doe@example.com", true, false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN_DOE", null, "1234567890", true, null, false, "john_doe" },
                    { new Guid("4b745c00-9250-410c-888b-e9ac8fafba5d"), 0, "456 Elm St, Los Angeles, CA", 1200.50m, "89ba00d1-0484-403e-9a5b-3a4209fc4d88", "jane.smith@example.com", true, false, null, "JANE.SMITH@EXAMPLE.COM", "JANE_SMITH", null, "0987654321", true, null, false, "jane_smith" }
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "Date", "Note", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("87f07d47-a4c9-40b1-ad4e-69523bcf0b96"), new DateTime(2025, 3, 19, 10, 32, 56, 522, DateTimeKind.Utc).AddTicks(5995), "Consultation for legal advice.", 2, new Guid("4b745c00-9250-410c-888b-e9ac8fafba5d") },
                    { new Guid("d8d2a2a4-f32b-4d94-8d55-9672d02ea682"), new DateTime(2025, 3, 23, 10, 32, 56, 522, DateTimeKind.Utc).AddTicks(5979), "Consultation for legal advice.", 0, new Guid("04cf622f-e9c3-4b60-a217-3f958e27226f") }
                });

            migrationBuilder.InsertData(
                table: "Articale",
                columns: new[] { "Id", "Content", "Title", "UploadedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("4cfe784c-7c41-4a89-881a-89241fc2b60e"), "Content of legal policies article.", "Understanding Legal Policies", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b745c00-9250-410c-888b-e9ac8fafba5d") },
                    { new Guid("d52662cb-d403-47ce-8d4a-03a219c51ab2"), "Content of legal insights article.", "Legal Insights", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("04cf622f-e9c3-4b60-a217-3f958e27226f") }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Amount", "PaymentDate", "Reciever", "Sender", "UserId" },
                values: new object[,]
                {
                    { new Guid("33ab9a0e-50c0-4997-8cdd-ed007a998ec2"), 250.00m, new DateTime(2025, 3, 16, 10, 32, 56, 522, DateTimeKind.Utc).AddTicks(5953), new Guid("4b745c00-9250-410c-888b-e9ac8fafba5d"), new Guid("04cf622f-e9c3-4b60-a217-3f958e27226f"), new Guid("04cf622f-e9c3-4b60-a217-3f958e27226f") },
                    { new Guid("45b888c9-30a1-45cd-bf57-9c726cde6f6d"), 100.00m, new DateTime(2025, 3, 11, 10, 32, 56, 522, DateTimeKind.Utc).AddTicks(5965), new Guid("04cf622f-e9c3-4b60-a217-3f958e27226f"), new Guid("4b745c00-9250-410c-888b-e9ac8fafba5d"), new Guid("4b745c00-9250-410c-888b-e9ac8fafba5d") }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "AddedAt", "ArticaleId", "Text", "UserId" },
                values: new object[,]
                {
                    { new Guid("180afbf2-205e-41f0-856a-97f9f4aa6237"), new DateTime(2025, 3, 16, 10, 32, 56, 522, DateTimeKind.Utc).AddTicks(5932), new Guid("d52662cb-d403-47ce-8d4a-03a219c51ab2"), "Great article!", new Guid("04cf622f-e9c3-4b60-a217-3f958e27226f") },
                    { new Guid("64367b36-25a0-4a7d-b539-655fbd22d8d2"), new DateTime(2025, 3, 16, 10, 32, 56, 522, DateTimeKind.Utc).AddTicks(5947), new Guid("4cfe784c-7c41-4a89-881a-89241fc2b60e"), "Very informative!", new Guid("4b745c00-9250-410c-888b-e9ac8fafba5d") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("87f07d47-a4c9-40b1-ad4e-69523bcf0b96"));

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: new Guid("d8d2a2a4-f32b-4d94-8d55-9672d02ea682"));

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: new Guid("180afbf2-205e-41f0-856a-97f9f4aa6237"));

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: new Guid("64367b36-25a0-4a7d-b539-655fbd22d8d2"));

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: new Guid("33ab9a0e-50c0-4997-8cdd-ed007a998ec2"));

            migrationBuilder.DeleteData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: new Guid("45b888c9-30a1-45cd-bf57-9c726cde6f6d"));

            migrationBuilder.DeleteData(
                table: "Articale",
                keyColumn: "Id",
                keyValue: new Guid("4cfe784c-7c41-4a89-881a-89241fc2b60e"));

            migrationBuilder.DeleteData(
                table: "Articale",
                keyColumn: "Id",
                keyValue: new Guid("d52662cb-d403-47ce-8d4a-03a219c51ab2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("04cf622f-e9c3-4b60-a217-3f958e27226f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4b745c00-9250-410c-888b-e9ac8fafba5d"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Balance", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("374185dc-a96d-4e87-ada1-60efa7fe71e2"), 0, "456 Elm St, Los Angeles, CA", 1200.50m, "6bccd1b2-decf-4191-bbc1-2c061e244bb7", "jane.smith@example.com", true, false, null, "JANE.SMITH@EXAMPLE.COM", "JANE_SMITH", null, "0987654321", true, null, false, "jane_smith" },
                    { new Guid("bcccd887-9858-4f32-9c91-b4889035793f"), 0, "123 Main St, New York, NY", 500.75m, "31861865-49e5-4de9-96bc-2cf09d214e0a", "john.doe@example.com", true, false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN_DOE", null, "1234567890", true, null, false, "john_doe" }
                });

            migrationBuilder.InsertData(
                table: "Articale",
                columns: new[] { "Id", "Content", "Title", "UploadedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("133dcaeb-a659-4ada-9869-42573fa02739"), "Content of legal policies article.", "Understanding Legal Policies", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("374185dc-a96d-4e87-ada1-60efa7fe71e2") },
                    { new Guid("ea8d2f13-fd5e-4adb-944c-998aabfd5985"), "Content of legal insights article.", "Legal Insights", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bcccd887-9858-4f32-9c91-b4889035793f") }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Amount", "PaymentDate", "Reciever", "Sender", "UserId" },
                values: new object[,]
                {
                    { new Guid("50aff29e-d272-4017-871f-d8c94230e7e2"), 250.00m, new DateTime(2025, 3, 16, 10, 25, 54, 609, DateTimeKind.Utc).AddTicks(6604), new Guid("374185dc-a96d-4e87-ada1-60efa7fe71e2"), new Guid("bcccd887-9858-4f32-9c91-b4889035793f"), new Guid("bcccd887-9858-4f32-9c91-b4889035793f") },
                    { new Guid("c1ff726b-6aaf-45e1-a73e-ac88d439a9d2"), 100.00m, new DateTime(2025, 3, 11, 10, 25, 54, 609, DateTimeKind.Utc).AddTicks(6615), new Guid("bcccd887-9858-4f32-9c91-b4889035793f"), new Guid("374185dc-a96d-4e87-ada1-60efa7fe71e2"), new Guid("374185dc-a96d-4e87-ada1-60efa7fe71e2") }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "AddedAt", "ArticaleId", "Text", "UserId" },
                values: new object[,]
                {
                    { new Guid("428937b9-2acc-46df-9a94-2ba10fefa89a"), new DateTime(2025, 3, 16, 10, 25, 54, 609, DateTimeKind.Utc).AddTicks(6585), new Guid("133dcaeb-a659-4ada-9869-42573fa02739"), "Very informative!", new Guid("374185dc-a96d-4e87-ada1-60efa7fe71e2") },
                    { new Guid("80f9cdc3-ec47-465d-871e-706f87acfa7e"), new DateTime(2025, 3, 16, 10, 25, 54, 609, DateTimeKind.Utc).AddTicks(6570), new Guid("ea8d2f13-fd5e-4adb-944c-998aabfd5985"), "Great article!", new Guid("bcccd887-9858-4f32-9c91-b4889035793f") }
                });
        }
    }
}
