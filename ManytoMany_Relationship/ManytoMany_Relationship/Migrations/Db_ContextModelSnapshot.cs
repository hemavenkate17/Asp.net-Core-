﻿// <auto-generated />
using ManytoMany_Relationship.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManytoMany_Relationship.Migrations
{
    [DbContext(typeof(Db_Context))]
    partial class Db_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("ManytoMany_Relationship.Model.Employees", b =>
                {
                    b.Property<int>("employee_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<decimal>("experience")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("lockstatus")
                        .HasColumnType("longtext");

                    b.Property<string>("manager")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<int>("profile_id")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.Property<string>("wfm_manager")
                        .HasColumnType("longtext");

                    b.HasKey("employee_id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ManytoMany_Relationship.Model.Skillmaps", b =>
                {
                    b.Property<int>("employee_id")
                        .HasColumnType("int");

                    b.Property<int>("skillid")
                        .HasColumnType("int");

                    b.HasKey("employee_id", "skillid");

                    b.HasIndex("skillid");

                    b.ToTable("Skillmaps");
                });

            modelBuilder.Entity("ManytoMany_Relationship.Model.Skills", b =>
                {
                    b.Property<int>("skillid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.HasKey("skillid");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("ManytoMany_Relationship.Model.Skillmaps", b =>
                {
                    b.HasOne("ManytoMany_Relationship.Model.Employees", "Employees")
                        .WithMany("Skillmaps")
                        .HasForeignKey("employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManytoMany_Relationship.Model.Skills", "Skills")
                        .WithMany("Skillmaps")
                        .HasForeignKey("skillid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("ManytoMany_Relationship.Model.Employees", b =>
                {
                    b.Navigation("Skillmaps");
                });

            modelBuilder.Entity("ManytoMany_Relationship.Model.Skills", b =>
                {
                    b.Navigation("Skillmaps");
                });
#pragma warning restore 612, 618
        }
    }
}
