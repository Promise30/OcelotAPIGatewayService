﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School_Management.Data;

#nullable disable

namespace SchoolManagementAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230917184935_initialAndSed")]
    partial class initialAndSed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "28eadcdc-0255-4dd4-9682-cac99e08cc0a",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "8c658823-0866-4c7f-8716-8622eb2989f3",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("School_Management.Models.ApiUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("School_Management.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseCode = "CSC236",
                            CourseName = "Introduction to Algorithms",
                            DepartmentId = 1,
                            Description = "A concise study on the art of writing software algorithms."
                        },
                        new
                        {
                            CourseId = 2,
                            CourseCode = "STA221",
                            CourseName = "Probability Distribution II",
                            DepartmentId = 2,
                            Description = "A deep dive into the study of probability and statistical theory"
                        },
                        new
                        {
                            CourseId = 3,
                            CourseCode = "CSC293",
                            CourseName = "Web Programming",
                            DepartmentId = 1,
                            Description = "Introduction to building web application with HTML. CSS, JS and PHP"
                        },
                        new
                        {
                            CourseId = 4,
                            CourseCode = "STA105",
                            CourseName = "Introduction to Probability",
                            DepartmentId = 2,
                            Description = "An introduction to the basics of probability theory"
                        });
                });

            modelBuilder.Entity("School_Management.Models.CourseStudent", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("CourseStudent");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            StudentId = 1
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 1
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 1
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 5
                        },
                        new
                        {
                            CourseId = 4,
                            StudentId = 5
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 2
                        },
                        new
                        {
                            CourseId = 4,
                            StudentId = 2
                        },
                        new
                        {
                            CourseId = 3,
                            StudentId = 3
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 6
                        });
                });

            modelBuilder.Entity("School_Management.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearFounded")
                        .HasColumnType("datetime2");

                    b.HasKey("DepartmentId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            Description = "Focuses on the study of computer systems, algorithms, programming languages and software development.",
                            FacultyId = 1,
                            Name = "Computer Science",
                            YearFounded = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DepartmentId = 2,
                            Description = "Dedicated to the collection, analysis, interpretation and presentation of numerical data.",
                            FacultyId = 1,
                            Name = "Statistics",
                            YearFounded = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DepartmentId = 3,
                            Description = "Concerned with the study of the Earth's structure, composition and processes that shape its history.",
                            FacultyId = 1,
                            Name = "Geology",
                            YearFounded = new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DepartmentId = 4,
                            Description = "Provides platform for expression effective communication",
                            FacultyId = 3,
                            Name = "Communication & Language Arts",
                            YearFounded = new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DepartmentId = 5,
                            Description = "Focuses on the study of economic systems,  theories of production and distribution and the analysis of economic behavior.",
                            FacultyId = 2,
                            Name = "Economics",
                            YearFounded = new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DepartmentId = 6,
                            Description = "A field of technology concerned with industrial practices.",
                            FacultyId = 4,
                            Name = "Industrial and Production Engineering",
                            YearFounded = new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("School_Management.Models.Faculty", b =>
                {
                    b.Property<int>("FacultyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacultyId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearFounded")
                        .HasColumnType("datetime2");

                    b.HasKey("FacultyId");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            FacultyId = 1,
                            Description = "Oldest Faculty of Science in any Nigerian University",
                            Name = "Science",
                            YearFounded = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            FacultyId = 2,
                            Description = "Provides fields of academic scholarship that explore aspects of human society",
                            Name = "Social Science",
                            YearFounded = new DateTime(1991, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            FacultyId = 3,
                            Description = "Premier faculty in the whole of Nigeria",
                            Name = "Arts",
                            YearFounded = new DateTime(1992, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            FacultyId = 4,
                            Description = "Home to advanced and modern innovation",
                            Name = "Technology",
                            YearFounded = new DateTime(1993, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("School_Management.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            BirthDate = new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            FirstName = "Shelby",
                            Gender = "Male",
                            LastName = "Sandy",
                            Major = "Computer Science",
                            MiddleName = "Smith"
                        },
                        new
                        {
                            StudentId = 2,
                            BirthDate = new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 2,
                            FirstName = "Seline",
                            Gender = "Male",
                            LastName = "Liam",
                            Major = "Statistics",
                            MiddleName = "Morgan"
                        },
                        new
                        {
                            StudentId = 3,
                            BirthDate = new DateTime(1999, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 5,
                            FirstName = "Xavier",
                            Gender = "Female",
                            LastName = "Bush",
                            Major = "Economics",
                            MiddleName = "Jordin"
                        },
                        new
                        {
                            StudentId = 4,
                            BirthDate = new DateTime(1998, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 6,
                            FirstName = "Becky",
                            Gender = "Male",
                            LastName = "Belair",
                            Major = "Industrial and Production Engineering",
                            MiddleName = "Lynch"
                        },
                        new
                        {
                            StudentId = 5,
                            BirthDate = new DateTime(1997, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            FirstName = "Fleck",
                            Gender = "Female",
                            LastName = "Jensen",
                            Major = "Computer Science",
                            MiddleName = "Wiz"
                        },
                        new
                        {
                            StudentId = 6,
                            BirthDate = new DateTime(1996, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 2,
                            FirstName = "Carmella",
                            Gender = "Male",
                            LastName = "Chelsea",
                            Major = "Statistics",
                            MiddleName = "Green"
                        });
                });

            modelBuilder.Entity("School_Management.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.HasIndex("CourseId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            BirthDate = new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CourseId = 1,
                            FirstName = "Ashley",
                            LastName = "Barbie",
                            MiddleName = "Bell"
                        },
                        new
                        {
                            TeacherId = 2,
                            BirthDate = new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CourseId = 1,
                            FirstName = "Pierce",
                            LastName = "Slitz",
                            MiddleName = "Joe"
                        },
                        new
                        {
                            TeacherId = 3,
                            BirthDate = new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CourseId = 4,
                            FirstName = "Frost",
                            LastName = "Lauren",
                            MiddleName = "Slazer"
                        },
                        new
                        {
                            TeacherId = 4,
                            BirthDate = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CourseId = 3,
                            FirstName = "Goldberg",
                            LastName = "Celen",
                            MiddleName = "Lore"
                        },
                        new
                        {
                            TeacherId = 5,
                            BirthDate = new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CourseId = 2,
                            FirstName = "Fresley",
                            LastName = "Gred",
                            MiddleName = "Piz"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("School_Management.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("School_Management.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School_Management.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("School_Management.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School_Management.Models.Course", b =>
                {
                    b.HasOne("School_Management.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("School_Management.Models.CourseStudent", b =>
                {
                    b.HasOne("School_Management.Models.Course", "Course")
                        .WithMany("CourseStudents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("School_Management.Models.Student", "Student")
                        .WithMany("CourseStudents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("School_Management.Models.Department", b =>
                {
                    b.HasOne("School_Management.Models.Faculty", "Faculty")
                        .WithMany("Departments")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("School_Management.Models.Student", b =>
                {
                    b.HasOne("School_Management.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("School_Management.Models.Teacher", b =>
                {
                    b.HasOne("School_Management.Models.Course", "Course")
                        .WithMany("Teachers")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("School_Management.Models.Course", b =>
                {
                    b.Navigation("CourseStudents");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("School_Management.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("School_Management.Models.Faculty", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("School_Management.Models.Student", b =>
                {
                    b.Navigation("CourseStudents");
                });
#pragma warning restore 612, 618
        }
    }
}
