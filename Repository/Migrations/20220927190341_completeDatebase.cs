using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class completeDatebase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserReview",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(4138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserPassword",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(2293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(7611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserActivity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(3083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(7972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(1775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(7293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateSection",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(5985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(6257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(5228),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(5548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "QueuedEmail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(4908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Log",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(2749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(7806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Document",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(4565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.CreateTable(
                name: "MenuItem",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    ParentMenuId = table.Column<int>(type: "int", nullable: true),
                    HasSubMenu = table.Column<bool>(type: "bit", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTemplateComponent",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    UserTemplateSectionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniqueTag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasRedirectUrl = table.Column<bool>(type: "bit", nullable: false),
                    RedirectUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasSubComponent = table.Column<bool>(type: "bit", nullable: false),
                    TemplateSectionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTemplateComponent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTemplateComponent_TemplateProfile_ProfileId",
                        column: x => x.ProfileId,
                        principalSchema: "dbo",
                        principalTable: "TemplateProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTemplateComponent_TemplateSection_TemplateSectionId",
                        column: x => x.TemplateSectionId,
                        principalSchema: "dbo",
                        principalTable: "TemplateSection",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserTemplateSection",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasComponent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTemplateSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTemplateSection_TemplateProfile_ProfileId",
                        column: x => x.ProfileId,
                        principalSchema: "dbo",
                        principalTable: "TemplateProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTemplateSubComponent",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    UserTemplateComponentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniqueTag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasKeyValuePair = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTemplateSubComponent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTemplateSubComponent_TemplateProfile_ProfileId",
                        column: x => x.ProfileId,
                        principalSchema: "dbo",
                        principalTable: "TemplateProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTemplateKeyValuePair",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    UserTemplateSubComponent = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Required = table.Column<bool>(type: "bit", nullable: false),
                    UserTemplateSubComponentsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTemplateKeyValuePair", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTemplateKeyValuePair_TemplateProfile_ProfileId",
                        column: x => x.ProfileId,
                        principalSchema: "dbo",
                        principalTable: "TemplateProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTemplateKeyValuePair_UserTemplateSubComponent_UserTemplateSubComponentsId",
                        column: x => x.UserTemplateSubComponentsId,
                        principalSchema: "dbo",
                        principalTable: "UserTemplateSubComponent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTemplateComponent_ProfileId",
                schema: "dbo",
                table: "UserTemplateComponent",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTemplateComponent_TemplateSectionId",
                schema: "dbo",
                table: "UserTemplateComponent",
                column: "TemplateSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTemplateKeyValuePair_ProfileId",
                schema: "dbo",
                table: "UserTemplateKeyValuePair",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTemplateKeyValuePair_UserTemplateSubComponentsId",
                schema: "dbo",
                table: "UserTemplateKeyValuePair",
                column: "UserTemplateSubComponentsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTemplateSection_ProfileId",
                schema: "dbo",
                table: "UserTemplateSection",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTemplateSubComponent_ProfileId",
                schema: "dbo",
                table: "UserTemplateSubComponent",
                column: "ProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Topic",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserTemplateComponent",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserTemplateKeyValuePair",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserTemplateSection",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserTemplateSubComponent",
                schema: "dbo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserReview",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(8520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserPassword",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(7611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "UserActivity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(7972),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(3083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(7293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateSection",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(9414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(9700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "TemplateCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(9083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(9250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "QueuedEmail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(8862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Log",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(7806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(2749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Document",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(8680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 9, 27, 19, 3, 40, 980, DateTimeKind.Utc).AddTicks(4565));
        }
    }
}
