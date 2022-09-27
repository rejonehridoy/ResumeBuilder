using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addedSearchTermTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserReview",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserPassword",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(8806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserActivity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(3083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(8586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Topic",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 774, DateTimeKind.Utc).AddTicks(223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateSection",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 774, DateTimeKind.Utc).AddTicks(20),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "QueuedEmail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Log",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(8939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(2749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Document",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.CreateTable(
                name: "SearchTerm",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchTerm", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SearchTerm",
                schema: "dbo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserReview",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(4138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserPassword",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(2293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserActivity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(3083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(1775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Topic",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 774, DateTimeKind.Utc).AddTicks(223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateSection",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(5985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(6257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 774, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(5228),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(5548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "QueuedEmail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(4908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Log",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(2749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Document",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(4565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9465));
        }
    }
}
