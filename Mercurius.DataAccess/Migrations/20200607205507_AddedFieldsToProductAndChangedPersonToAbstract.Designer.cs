﻿// <auto-generated />
using System;
using Mercurius.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mercurius.DataAccess.Migrations
{
    [DbContext(typeof(MercuriusContext))]
    [Migration("20200607205507_AddedFieldsToProductAndChangedPersonToAbstract")]
    partial class AddedFieldsToProductAndChangedPersonToAbstract
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mercurius.Entities.ContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int?>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("VendorId");

                    b.ToTable("ContactInfoList");
                });

            modelBuilder.Entity("Mercurius.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Mercurius.Entities.OrderProduct", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("Mercurius.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("Mercurius.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateActivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SourceVendorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SourceVendorId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Mercurius.Entities.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VendorEffectiveDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("Mercurius.Entities.Customer", b =>
                {
                    b.HasBaseType("Mercurius.Entities.Person");

                    b.Property<bool>("ClubMember")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ClubMemberCancelationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ClubMemberEffectiveDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FirstActivityDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Customer");
                });

            modelBuilder.Entity("Mercurius.Entities.Employee", b =>
                {
                    b.HasBaseType("Mercurius.Entities.Person");

                    b.Property<string>("EmployeeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OnboardDate")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("Mercurius.Entities.ContactInfo", b =>
                {
                    b.HasOne("Mercurius.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("Mercurius.Entities.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId");
                });

            modelBuilder.Entity("Mercurius.Entities.Order", b =>
                {
                    b.HasOne("Mercurius.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mercurius.Entities.OrderProduct", b =>
                {
                    b.HasOne("Mercurius.Entities.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mercurius.Entities.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mercurius.Entities.Product", b =>
                {
                    b.HasOne("Mercurius.Entities.Vendor", "Vendor")
                        .WithMany("Products")
                        .HasForeignKey("SourceVendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
