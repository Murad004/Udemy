﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Udemy.DataAccess.Concrete.EntityFramework;

#nullable disable

namespace Udemy.DataAccess.Migrations
{
    [DbContext(typeof(UdemyContext))]
    [Migration("20230205190902_Init2")]
    partial class Init2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Udemy.Entity.Concrete.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartItemId"));

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartItemId");

                    b.HasIndex("CartId");

                    b.HasIndex("CourseId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("CourseId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CourseContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PaidOrFree")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("TeacherId");

                    b.HasIndex("TopicId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.ObjectiveAndOutcomes", b =>
                {
                    b.Property<int>("ObjectiveAndOutcomesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObjectiveAndOutcomesId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("ObjectiveAndOutcomesId");

                    b.HasIndex("CourseId");

                    b.ToTable("Objectives");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Requirement", b =>
                {
                    b.Property<int>("RequirementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequirementId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("RequirementId");

                    b.HasIndex("CourseId");

                    b.ToTable("Requirements");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubCategoryId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("AboutMe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FieldOfWork")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MyStudentCount")
                        .HasColumnType("int");

                    b.Property<string>("MyUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TopicId"));

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("TopicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Video", b =>
                {
                    b.Property<int>("VideoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VideoId"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VideoId");

                    b.HasIndex("CourseId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.CartItem", b =>
                {
                    b.HasOne("Udemy.Entity.Concrete.Cart", null)
                        .WithMany("CartItem")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Udemy.Entity.Concrete.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Comment", b =>
                {
                    b.HasOne("Udemy.Entity.Concrete.Course", null)
                        .WithMany("CourseComments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Course", b =>
                {
                    b.HasOne("Udemy.Entity.Concrete.Category", "Category")
                        .WithMany("Courses")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Udemy.Entity.Concrete.SubCategory", "SubCategory")
                        .WithMany("Courses")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Udemy.Entity.Concrete.Teacher", "Teacher")
                        .WithMany("MyCourses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Udemy.Entity.Concrete.Topic", "Topic")
                        .WithMany("Courses")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("SubCategory");

                    b.Navigation("Teacher");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.ObjectiveAndOutcomes", b =>
                {
                    b.HasOne("Udemy.Entity.Concrete.Course", null)
                        .WithMany("ObjectivesAndOutcomes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Requirement", b =>
                {
                    b.HasOne("Udemy.Entity.Concrete.Course", null)
                        .WithMany("Requirements")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.SubCategory", b =>
                {
                    b.HasOne("Udemy.Entity.Concrete.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Topic", b =>
                {
                    b.HasOne("Udemy.Entity.Concrete.SubCategory", "SubCategory")
                        .WithMany("Topics")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Video", b =>
                {
                    b.HasOne("Udemy.Entity.Concrete.Course", null)
                        .WithMany("CourseVideos")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Cart", b =>
                {
                    b.Navigation("CartItem");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Category", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Course", b =>
                {
                    b.Navigation("CourseComments");

                    b.Navigation("CourseVideos");

                    b.Navigation("ObjectivesAndOutcomes");

                    b.Navigation("Requirements");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.SubCategory", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Teacher", b =>
                {
                    b.Navigation("MyCourses");
                });

            modelBuilder.Entity("Udemy.Entity.Concrete.Topic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}