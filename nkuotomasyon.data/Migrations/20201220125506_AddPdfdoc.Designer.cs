﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using nkuotomasyon.data.Concrete.EfCore;

namespace nkuotomasyon.data.Migrations
{
    [DbContext(typeof(NkuContext))]
    [Migration("20201220125506_AddPdfdoc")]
    partial class AddPdfdoc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("nkuotomasyon.entity.ClassRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClassRoomCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClassRoomName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FacultyId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("ClassRooms");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FacultyName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Average")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("FailedAbsenteeism")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("FailedLowGrade")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FinalExam")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GradeLetter")
                        .HasColumnType("TEXT");

                    b.Property<string>("LessonCode")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MakeUpExam")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MidTerm")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LessonCode");

                    b.HasIndex("StudentId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Lesson", b =>
                {
                    b.Property<string>("LessonCode")
                        .HasColumnType("TEXT");

                    b.Property<int>("Akts")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ExamClassRoomId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FinalExamTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LessonClassRoomId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LessonDay")
                        .HasColumnType("TEXT");

                    b.Property<string>("LessonName")
                        .HasColumnType("TEXT");

                    b.Property<int>("LessonStartHour")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LessonofNumber")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("MakeUpExamTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("MidTermTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("PracticeTime")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SemesterId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StudyProgramId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StudyTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("TeacherId")
                        .HasColumnType("TEXT");

                    b.Property<int>("TheoryTime")
                        .HasColumnType("INTEGER");

                    b.HasKey("LessonCode");

                    b.HasIndex("ExamClassRoomId");

                    b.HasIndex("LessonClassRoomId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("StudyProgramId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("nkuotomasyon.entity.PdfFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LessonCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("LessonCode1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PublicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LessonCode1");

                    b.ToTable("PdfFiles");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PublicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Semester", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SemesterName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Student", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FacultyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RegistrationTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("SchoolNumber")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SemesterId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StudyProgramId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TcNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("StudyProgramId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("nkuotomasyon.entity.StudyLesson", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LessonCode")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId", "LessonCode");

                    b.HasIndex("LessonCode");

                    b.ToTable("StudyLessons");
                });

            modelBuilder.Entity("nkuotomasyon.entity.StudyProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FacultyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProgramName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StudyTimeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("StudyTimeId");

                    b.ToTable("StudyPrograms");
                });

            modelBuilder.Entity("nkuotomasyon.entity.StudyTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StudyTimes");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Teacher", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StudyProgramId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StudyProgramId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("nkuotomasyon.entity.ClassRoom", b =>
                {
                    b.HasOne("nkuotomasyon.entity.Faculty", "Faculty")
                        .WithMany("ClassRooms")
                        .HasForeignKey("FacultyId");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Grade", b =>
                {
                    b.HasOne("nkuotomasyon.entity.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonCode");

                    b.HasOne("nkuotomasyon.entity.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentId");

                    b.Navigation("Lesson");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Lesson", b =>
                {
                    b.HasOne("nkuotomasyon.entity.ClassRoom", "ExamClassRoom")
                        .WithMany()
                        .HasForeignKey("ExamClassRoomId");

                    b.HasOne("nkuotomasyon.entity.ClassRoom", "LessonClassRoom")
                        .WithMany()
                        .HasForeignKey("LessonClassRoomId");

                    b.HasOne("nkuotomasyon.entity.Semester", "Semester")
                        .WithMany("Lessons")
                        .HasForeignKey("SemesterId");

                    b.HasOne("nkuotomasyon.entity.StudyProgram", "StudyProgram")
                        .WithMany("Lessons")
                        .HasForeignKey("StudyProgramId");

                    b.HasOne("nkuotomasyon.entity.Teacher", "Teacher")
                        .WithMany("Lessons")
                        .HasForeignKey("TeacherId");

                    b.Navigation("ExamClassRoom");

                    b.Navigation("LessonClassRoom");

                    b.Navigation("Semester");

                    b.Navigation("StudyProgram");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("nkuotomasyon.entity.PdfFile", b =>
                {
                    b.HasOne("nkuotomasyon.entity.Lesson", "Lesson")
                        .WithMany("PdfFiles")
                        .HasForeignKey("LessonCode1");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Photo", b =>
                {
                    b.HasOne("nkuotomasyon.entity.Student", "Student")
                        .WithOne("Photo")
                        .HasForeignKey("nkuotomasyon.entity.Photo", "StudentId");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Student", b =>
                {
                    b.HasOne("nkuotomasyon.entity.Faculty", "Faculty")
                        .WithMany("Students")
                        .HasForeignKey("FacultyId");

                    b.HasOne("nkuotomasyon.entity.Semester", "Semester")
                        .WithMany("Students")
                        .HasForeignKey("SemesterId");

                    b.HasOne("nkuotomasyon.entity.StudyProgram", "StudyProgram")
                        .WithMany("Students")
                        .HasForeignKey("StudyProgramId");

                    b.Navigation("Faculty");

                    b.Navigation("Semester");

                    b.Navigation("StudyProgram");
                });

            modelBuilder.Entity("nkuotomasyon.entity.StudyLesson", b =>
                {
                    b.HasOne("nkuotomasyon.entity.Lesson", "Lesson")
                        .WithMany("StudyLessons")
                        .HasForeignKey("LessonCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("nkuotomasyon.entity.Student", "Student")
                        .WithMany("StudyLessons")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("nkuotomasyon.entity.StudyProgram", b =>
                {
                    b.HasOne("nkuotomasyon.entity.Faculty", "Faculty")
                        .WithMany("StudyPrograms")
                        .HasForeignKey("FacultyId");

                    b.HasOne("nkuotomasyon.entity.StudyTime", "StudyTime")
                        .WithMany("StudyPrograms")
                        .HasForeignKey("StudyTimeId");

                    b.Navigation("Faculty");

                    b.Navigation("StudyTime");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Teacher", b =>
                {
                    b.HasOne("nkuotomasyon.entity.StudyProgram", "StudyProgram")
                        .WithMany("Teachers")
                        .HasForeignKey("StudyProgramId");

                    b.Navigation("StudyProgram");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Faculty", b =>
                {
                    b.Navigation("ClassRooms");

                    b.Navigation("Students");

                    b.Navigation("StudyPrograms");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Lesson", b =>
                {
                    b.Navigation("PdfFiles");

                    b.Navigation("StudyLessons");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Semester", b =>
                {
                    b.Navigation("Lessons");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Student", b =>
                {
                    b.Navigation("Grades");

                    b.Navigation("Photo");

                    b.Navigation("StudyLessons");
                });

            modelBuilder.Entity("nkuotomasyon.entity.StudyProgram", b =>
                {
                    b.Navigation("Lessons");

                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("nkuotomasyon.entity.StudyTime", b =>
                {
                    b.Navigation("StudyPrograms");
                });

            modelBuilder.Entity("nkuotomasyon.entity.Teacher", b =>
                {
                    b.Navigation("Lessons");
                });
#pragma warning restore 612, 618
        }
    }
}
