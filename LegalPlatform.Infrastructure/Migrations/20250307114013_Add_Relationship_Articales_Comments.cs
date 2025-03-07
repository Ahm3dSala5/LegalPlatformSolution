using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LegalPlatform.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_Relationship_Articales_Comments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticaleId",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ArticaleId",
                table: "Comment",
                column: "ArticaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Articale_ArticaleId",
                table: "Comment",
                column: "ArticaleId",
                principalTable: "Articale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Articale_ArticaleId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_ArticaleId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "ArticaleId",
                table: "Comment");
        }
    }
}
