﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksEverywhere.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libraries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LibraryInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Schedule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LibraryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryInfo_Libraries_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Libraries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LibraryUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    LibraryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryUsers_Libraries_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Libraries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LibraryId = table.Column<int>(type: "int", nullable: false),
                    LibraryInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Libraries_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Libraries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_LibraryInfo_LibraryInfoId",
                        column: x => x.LibraryInfoId,
                        principalTable: "LibraryInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subsidiaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibraryInfoId = table.Column<int>(type: "int", nullable: true),
                    LibraryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subsidiaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subsidiaries_Libraries_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Libraries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subsidiaries_LibraryInfo_LibraryInfoId",
                        column: x => x.LibraryInfoId,
                        principalTable: "LibraryInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountStatus = table.Column<int>(type: "int", nullable: false),
                    LibraryUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_LibraryUsers_LibraryUserId",
                        column: x => x.LibraryUserId,
                        principalTable: "LibraryUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookLends",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LendStatus = table.Column<int>(type: "int", nullable: false),
                    LibraryUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookLends", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookLends_LibraryUsers_LibraryUserId",
                        column: x => x.LibraryUserId,
                        principalTable: "LibraryUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LibraryCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LibraryUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryCard_LibraryUsers_LibraryUserId",
                        column: x => x.LibraryUserId,
                        principalTable: "LibraryUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookLendId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    LendStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fine_BookLends_BookLendId",
                        column: x => x.BookLendId,
                        principalTable: "BookLends",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookLendId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notification_BookLends_BookLendId",
                        column: x => x.BookLendId,
                        principalTable: "BookLends",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookStatus = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShelfId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomLocationId = table.Column<int>(type: "int", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    LibraryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookCollections_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCollections_Libraries_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Libraries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCollections_Rooms_RoomLocationId",
                        column: x => x.RoomLocationId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookEdition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishedYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Copies = table.Column<int>(type: "int", nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookEdition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookEdition_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookTag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookNumber = table.Column<int>(type: "int", nullable: false),
                    AuthorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishedYear = table.Column<int>(type: "int", nullable: false),
                    Copy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolumeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookTag_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookCallNumber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: true),
                    AuthorReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishedYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCallNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookCallNumber_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCallNumber_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StackTag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: true),
                    BooksRange = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StackTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StackTag_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StackCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StackTagId = table.Column<int>(type: "int", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stacks_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stacks_StackTag_StackTagId",
                        column: x => x.StackTagId,
                        principalTable: "StackTag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shelf",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShelfCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StackId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelf", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shelf_Stacks_StackId",
                        column: x => x.StackId,
                        principalTable: "Stacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_LibraryUserId",
                table: "Account",
                column: "LibraryUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookCallNumber_BookId",
                table: "BookCallNumber",
                column: "BookId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookCallNumber_SubjectId",
                table: "BookCallNumber",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCollections_BookId",
                table: "BookCollections",
                column: "BookId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookCollections_LibraryId",
                table: "BookCollections",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCollections_RoomLocationId",
                table: "BookCollections",
                column: "RoomLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_BookEdition_BookId",
                table: "BookEdition",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookLends_LibraryUserId",
                table: "BookLends",
                column: "LibraryUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_ShelfId",
                table: "Books",
                column: "ShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_BookTag_BookId",
                table: "BookTag",
                column: "BookId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fine_BookLendId",
                table: "Fine",
                column: "BookLendId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LibraryCard_LibraryUserId",
                table: "LibraryCard",
                column: "LibraryUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LibraryInfo_LibraryId",
                table: "LibraryInfo",
                column: "LibraryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LibraryUsers_LibraryId",
                table: "LibraryUsers",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_BookLendId",
                table: "Notification",
                column: "BookLendId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_LibraryId",
                table: "Rooms",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_LibraryInfoId",
                table: "Rooms",
                column: "LibraryInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Shelf_StackId",
                table: "Shelf",
                column: "StackId");

            migrationBuilder.CreateIndex(
                name: "IX_Stacks_RoomId",
                table: "Stacks",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Stacks_StackTagId",
                table: "Stacks",
                column: "StackTagId");

            migrationBuilder.CreateIndex(
                name: "IX_StackTag_SubjectId",
                table: "StackTag",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_BookId",
                table: "Subjects",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Subsidiaries_LibraryId",
                table: "Subsidiaries",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Subsidiaries_LibraryInfoId",
                table: "Subsidiaries",
                column: "LibraryInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Shelf_ShelfId",
                table: "Books",
                column: "ShelfId",
                principalTable: "Shelf",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Books_BookId",
                table: "Subjects");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "BookCallNumber");

            migrationBuilder.DropTable(
                name: "BookCollections");

            migrationBuilder.DropTable(
                name: "BookEdition");

            migrationBuilder.DropTable(
                name: "BookTag");

            migrationBuilder.DropTable(
                name: "Fine");

            migrationBuilder.DropTable(
                name: "LibraryCard");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "Subsidiaries");

            migrationBuilder.DropTable(
                name: "BookLends");

            migrationBuilder.DropTable(
                name: "LibraryUsers");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Shelf");

            migrationBuilder.DropTable(
                name: "Stacks");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "StackTag");

            migrationBuilder.DropTable(
                name: "LibraryInfo");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Libraries");
        }
    }
}
