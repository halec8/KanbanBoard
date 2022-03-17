﻿// <auto-generated />
using System;
using Kanban.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kanban.Migrations
{
    [DbContext(typeof(KanbanContext))]
    [Migration("20220317195927_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kanban.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "work",
                            Name = "Work"
                        },
                        new
                        {
                            CategoryId = "home",
                            Name = "Home"
                        },
                        new
                        {
                            CategoryId = "ex",
                            Name = "Exercise"
                        },
                        new
                        {
                            CategoryId = "shop",
                            Name = "Shopping"
                        },
                        new
                        {
                            CategoryId = "call",
                            Name = "Contact"
                        });
                });

            modelBuilder.Entity("Kanban.Models.KanbanBoard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("PointId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SprintNumberId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StatusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PointId");

                    b.HasIndex("SprintNumberId");

                    b.HasIndex("StatusId");

                    b.ToTable("Kanbans");
                });

            modelBuilder.Entity("Kanban.Models.Point", b =>
                {
                    b.Property<string>("PointId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PointAmount")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PointId");

                    b.ToTable("Points");

                    b.HasData(
                        new
                        {
                            PointId = "first",
                            PointAmount = "25"
                        },
                        new
                        {
                            PointId = "second",
                            PointAmount = "50"
                        },
                        new
                        {
                            PointId = "third",
                            PointAmount = "75"
                        },
                        new
                        {
                            PointId = "fourth",
                            PointAmount = "100"
                        });
                });

            modelBuilder.Entity("Kanban.Models.SprintNumber", b =>
                {
                    b.Property<string>("SprintNumberId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SprintNumberId");

                    b.ToTable("SprintNumber");

                    b.HasData(
                        new
                        {
                            SprintNumberId = "weekone",
                            Name = "Sprint 1"
                        },
                        new
                        {
                            SprintNumberId = "weektwo",
                            Name = "Sprint 2"
                        },
                        new
                        {
                            SprintNumberId = "weekthree",
                            Name = "Sprint 3"
                        },
                        new
                        {
                            SprintNumberId = "weekfour",
                            Name = "Sprint 4"
                        },
                        new
                        {
                            SprintNumberId = "weekfive",
                            Name = "Sprint 5"
                        },
                        new
                        {
                            SprintNumberId = "weeksix",
                            Name = "Sprint 6"
                        },
                        new
                        {
                            SprintNumberId = "weekseven",
                            Name = "Sprint 7"
                        },
                        new
                        {
                            SprintNumberId = "weekeight",
                            Name = "Sprint 8"
                        },
                        new
                        {
                            SprintNumberId = "weeknine",
                            Name = "Sprint 9"
                        },
                        new
                        {
                            SprintNumberId = "weekten",
                            Name = "Sprint 10"
                        },
                        new
                        {
                            SprintNumberId = "weekeleven",
                            Name = "Sprint 11"
                        },
                        new
                        {
                            SprintNumberId = "weektwelve",
                            Name = "Sprint 12"
                        },
                        new
                        {
                            SprintNumberId = "weekthirteen",
                            Name = "Sprint 13"
                        },
                        new
                        {
                            SprintNumberId = "weekfourteen",
                            Name = "Sprint 14"
                        },
                        new
                        {
                            SprintNumberId = "weekfifteen",
                            Name = "Sprint 15"
                        },
                        new
                        {
                            SprintNumberId = "weeksixteen",
                            Name = "Sprint 16"
                        },
                        new
                        {
                            SprintNumberId = "weekseventeen",
                            Name = "Sprint 17"
                        },
                        new
                        {
                            SprintNumberId = "weekeighteen",
                            Name = "Sprint 18"
                        },
                        new
                        {
                            SprintNumberId = "weeknineteen",
                            Name = "Sprint 19"
                        },
                        new
                        {
                            SprintNumberId = "weektwenty",
                            Name = "Sprint 20"
                        },
                        new
                        {
                            SprintNumberId = "weektwentyone",
                            Name = "Sprint 21"
                        },
                        new
                        {
                            SprintNumberId = "weektwentytwo",
                            Name = "Sprint 22"
                        },
                        new
                        {
                            SprintNumberId = "weektwentythree",
                            Name = "Sprint 23"
                        },
                        new
                        {
                            SprintNumberId = "weektwentyfour",
                            Name = "Sprint 24"
                        },
                        new
                        {
                            SprintNumberId = "weektwentyfive",
                            Name = "Sprint 25"
                        },
                        new
                        {
                            SprintNumberId = "weektwentysix",
                            Name = "Sprint 26"
                        },
                        new
                        {
                            SprintNumberId = "weektwentyseven",
                            Name = "Sprint 27"
                        },
                        new
                        {
                            SprintNumberId = "weektwentyeight",
                            Name = "Sprint 28"
                        },
                        new
                        {
                            SprintNumberId = "weektwentynine",
                            Name = "Sprint 29"
                        },
                        new
                        {
                            SprintNumberId = "weekthirty",
                            Name = "Sprint 30"
                        },
                        new
                        {
                            SprintNumberId = "weekthirtyone",
                            Name = "Sprint 31"
                        },
                        new
                        {
                            SprintNumberId = "weekthirtytwo",
                            Name = "Sprint 32"
                        },
                        new
                        {
                            SprintNumberId = "weekthirtythree",
                            Name = "Sprint 33"
                        },
                        new
                        {
                            SprintNumberId = "weekthirtyfour",
                            Name = "Sprint 34"
                        },
                        new
                        {
                            SprintNumberId = "weekthirtyfive",
                            Name = "Sprint 35"
                        },
                        new
                        {
                            SprintNumberId = "weekthirtysix",
                            Name = "Sprint 36"
                        },
                        new
                        {
                            SprintNumberId = "weekthirtyseven",
                            Name = "Sprint 37"
                        },
                        new
                        {
                            SprintNumberId = "weekthirtyeight",
                            Name = "Sprint 38"
                        },
                        new
                        {
                            SprintNumberId = "weekthirtynine",
                            Name = "Sprint 39"
                        },
                        new
                        {
                            SprintNumberId = "weekforty",
                            Name = "Sprint 40"
                        },
                        new
                        {
                            SprintNumberId = "weekfortyone",
                            Name = "Sprint 41"
                        },
                        new
                        {
                            SprintNumberId = "weekfortytwo",
                            Name = "Sprint 42"
                        },
                        new
                        {
                            SprintNumberId = "weekfortythree",
                            Name = "Sprint 43"
                        },
                        new
                        {
                            SprintNumberId = "weekfortyfour",
                            Name = "Sprint 44"
                        },
                        new
                        {
                            SprintNumberId = "weekfortyfive",
                            Name = "Sprint 45"
                        },
                        new
                        {
                            SprintNumberId = "weekfortysix",
                            Name = "Sprint 46"
                        },
                        new
                        {
                            SprintNumberId = "weekfortyseven",
                            Name = "Sprint 47"
                        },
                        new
                        {
                            SprintNumberId = "weekfortyeight",
                            Name = "Sprint 48"
                        },
                        new
                        {
                            SprintNumberId = "weekfortynine",
                            Name = "Sprint 49"
                        },
                        new
                        {
                            SprintNumberId = "weekfifty",
                            Name = "Sprint 50"
                        },
                        new
                        {
                            SprintNumberId = "weekfiftyone",
                            Name = "Sprint 51"
                        },
                        new
                        {
                            SprintNumberId = "weekfiftytwo",
                            Name = "Sprint 52"
                        });
                });

            modelBuilder.Entity("Kanban.Models.Status", b =>
                {
                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusId = "todo",
                            Name = "To do"
                        },
                        new
                        {
                            StatusId = "inprogress",
                            Name = "In Progress"
                        },
                        new
                        {
                            StatusId = "qa",
                            Name = "Quality Assurance (QA)"
                        },
                        new
                        {
                            StatusId = "done",
                            Name = "Done"
                        });
                });

            modelBuilder.Entity("Kanban.Models.KanbanBoard", b =>
                {
                    b.HasOne("Kanban.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kanban.Models.Point", "Points")
                        .WithMany()
                        .HasForeignKey("PointId");

                    b.HasOne("Kanban.Models.SprintNumber", "SprintNumber")
                        .WithMany()
                        .HasForeignKey("SprintNumberId");

                    b.HasOne("Kanban.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}