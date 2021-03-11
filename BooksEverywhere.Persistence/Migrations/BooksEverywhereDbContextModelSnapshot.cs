﻿// <auto-generated />
using System;
using BooksEverywhere.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BooksEverywhere.Persistence.Migrations
{
    [DbContext(typeof(BooksEverywhereDbContext))]
    partial class BooksEverywhereDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountStatus")
                        .HasColumnType("int");

                    b.Property<int>("LibraryUserId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LibraryUserId")
                        .IsUnique();

                    b.ToTable("Account");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookStatus")
                        .HasColumnType("int");

                    b.Property<int?>("ShelfId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShelfId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.BookCallNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("PublishedYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.HasIndex("SubjectId");

                    b.ToTable("BookCallNumber");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.BookCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("LibraryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomLocationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.HasIndex("LibraryId");

                    b.HasIndex("RoomLocationId");

                    b.ToTable("BookCollections");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.BookDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int?>("AuthorId1")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId1");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.BookEdition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookDetailsId")
                        .HasColumnType("int");

                    b.Property<int>("Copies")
                        .HasColumnType("int");

                    b.Property<string>("CoverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublishedYear")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookDetailsId");

                    b.ToTable("BookEdition");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.BookLend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LibraryUserId")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LibraryUserId")
                        .IsUnique();

                    b.ToTable("BookLend");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.BookTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("BookNumber")
                        .HasColumnType("int");

                    b.Property<string>("Copy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublishedYear")
                        .HasColumnType("int");

                    b.Property<string>("VolumeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("BookTag");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Fine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("BookLendId")
                        .HasColumnType("int");

                    b.Property<int>("LendStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookLendId")
                        .IsUnique();

                    b.ToTable("Fine");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Library");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.LibraryCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LibraryUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LibraryUserId")
                        .IsUnique();

                    b.ToTable("LibraryCard");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.LibraryInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LibraryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Schedule")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LibraryId")
                        .IsUnique();

                    b.ToTable("LibraryInfo");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.LibraryUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(254)
                        .HasColumnType("nvarchar(254)");

                    b.Property<int>("LibraryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LibraryId");

                    b.ToTable("LibraryUser");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookLendId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CreatedOn")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BookLendId");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LibraryId")
                        .HasColumnType("int");

                    b.Property<int?>("LibraryInfoId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LibraryId");

                    b.HasIndex("LibraryInfoId");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Shelf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShelfCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StackId");

                    b.ToTable("Shelf");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Stack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<string>("StackCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StackTagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("StackTagId");

                    b.ToTable("Stack");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.StackTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BooksRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("StackTag");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookDetailsId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Subsidiary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LibraryId")
                        .HasColumnType("int");

                    b.Property<int?>("LibraryInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LibraryId");

                    b.HasIndex("LibraryInfoId");

                    b.ToTable("Subsidiary");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Account", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.LibraryUser", "LibraryUser")
                        .WithOne("Account")
                        .HasForeignKey("BooksEverywhere.Domain.Entities.Account", "LibraryUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LibraryUser");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Book", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.Shelf", null)
                        .WithMany("Books")
                        .HasForeignKey("ShelfId");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.BookCallNumber", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.Book", "Book")
                        .WithOne("BookCallNumber")
                        .HasForeignKey("BooksEverywhere.Domain.Entities.BookCallNumber", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BooksEverywhere.Domain.Entities.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.Navigation("Book");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.BookCollection", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.Book", "Book")
                        .WithOne("BookCollection")
                        .HasForeignKey("BooksEverywhere.Domain.Entities.BookCollection", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BooksEverywhere.Domain.Entities.Library", "Library")
                        .WithMany("BooksCollection")
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BooksEverywhere.Domain.Entities.Room", "RoomLocation")
                        .WithMany()
                        .HasForeignKey("RoomLocationId");

                    b.Navigation("Book");

                    b.Navigation("Library");

                    b.Navigation("RoomLocation");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.BookDetails", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId1");

                    b.HasOne("BooksEverywhere.Domain.Entities.Book", "Book")
                        .WithOne("BookDetails")
                        .HasForeignKey("BooksEverywhere.Domain.Entities.BookDetails", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.BookEdition", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.BookDetails", null)
                        .WithMany("BookEditions")
                        .HasForeignKey("BookDetailsId");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.BookLend", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.LibraryUser", "LibraryUser")
                        .WithOne("BookLend")
                        .HasForeignKey("BooksEverywhere.Domain.Entities.BookLend", "LibraryUserId");

                    b.Navigation("LibraryUser");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.BookTag", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.Book", "Book")
                        .WithOne("BookTag")
                        .HasForeignKey("BooksEverywhere.Domain.Entities.BookTag", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Fine", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.BookLend", "BookLend")
                        .WithOne("Fine")
                        .HasForeignKey("BooksEverywhere.Domain.Entities.Fine", "BookLendId");

                    b.Navigation("BookLend");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.LibraryCard", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.LibraryUser", "LibraryUser")
                        .WithOne("LibraryCard")
                        .HasForeignKey("BooksEverywhere.Domain.Entities.LibraryCard", "LibraryUserId");

                    b.Navigation("LibraryUser");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.LibraryInfo", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.Library", "Library")
                        .WithOne("libraryInfo")
                        .HasForeignKey("BooksEverywhere.Domain.Entities.LibraryInfo", "LibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Library");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.LibraryUser", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.Library", "Library")
                        .WithMany("Users")
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Library");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Notification", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.BookLend", "BookLend")
                        .WithMany("Notifications")
                        .HasForeignKey("BookLendId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookLend");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Room", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.Library", "Library")
                        .WithMany("Rooms")
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BooksEverywhere.Domain.Entities.LibraryInfo", null)
                        .WithMany("Rooms")
                        .HasForeignKey("LibraryInfoId");

                    b.Navigation("Library");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Shelf", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.Stack", null)
                        .WithMany("Shelves")
                        .HasForeignKey("StackId");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Stack", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.Room", null)
                        .WithMany("Stacks")
                        .HasForeignKey("RoomId");

                    b.HasOne("BooksEverywhere.Domain.Entities.StackTag", "StackTag")
                        .WithMany()
                        .HasForeignKey("StackTagId");

                    b.Navigation("StackTag");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.StackTag", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Subject", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.BookDetails", null)
                        .WithMany("Subjects")
                        .HasForeignKey("BookDetailsId");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Subsidiary", b =>
                {
                    b.HasOne("BooksEverywhere.Domain.Entities.Library", "Library")
                        .WithMany("Subsidiaries")
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BooksEverywhere.Domain.Entities.LibraryInfo", "LibraryInfo")
                        .WithMany()
                        .HasForeignKey("LibraryInfoId");

                    b.Navigation("Library");

                    b.Navigation("LibraryInfo");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Book", b =>
                {
                    b.Navigation("BookCallNumber");

                    b.Navigation("BookCollection");

                    b.Navigation("BookDetails");

                    b.Navigation("BookTag");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.BookDetails", b =>
                {
                    b.Navigation("BookEditions");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.BookLend", b =>
                {
                    b.Navigation("Fine");

                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Library", b =>
                {
                    b.Navigation("BooksCollection");

                    b.Navigation("libraryInfo");

                    b.Navigation("Rooms");

                    b.Navigation("Subsidiaries");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.LibraryInfo", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.LibraryUser", b =>
                {
                    b.Navigation("Account");

                    b.Navigation("BookLend");

                    b.Navigation("LibraryCard");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Room", b =>
                {
                    b.Navigation("Stacks");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Shelf", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BooksEverywhere.Domain.Entities.Stack", b =>
                {
                    b.Navigation("Shelves");
                });
#pragma warning restore 612, 618
        }
    }
}
