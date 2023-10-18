﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ms_expensify.Infraestructure.Context;

#nullable disable

namespace ms_expensify.Infraestructure.Migrations
{
    [DbContext(typeof(ExpensifyContext))]
    [Migration("20231018165625_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ms_expensify.Domain.Entities.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(7));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(126));

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<short>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("currencies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5412),
                            CreatedBy = 1,
                            Description = "Peso Argentino",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5412),
                            LastModifiedBy = 1,
                            Status = (short)1,
                            Symbol = "ARS"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5419),
                            CreatedBy = 1,
                            Description = "Dólar Estadounidense",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5419),
                            LastModifiedBy = 1,
                            Status = (short)1,
                            Symbol = "USD"
                        });
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.Planning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(714));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(826));

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<short>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.HasKey("Id");

                    b.ToTable("plannings", (string)null);
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(3526));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(3666));

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<int?>("PlanningId")
                        .HasColumnType("int");

                    b.Property<short>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("TransactionAccountId")
                        .HasColumnType("int");

                    b.Property<int>("TransactionCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("TransactionStateId")
                        .HasColumnType("int");

                    b.Property<int>("TransactionTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlanningId");

                    b.HasIndex("TransactionAccountId");

                    b.HasIndex("TransactionCategoryId");

                    b.HasIndex("TransactionStateId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("transactions", (string)null);
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ColorPicked")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(1306));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("HideBalance")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("IconLink")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("InitialAmount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(1409));

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<short>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.Property<int>("TransactionAccountTypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("TransactionAccountTypeId");

                    b.ToTable("transaction_accounts", (string)null);
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionAccountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(1909));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2029));

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<short>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.HasKey("Id");

                    b.ToTable("transaction_account_types", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5426),
                            CreatedBy = 1,
                            Description = "Standard",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5427),
                            LastModifiedBy = 1,
                            Status = (short)1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5483),
                            CreatedBy = 1,
                            Description = "Tarjeta de Crédito",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5483),
                            LastModifiedBy = 1,
                            Status = (short)1
                        });
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionAmountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2438));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2523));

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<short>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.HasKey("Id");

                    b.ToTable("transaction_amount_types", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5393),
                            CreatedBy = 1,
                            Description = "Total",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5393),
                            LastModifiedBy = 1,
                            Status = (short)1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5399),
                            CreatedBy = 1,
                            Description = "Parcial",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5399),
                            LastModifiedBy = 1,
                            Status = (short)1
                        });
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2949));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(3067));

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<short>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.Property<int>("TransactionTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("transaction_categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5361),
                            CreatedBy = 1,
                            Description = "Salud",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5361),
                            LastModifiedBy = 1,
                            Status = (short)1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5367),
                            CreatedBy = 1,
                            Description = "Ocio",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5367),
                            LastModifiedBy = 1,
                            Status = (short)1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5372),
                            CreatedBy = 1,
                            Description = "Hogar",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5372),
                            LastModifiedBy = 1,
                            Status = (short)1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5376),
                            CreatedBy = 1,
                            Description = "Educación",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5377),
                            LastModifiedBy = 1,
                            Status = (short)1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5381),
                            CreatedBy = 1,
                            Description = "Regalos",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5381),
                            LastModifiedBy = 1,
                            Status = (short)1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5386),
                            CreatedBy = 1,
                            Description = "Comidas",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5387),
                            LastModifiedBy = 1,
                            Status = (short)1,
                            TransactionTypeId = 1
                        });
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4118));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4244));

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<short>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.Property<int>("TransactionAmountTypeId")
                        .HasColumnType("int");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TransactionAmountTypeId");

                    b.HasIndex("TransactionId");

                    b.ToTable("transaction_details", (string)null);
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4587));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4707));

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<short>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.HasKey("Id");

                    b.ToTable("transaction_states", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5490),
                            CreatedBy = 1,
                            Description = "Vigente",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5490),
                            LastModifiedBy = 1,
                            Status = (short)1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5495),
                            CreatedBy = 1,
                            Description = "Presupuesto",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5496),
                            LastModifiedBy = 1,
                            Status = (short)1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5500),
                            CreatedBy = 1,
                            Description = "Pendiente",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5500),
                            LastModifiedBy = 1,
                            Status = (short)1
                        });
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5078));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5163));

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<short>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.HasKey("Id");

                    b.ToTable("transaction_types", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5334),
                            CreatedBy = 1,
                            Description = "Gasto",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5335),
                            LastModifiedBy = 1,
                            Status = (short)1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5351),
                            CreatedBy = 1,
                            Description = "Ingreso",
                            LastModifiedAt = new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5351),
                            LastModifiedBy = 1,
                            Status = (short)1
                        });
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.Transaction", b =>
                {
                    b.HasOne("ms_expensify.Domain.Entities.Planning", "Planning")
                        .WithMany("Transactions")
                        .HasForeignKey("PlanningId");

                    b.HasOne("ms_expensify.Domain.Entities.TransactionAccount", "TransactionAccount")
                        .WithMany("Transactions")
                        .HasForeignKey("TransactionAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ms_expensify.Domain.Entities.TransactionCategory", "TransactionCategory")
                        .WithMany("Transactions")
                        .HasForeignKey("TransactionCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ms_expensify.Domain.Entities.TransactionState", "TransactionState")
                        .WithMany("Transactions")
                        .HasForeignKey("TransactionStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ms_expensify.Domain.Entities.TransactionType", "TransactionType")
                        .WithMany("Transactions")
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Planning");

                    b.Navigation("TransactionAccount");

                    b.Navigation("TransactionCategory");

                    b.Navigation("TransactionState");

                    b.Navigation("TransactionType");
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionAccount", b =>
                {
                    b.HasOne("ms_expensify.Domain.Entities.Currency", "Currency")
                        .WithMany("Accounts")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ms_expensify.Domain.Entities.TransactionAccountType", "TransactionAccountType")
                        .WithMany("Accounts")
                        .HasForeignKey("TransactionAccountTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Currency");

                    b.Navigation("TransactionAccountType");
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionCategory", b =>
                {
                    b.HasOne("ms_expensify.Domain.Entities.TransactionType", "TransactionType")
                        .WithMany("TransactionCategories")
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TransactionType");
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionDetail", b =>
                {
                    b.HasOne("ms_expensify.Domain.Entities.TransactionAmountType", "TransactionAmountType")
                        .WithMany("TransactionDetails")
                        .HasForeignKey("TransactionAmountTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ms_expensify.Domain.Entities.Transaction", "Transaction")
                        .WithMany("TransactionDetails")
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Transaction");

                    b.Navigation("TransactionAmountType");
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.Currency", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.Planning", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.Transaction", b =>
                {
                    b.Navigation("TransactionDetails");
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionAccount", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionAccountType", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionAmountType", b =>
                {
                    b.Navigation("TransactionDetails");
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionCategory", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionState", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.TransactionType", b =>
                {
                    b.Navigation("TransactionCategories");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
