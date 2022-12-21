﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolWebApp.Data;

#nullable disable

namespace SchoolWebApp.Migrations
{
    [DbContext(typeof(SchoolDataContext))]
    [Migration("20221010171738_Teacher_AddListSubject")]
    partial class Teacher_AddListSubject
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolWebApp.Models.Mark", b =>
                {
                    b.Property<int>("MarkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarkID"), 1L, 1);

                    b.Property<string>("AmericanValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PolishValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarkID");

                    b.ToTable("Marks");

                    b.HasData(
                        new
                        {
                            MarkID = 1,
                            AmericanValue = "F",
                            PolishValue = "Niedostateczny"
                        },
                        new
                        {
                            MarkID = 2,
                            AmericanValue = "E",
                            PolishValue = "Dopuszczający"
                        },
                        new
                        {
                            MarkID = 3,
                            AmericanValue = "D",
                            PolishValue = "Dostateczny"
                        },
                        new
                        {
                            MarkID = 4,
                            AmericanValue = "C",
                            PolishValue = "Dobry"
                        },
                        new
                        {
                            MarkID = 5,
                            AmericanValue = "B",
                            PolishValue = "Bardzo Dobry"
                        },
                        new
                        {
                            MarkID = 6,
                            AmericanValue = "A",
                            PolishValue = "Celujacy"
                        });
                });

            modelBuilder.Entity("SchoolWebApp.Models.SchoolLevel", b =>
                {
                    b.Property<int>("SchoolLevelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchoolLevelID"), 1L, 1);

                    b.Property<string>("LevelValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfSchool")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchoolLevelID");

                    b.ToTable("SchoolLevels");

                    b.HasData(
                        new
                        {
                            SchoolLevelID = 1,
                            LevelValue = "First",
                            TypeOfSchool = "PrimerySchool"
                        },
                        new
                        {
                            SchoolLevelID = 2,
                            LevelValue = "Second",
                            TypeOfSchool = "PrimerySchool"
                        },
                        new
                        {
                            SchoolLevelID = 3,
                            LevelValue = "Third",
                            TypeOfSchool = "PrimerySchool"
                        },
                        new
                        {
                            SchoolLevelID = 4,
                            LevelValue = "Fourth",
                            TypeOfSchool = "PrimerySchool"
                        },
                        new
                        {
                            SchoolLevelID = 5,
                            LevelValue = "Fifth",
                            TypeOfSchool = "PrimerySchool"
                        },
                        new
                        {
                            SchoolLevelID = 6,
                            LevelValue = "Sixth",
                            TypeOfSchool = "PrimerySchool"
                        },
                        new
                        {
                            SchoolLevelID = 7,
                            LevelValue = "First",
                            TypeOfSchool = "MiddleSchool"
                        },
                        new
                        {
                            SchoolLevelID = 8,
                            LevelValue = "Second",
                            TypeOfSchool = "MiddleSchool"
                        },
                        new
                        {
                            SchoolLevelID = 9,
                            LevelValue = "Third",
                            TypeOfSchool = "MiddleSchool"
                        },
                        new
                        {
                            SchoolLevelID = 10,
                            LevelValue = "First",
                            TypeOfSchool = "HighSchool"
                        },
                        new
                        {
                            SchoolLevelID = 11,
                            LevelValue = "Second",
                            TypeOfSchool = "HighSchool"
                        },
                        new
                        {
                            SchoolLevelID = 12,
                            LevelValue = "Third",
                            TypeOfSchool = "HighSchool"
                        });
                });

            modelBuilder.Entity("SchoolWebApp.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("SchoolLevelID")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.HasIndex("SchoolLevelID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentID = 1,
                            DateOfBirth = new DateTime(1991, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolLevelID = 10,
                            StudentName = "Anna",
                            StudentSurname = "Snochowska"
                        },
                        new
                        {
                            StudentID = 2,
                            DateOfBirth = new DateTime(1988, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolLevelID = 5,
                            StudentName = "Jacek",
                            StudentSurname = "Abramczyk"
                        },
                        new
                        {
                            StudentID = 3,
                            DateOfBirth = new DateTime(1991, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolLevelID = 12,
                            StudentName = "Agnieszka",
                            StudentSurname = "Jankowska"
                        },
                        new
                        {
                            StudentID = 4,
                            DateOfBirth = new DateTime(1991, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolLevelID = 2,
                            StudentName = "Patryk",
                            StudentSurname = "Baj"
                        },
                        new
                        {
                            StudentID = 5,
                            DateOfBirth = new DateTime(1991, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolLevelID = 2,
                            StudentName = "Rosselina",
                            StudentSurname = "Drożyńska"
                        },
                        new
                        {
                            StudentID = 6,
                            DateOfBirth = new DateTime(1983, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolLevelID = 9,
                            StudentName = "Łukasz",
                            StudentSurname = "Kalinowski"
                        },
                        new
                        {
                            StudentID = 7,
                            DateOfBirth = new DateTime(1982, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolLevelID = 7,
                            StudentName = "Anna",
                            StudentSurname = "Kalinowska"
                        },
                        new
                        {
                            StudentID = 8,
                            DateOfBirth = new DateTime(1985, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolLevelID = 11,
                            StudentName = "Karol",
                            StudentSurname = "Kiełbiński"
                        },
                        new
                        {
                            StudentID = 9,
                            DateOfBirth = new DateTime(1995, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolLevelID = 1,
                            StudentName = "Anna",
                            StudentSurname = "Krzyżanowska"
                        },
                        new
                        {
                            StudentID = 10,
                            DateOfBirth = new DateTime(1993, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SchoolLevelID = 1,
                            StudentName = "Beata",
                            StudentSurname = "Turczuk"
                        });
                });

            modelBuilder.Entity("SchoolWebApp.Models.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectID"), 1L, 1);

                    b.Property<string>("ClassroomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HoursPerWeek")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("SubjectID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            SubjectID = 1,
                            ClassroomNumber = "1A",
                            HoursPerWeek = 5,
                            SubjectName = "Math",
                            TeacherID = 1
                        },
                        new
                        {
                            SubjectID = 2,
                            ClassroomNumber = "2A",
                            HoursPerWeek = 3,
                            SubjectName = "Polish",
                            TeacherID = 2
                        },
                        new
                        {
                            SubjectID = 3,
                            ClassroomNumber = "2B",
                            HoursPerWeek = 4,
                            SubjectName = "English",
                            TeacherID = 3
                        },
                        new
                        {
                            SubjectID = 4,
                            ClassroomNumber = "2C",
                            HoursPerWeek = 2,
                            SubjectName = "History",
                            TeacherID = 2
                        },
                        new
                        {
                            SubjectID = 5,
                            ClassroomNumber = "3A",
                            HoursPerWeek = 2,
                            SubjectName = "Geografy",
                            TeacherID = 7
                        },
                        new
                        {
                            SubjectID = 6,
                            ClassroomNumber = "4A",
                            HoursPerWeek = 1,
                            SubjectName = "Art",
                            TeacherID = 5
                        },
                        new
                        {
                            SubjectID = 7,
                            ClassroomNumber = "Gym",
                            HoursPerWeek = 4,
                            SubjectName = "PE",
                            TeacherID = 4
                        },
                        new
                        {
                            SubjectID = 8,
                            ClassroomNumber = "1B",
                            HoursPerWeek = 2,
                            SubjectName = "Physics",
                            TeacherID = 1
                        },
                        new
                        {
                            SubjectID = 9,
                            ClassroomNumber = "3B",
                            HoursPerWeek = 3,
                            SubjectName = "Chemistry",
                            TeacherID = 6
                        },
                        new
                        {
                            SubjectID = 10,
                            ClassroomNumber = "3C",
                            HoursPerWeek = 1,
                            SubjectName = "Biology",
                            TeacherID = 6
                        });
                });

            modelBuilder.Entity("SchoolWebApp.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherID"), 1L, 1);

                    b.Property<int>("ExperienceInYears")
                        .HasColumnType("int");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherID = 1,
                            ExperienceInYears = 5,
                            TeacherName = "Jolanta",
                            TeacherSurname = "Matmiewska"
                        },
                        new
                        {
                            TeacherID = 2,
                            ExperienceInYears = 4,
                            TeacherName = "Paweł",
                            TeacherSurname = "Polski"
                        },
                        new
                        {
                            TeacherID = 3,
                            ExperienceInYears = 9,
                            TeacherName = "Alicja",
                            TeacherSurname = "Angielski"
                        },
                        new
                        {
                            TeacherID = 4,
                            ExperienceInYears = 2,
                            TeacherName = "Jan",
                            TeacherSurname = "Silka"
                        },
                        new
                        {
                            TeacherID = 5,
                            ExperienceInYears = 1,
                            TeacherName = "Mateusz",
                            TeacherSurname = "Sztukowski"
                        },
                        new
                        {
                            TeacherID = 6,
                            ExperienceInYears = 5,
                            TeacherName = "Wojciech",
                            TeacherSurname = "Bioloski"
                        },
                        new
                        {
                            TeacherID = 7,
                            ExperienceInYears = 7,
                            TeacherName = "Anna",
                            TeacherSurname = "Mapa"
                        });
                });

            modelBuilder.Entity("SchoolWebApp.Models.Student", b =>
                {
                    b.HasOne("SchoolWebApp.Models.SchoolLevel", null)
                        .WithMany("Students")
                        .HasForeignKey("SchoolLevelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolWebApp.Models.Subject", b =>
                {
                    b.HasOne("SchoolWebApp.Models.Teacher", null)
                        .WithMany("Subjects")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolWebApp.Models.SchoolLevel", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("SchoolWebApp.Models.Teacher", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
