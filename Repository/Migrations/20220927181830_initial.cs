using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Language",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageCulture = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UniqueSeoCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    TimeZone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Picture",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BinaryData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectoryPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QueuedEmail",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReplyTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplyToName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BCC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(8862)),
                    DontSendBeforeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SentTries = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueuedEmail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleTask",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    Seconds = table.Column<int>(type: "int", nullable: false),
                    LastStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastSuccess = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StopOnError = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleTask", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemplateCategory",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(9083)),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalizedProperty",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    LocalKeyGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalizedProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalizedProperty_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "dbo",
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocalStringResource",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    ResourceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourceValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalStringResource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalStringResource_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "dbo",
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ExternalLogin = table.Column<bool>(type: "bit", nullable: false),
                    LastIpAddress = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(7293)),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false),
                    PictureId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Picture_PictureId",
                        column: x => x.PictureId,
                        principalSchema: "dbo",
                        principalTable: "Picture",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Document",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectoryPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(8680))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Document_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogLevel = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ShortMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(7806))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Log_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Template",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    TemplateBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(9250)),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedAdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Template", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Template_TemplateCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "dbo",
                        principalTable: "TemplateCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Template_User_CreatedAdminId",
                        column: x => x.CreatedAdminId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserActivity",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityLevel = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(7972))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActivity_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPassword",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordFormatId = table.Column<int>(type: "int", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(7611))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPassword", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPassword_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserReview",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplyText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Approved = table.Column<int>(type: "int", nullable: false),
                    TotalLike = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TotalDislike = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(8520))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserReview_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSettings",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSettings_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemplateProfile",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(9700)),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateProfile_Template_TemplateId",
                        column: x => x.TemplateId,
                        principalSchema: "dbo",
                        principalTable: "Template",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemplateSection",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    HasComponent = table.Column<bool>(type: "bit", nullable: false),
                    HasSubComponent = table.Column<bool>(type: "bit", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedAdminId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 9, 27, 18, 18, 30, 105, DateTimeKind.Utc).AddTicks(9414))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateSection_Template_TemplateId",
                        column: x => x.TemplateId,
                        principalSchema: "dbo",
                        principalTable: "Template",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemplateTag",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateTag_Template_TemplateId",
                        column: x => x.TemplateId,
                        principalSchema: "dbo",
                        principalTable: "Template",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemplateSettings",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateSettings_TemplateProfile_ProfileId",
                        column: x => x.ProfileId,
                        principalSchema: "dbo",
                        principalTable: "TemplateProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemplateComponent",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateSectionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniqueTag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasRedirectUrl = table.Column<bool>(type: "bit", nullable: false),
                    RedirectUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasSubComponenet = table.Column<bool>(type: "bit", nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateComponent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateComponent_TemplateSection_TemplateSectionId",
                        column: x => x.TemplateSectionId,
                        principalSchema: "dbo",
                        principalTable: "TemplateSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemplateSubComponent",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateComponentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniqueTag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasRedirectUrl = table.Column<bool>(type: "bit", nullable: false),
                    RedirectUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateSubComponent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateSubComponent_TemplateComponent_TemplateComponentId",
                        column: x => x.TemplateComponentId,
                        principalSchema: "dbo",
                        principalTable: "TemplateComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemplateKeyValuePair",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateSubComponentId = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Required = table.Column<bool>(type: "bit", nullable: false),
                    HasRedirectUrl = table.Column<bool>(type: "bit", nullable: false),
                    RedirectUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateKeyValuePair", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateKeyValuePair_TemplateSubComponent_TemplateSubComponentId",
                        column: x => x.TemplateSubComponentId,
                        principalSchema: "dbo",
                        principalTable: "TemplateSubComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_UserId",
                schema: "dbo",
                table: "Document",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalizedProperty_LanguageId",
                schema: "dbo",
                table: "LocalizedProperty",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalStringResource_LanguageId",
                schema: "dbo",
                table: "LocalStringResource",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Log_UserId",
                schema: "dbo",
                table: "Log",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Template_CategoryId",
                schema: "dbo",
                table: "Template",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Template_CreatedAdminId",
                schema: "dbo",
                table: "Template",
                column: "CreatedAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateComponent_TemplateSectionId",
                schema: "dbo",
                table: "TemplateComponent",
                column: "TemplateSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateKeyValuePair_TemplateSubComponentId",
                schema: "dbo",
                table: "TemplateKeyValuePair",
                column: "TemplateSubComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateProfile_TemplateId",
                schema: "dbo",
                table: "TemplateProfile",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateSection_TemplateId",
                schema: "dbo",
                table: "TemplateSection",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateSettings_ProfileId",
                schema: "dbo",
                table: "TemplateSettings",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateSubComponent_TemplateComponentId",
                schema: "dbo",
                table: "TemplateSubComponent",
                column: "TemplateComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateTag_TemplateId",
                schema: "dbo",
                table: "TemplateTag",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PictureId",
                schema: "dbo",
                table: "User",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivity_UserId",
                schema: "dbo",
                table: "UserActivity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPassword_UserId",
                schema: "dbo",
                table: "UserPassword",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReview_UserId",
                schema: "dbo",
                table: "UserReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSettings_UserId",
                schema: "dbo",
                table: "UserSettings",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "LocalizedProperty",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "LocalStringResource",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Log",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "QueuedEmail",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ScheduleTask",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Settings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TemplateKeyValuePair",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TemplateSettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TemplateTag",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserActivity",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserPassword",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserReview",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserSettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Language",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TemplateSubComponent",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TemplateProfile",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TemplateComponent",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TemplateSection",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Template",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TemplateCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "User",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Picture",
                schema: "dbo");
        }
    }
}
