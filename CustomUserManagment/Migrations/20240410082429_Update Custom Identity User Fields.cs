using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomUserManagment.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCustomIdentityUserFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                schema: "CUseMngt",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                schema: "CUseMngt",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                schema: "CUseMngt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Picture",
                schema: "CUseMngt",
                table: "Users");
        }
    }
}
