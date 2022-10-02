using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class userTableModifiedAddIsLocked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserReview",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 723, DateTimeKind.Utc).AddTicks(9926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserPassword",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 723, DateTimeKind.Utc).AddTicks(9361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserActivity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 723, DateTimeKind.Utc).AddTicks(9647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 723, DateTimeKind.Utc).AddTicks(8924),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.AddColumn<bool>(
                name: "IsLocked",
                schema: "dbo",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LockDurationTime",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RequireReLogin",
                schema: "dbo",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Topic",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 724, DateTimeKind.Utc).AddTicks(908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateSection",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 724, DateTimeKind.Utc).AddTicks(560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 724, DateTimeKind.Utc).AddTicks(690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 724, DateTimeKind.Utc).AddTicks(349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 724, DateTimeKind.Utc).AddTicks(455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "QueuedEmail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 724, DateTimeKind.Utc).AddTicks(241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Log",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 723, DateTimeKind.Utc).AddTicks(9481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Document",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 724, DateTimeKind.Utc).AddTicks(29),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4791));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLocked",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LockDurationTime",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RequireReLogin",
                schema: "dbo",
                table: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserReview",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 723, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserPassword",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(3730),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 723, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserActivity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 723, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(3434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 723, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Topic",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 724, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateSection",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 724, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 724, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 724, DateTimeKind.Utc).AddTicks(349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(5256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 724, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "QueuedEmail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 724, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Log",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(3973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 723, DateTimeKind.Utc).AddTicks(9481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Document",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 30, 19, 20, 32, 263, DateTimeKind.Utc).AddTicks(4791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 2, 18, 49, 28, 724, DateTimeKind.Utc).AddTicks(29));
        }
    }
}
