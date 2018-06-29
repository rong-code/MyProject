﻿// <auto-generated />
using System;
using EF_Core_Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_Core_Web.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EF_Core_Web.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Course");

                    b.HasData(
                        new { Id = 1, Name = "语文" },
                        new { Id = 2, Name = "数学" },
                        new { Id = 3, Name = "英语" }
                    );
                });

            modelBuilder.Entity("EF_Core_Web.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("SId");

                    b.HasKey("Id");

                    b.HasIndex("SId");

                    b.ToTable("Grade");

                    b.HasData(
                        new { Id = 1, Code = "一年级", Name = "一年级", SId = 1 },
                        new { Id = 2, Code = "二年级", Name = "二年级", SId = 1 },
                        new { Id = 3, Code = "初一", Name = "初一", SId = 2 },
                        new { Id = 4, Code = "初二", Name = "初二", SId = 2 }
                    );
                });

            modelBuilder.Entity("EF_Core_Web.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<DateTime>("LastUpdated");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Remark");

                    b.Property<string>("flag");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("EF_Core_Web.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.Property<string>("Other");

                    b.HasKey("Id");

                    b.ToTable("School");

                    b.HasData(
                        new { Id = 1, Code = "小学", Name = "小学" },
                        new { Id = 2, Code = "中学", Name = "中学" }
                    );
                });

            modelBuilder.Entity("EF_Core_Web.Models.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseId");

                    b.Property<int>("StuId");

                    b.Property<double>("scoreSize");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StuId");

                    b.ToTable("Score");

                    b.HasData(
                        new { Id = 1, CourseId = 1, StuId = 1, scoreSize = 50.0 },
                        new { Id = 2, CourseId = 2, StuId = 1, scoreSize = 60.0 },
                        new { Id = 3, CourseId = 3, StuId = 1, scoreSize = 70.0 },
                        new { Id = 4, CourseId = 1, StuId = 2, scoreSize = 80.0 },
                        new { Id = 5, CourseId = 3, StuId = 2, scoreSize = 90.0 }
                    );
                });

            modelBuilder.Entity("EF_Core_Web.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("DisplayName");

                    b.Property<string>("EnglishName");

                    b.Property<int>("GradeId");

                    b.Property<string>("JobName");

                    b.Property<string>("Mount")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.ToTable("t_teacher","my_test");

                    b.HasData(
                        new { Id = 1, Age = 0, EnglishName = "zhangsan", GradeId = 1, Mount = "Donkey", Name = "老师A" },
                        new { Id = 2, Age = 0, EnglishName = "wanger", GradeId = 1, Mount = "0", Name = "老师B" },
                        new { Id = 3, Age = 0, GradeId = 2, Mount = "Horse", Name = "老师C" }
                    );
                });

            modelBuilder.Entity("EF_Core_Web.Models.Student", b =>
                {
                    b.HasBaseType("EF_Core_Web.Models.Person");

                    b.Property<int>("GradeId");

                    b.Property<string>("Hobby");

                    b.Property<string>("Other");

                    b.HasIndex("GradeId");

                    b.ToTable("Student");

                    b.HasDiscriminator().HasValue("Student");

                    b.HasData(
                        new { Id = 1, Address = "花果山", LastUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "小明", GradeId = 1 },
                        new { Id = 2, Address = "上海", LastUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "张三", GradeId = 1 },
                        new { Id = 3, Address = "上海", LastUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "李四", GradeId = 1 },
                        new { Id = 4, Address = "上海", LastUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "王二", GradeId = 2 }
                    );
                });

            modelBuilder.Entity("EF_Core_Web.Models.StudentParent", b =>
                {
                    b.HasBaseType("EF_Core_Web.Models.Person");

                    b.Property<int?>("GradeId")
                        .HasColumnName("StudentParent_GradeId");

                    b.Property<string>("JobName");

                    b.Property<string>("Other")
                        .HasColumnName("StudentParent_Other");

                    b.Property<string>("Phone");

                    b.Property<int>("stuId");

                    b.HasIndex("GradeId");

                    b.HasIndex("stuId");

                    b.ToTable("StudentParent");

                    b.HasDiscriminator().HasValue("StudentParent");

                    b.HasData(
                        new { Id = 5, LastUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "小明他爹", stuId = 1 },
                        new { Id = 7, LastUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "张三他妈", stuId = 2 },
                        new { Id = 8, LastUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "李四他爹", stuId = 3 }
                    );
                });

            modelBuilder.Entity("EF_Core_Web.Models.Grade", b =>
                {
                    b.HasOne("EF_Core_Web.Models.School", "School")
                        .WithMany("Grades")
                        .HasForeignKey("SId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EF_Core_Web.Models.Score", b =>
                {
                    b.HasOne("EF_Core_Web.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EF_Core_Web.Models.Student", "Student")
                        .WithMany("Score")
                        .HasForeignKey("StuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EF_Core_Web.Models.Teacher", b =>
                {
                    b.HasOne("EF_Core_Web.Models.Grade", "Grade")
                        .WithMany("Teachers")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EF_Core_Web.Models.Student", b =>
                {
                    b.HasOne("EF_Core_Web.Models.Grade", "Grade")
                        .WithMany("Students")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EF_Core_Web.Models.StudentParent", b =>
                {
                    b.HasOne("EF_Core_Web.Models.Grade")
                        .WithMany("StudentParents")
                        .HasForeignKey("GradeId");

                    b.HasOne("EF_Core_Web.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("stuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
