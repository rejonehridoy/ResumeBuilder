using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class lanugageAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gid",
                schema: "dbo",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                schema: "dbo",
                table: "User",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Uid",
                schema: "dbo",
                table: "User",
                type: "nvarchar(400)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)");

            migrationBuilder.AlterColumn<string>(
                name: "LastIpAddress",
                schema: "dbo",
                table: "User",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AddColumn<string>(
                name: "Guid",
                schema: "dbo",
                table: "User",
                type: "nvarchar(400)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "dbo",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                schema: "dbo",
                table: "User",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Uid",
                schema: "dbo",
                table: "User",
                type: "nvarchar(400)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastIpAddress",
                schema: "dbo",
                table: "User",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gid",
                schema: "dbo",
                table: "User",
                type: "nvarchar(400)",
                nullable: false,
                defaultValue: "");
        }
    }
}
