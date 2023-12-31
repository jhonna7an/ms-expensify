﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ms_expensify.Infraestructure.Context;

#nullable disable

namespace ms_expensify.Infraestructure.Migrations
{
    [DbContext(typeof(ExpensifyContext))]
    partial class ExpensifyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(1493));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(1610));

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
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2787),
                            CreatedBy = 1,
                            Description = "Peso Argentino",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2788),
                            LastModifiedBy = 1,
                            Status = (short)1,
                            Symbol = "ARS"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2793),
                            CreatedBy = 1,
                            Description = "Dólar Estadounidense",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2794),
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
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(2419));

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
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(2557));

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<short>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.Property<int>("TransactionAccountId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TransactionAccountId");

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
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(401));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(519));

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
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(4330));

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
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(4457));

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
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(5994));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(7273));

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
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2802),
                            CreatedBy = 1,
                            Description = "Standard",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2802),
                            LastModifiedBy = 1,
                            Status = (short)1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2809),
                            CreatedBy = 1,
                            Description = "Tarjeta de Crédito",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2809),
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
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(8849));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(8956));

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
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2770),
                            CreatedBy = 1,
                            Description = "Total",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2770),
                            LastModifiedBy = 1,
                            Status = (short)1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2776),
                            CreatedBy = 1,
                            Description = "Parcial",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2776),
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
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(9790));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(9918));

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
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2687),
                            CreatedBy = 1,
                            Description = "Salud",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2687),
                            LastModifiedBy = 1,
                            Status = (short)1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2693),
                            CreatedBy = 1,
                            Description = "Ocio",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2694),
                            LastModifiedBy = 1,
                            Status = (short)1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2699),
                            CreatedBy = 1,
                            Description = "Hogar",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2699),
                            LastModifiedBy = 1,
                            Status = (short)1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2703),
                            CreatedBy = 1,
                            Description = "Educación",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2704),
                            LastModifiedBy = 1,
                            Status = (short)1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2708),
                            CreatedBy = 1,
                            Description = "Regalos",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2708),
                            LastModifiedBy = 1,
                            Status = (short)1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2759),
                            CreatedBy = 1,
                            Description = "Comidas",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2760),
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
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(966));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(1364));

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
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(1885));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(1965));

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
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2815),
                            CreatedBy = 1,
                            Description = "Vigente",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2815),
                            LastModifiedBy = 1,
                            Status = (short)1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2821),
                            CreatedBy = 1,
                            Description = "Presupuesto",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2821),
                            LastModifiedBy = 1,
                            Status = (short)1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2825),
                            CreatedBy = 1,
                            Description = "Pendiente",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2826),
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
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2391));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("LastModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2508));

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
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2664),
                            CreatedBy = 1,
                            Description = "Gasto",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2664),
                            LastModifiedBy = 1,
                            Status = (short)1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2677),
                            CreatedBy = 1,
                            Description = "Ingreso",
                            LastModifiedAt = new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2678),
                            LastModifiedBy = 1,
                            Status = (short)1
                        });
                });

            modelBuilder.Entity("ms_expensify.Domain.Entities.Planning", b =>
                {
                    b.HasOne("ms_expensify.Domain.Entities.TransactionAccount", "TransactionAccount")
                        .WithMany("Plannings")
                        .HasForeignKey("TransactionAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TransactionAccount");
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
                    b.Navigation("Plannings");

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
