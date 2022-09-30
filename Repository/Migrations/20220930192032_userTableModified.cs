using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class userTableModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserReview",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserPassword",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(3730),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserActivity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastLoginDate",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastActivityDate",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(3434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Topic",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 774, DateTimeKind.Utc).AddTicks(223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateSection",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 774, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "QueuedEmail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Log",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(3973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Document",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9465));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserPassword",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(8806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserActivity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastLoginDate",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastActivityDate",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(8586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Topic",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 774, DateTimeKind.Utc).AddTicks(223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateSection",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 774, DateTimeKind.Utc).AddTicks(20),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "QueuedEmail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Log",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(8939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Document",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 12, 21, 773, DateTimeKind.Utc).AddTicks(9465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4791));
        }
    }
}
