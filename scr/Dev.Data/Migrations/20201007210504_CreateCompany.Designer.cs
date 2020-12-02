﻿// <auto-generated />
using System;
using Dev.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dev.Data.Migrations
{
    [DbContext(typeof(MeuDbContext))]
    [Migration("20201007210504_CreateCompany")]
    partial class CreateCompany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dev.Business.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Dev.Business.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IdBranch")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("IdCompany")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("NameBranch")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NameCompany")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Dev.Business.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<Guid?>("SegmentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SegmentId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Dev.Business.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Dev.Business.Models.Prospect", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AutomaticPhase")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("AutomaticStatus")
                        .HasColumnType("varchar(2)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Competition")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Decision")
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("DeliveryJob")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ExpectedSale")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FirstBriefing")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FirstProposal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FirstSale")
                        .HasColumnType("datetime2");

                    b.Property<string>("Interlocutor")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("International")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("NameCompetitors")
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("Opening")
                        .HasColumnType("datetime2");

                    b.Property<int>("PhaseProspect")
                        .HasColumnType("int");

                    b.Property<string>("ProActive")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<int?>("Reason")
                        .HasColumnType("int");

                    b.Property<string>("ReasonText")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<int?>("Temperature")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<double?>("ValueApproved")
                        .HasColumnType("float");

                    b.Property<double?>("ValueEstimated")
                        .HasColumnType("float");

                    b.Property<double?>("ValueProposal")
                        .HasColumnType("float");

                    b.Property<double?>("ValueSold")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Prospects");
                });

            modelBuilder.Entity("Dev.Business.Models.ProspectEmployee", b =>
                {
                    b.Property<Guid>("ProspectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProspectId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("ProspectEmployees");
                });

            modelBuilder.Entity("Dev.Business.Models.Segment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Segments");
                });

            modelBuilder.Entity("Dev.Business.Models.Customer", b =>
                {
                    b.HasOne("Dev.Business.Models.Segment", "Segment")
                        .WithMany("Customers")
                        .HasForeignKey("SegmentId");
                });

            modelBuilder.Entity("Dev.Business.Models.Prospect", b =>
                {
                    b.HasOne("Dev.Business.Models.Category", "Category")
                        .WithMany("Prospects")
                        .HasForeignKey("CategoryId")
                        .IsRequired();

                    b.HasOne("Dev.Business.Models.Company", "Company")
                        .WithMany("Prospects")
                        .HasForeignKey("CompanyId")
                        .IsRequired();

                    b.HasOne("Dev.Business.Models.Customer", "Customer")
                        .WithMany("Prospects")
                        .HasForeignKey("CustomerId")
                        .IsRequired();

                    b.HasOne("Dev.Business.Models.Employee", "Employee")
                        .WithMany("Prospects")
                        .HasForeignKey("EmployeeId")
                        .IsRequired();
                });

            modelBuilder.Entity("Dev.Business.Models.ProspectEmployee", b =>
                {
                    b.HasOne("Dev.Business.Models.Employee", "Employee")
                        .WithMany("ProspectEmployees")
                        .HasForeignKey("EmployeeId")
                        .IsRequired();

                    b.HasOne("Dev.Business.Models.Prospect", "Prospect")
                        .WithMany("ProspectEmployees")
                        .HasForeignKey("ProspectId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
