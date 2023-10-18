using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ms_expensify.Infraestructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Symbol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(7)),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(126)),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_currencies", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "plannings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(714)),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(826)),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plannings", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "transaction_account_types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(1909)),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2029)),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_account_types", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "transaction_amount_types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2438)),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2523)),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_amount_types", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "transaction_states",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4587)),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4707)),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_states", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "transaction_types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5078)),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5163)),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_types", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "transaction_accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TransactionAccountTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    HideBalance = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InitialAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IconLink = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColorPicked = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(1306)),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(1409)),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transaction_accounts_currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transaction_accounts_transaction_account_types_TransactionAc~",
                        column: x => x.TransactionAccountTypeId,
                        principalTable: "transaction_account_types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "transaction_categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TransactionTypeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2949)),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(3067)),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transaction_categories_transaction_types_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "transaction_types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TransactionAccountId = table.Column<int>(type: "int", nullable: false),
                    TransactionCategoryId = table.Column<int>(type: "int", nullable: false),
                    TransactionTypeId = table.Column<int>(type: "int", nullable: false),
                    TransactionStateId = table.Column<int>(type: "int", nullable: false),
                    PlanningId = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(3526)),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(3666)),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transactions_plannings_PlanningId",
                        column: x => x.PlanningId,
                        principalTable: "plannings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_transactions_transaction_accounts_TransactionAccountId",
                        column: x => x.TransactionAccountId,
                        principalTable: "transaction_accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transactions_transaction_categories_TransactionCategoryId",
                        column: x => x.TransactionCategoryId,
                        principalTable: "transaction_categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transactions_transaction_states_TransactionStateId",
                        column: x => x.TransactionStateId,
                        principalTable: "transaction_states",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transactions_transaction_types_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "transaction_types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "transaction_details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TransactionAmountTypeId = table.Column<int>(type: "int", nullable: false),
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4118)),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4244)),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction_details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transaction_details_transaction_amount_types_TransactionAmou~",
                        column: x => x.TransactionAmountTypeId,
                        principalTable: "transaction_amount_types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transaction_details_transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "transactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "currencies",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "LastModifiedAt", "LastModifiedBy", "Status", "Symbol" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5412), 1, "Peso Argentino", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5412), 1, (short)1, "ARS" },
                    { 2, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5419), 1, "Dólar Estadounidense", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5419), 1, (short)1, "USD" }
                });

            migrationBuilder.InsertData(
                table: "transaction_account_types",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "LastModifiedAt", "LastModifiedBy", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5426), 1, "Standard", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5427), 1, (short)1 },
                    { 2, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5483), 1, "Tarjeta de Crédito", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5483), 1, (short)1 }
                });

            migrationBuilder.InsertData(
                table: "transaction_amount_types",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "LastModifiedAt", "LastModifiedBy", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5393), 1, "Total", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5393), 1, (short)1 },
                    { 2, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5399), 1, "Parcial", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5399), 1, (short)1 }
                });

            migrationBuilder.InsertData(
                table: "transaction_states",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "LastModifiedAt", "LastModifiedBy", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5490), 1, "Vigente", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5490), 1, (short)1 },
                    { 2, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5495), 1, "Presupuesto", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5496), 1, (short)1 },
                    { 3, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5500), 1, "Pendiente", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5500), 1, (short)1 }
                });

            migrationBuilder.InsertData(
                table: "transaction_types",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "LastModifiedAt", "LastModifiedBy", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5334), 1, "Gasto", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5335), 1, (short)1 },
                    { 2, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5351), 1, "Ingreso", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5351), 1, (short)1 }
                });

            migrationBuilder.InsertData(
                table: "transaction_categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "LastModifiedAt", "LastModifiedBy", "Status", "TransactionTypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5361), 1, "Salud", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5361), 1, (short)1, 1 },
                    { 2, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5367), 1, "Ocio", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5367), 1, (short)1, 1 },
                    { 3, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5372), 1, "Hogar", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5372), 1, (short)1, 1 },
                    { 4, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5376), 1, "Educación", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5377), 1, (short)1, 1 },
                    { 5, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5381), 1, "Regalos", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5381), 1, (short)1, 1 },
                    { 6, new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5386), 1, "Comidas", new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5387), 1, (short)1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_transaction_accounts_CurrencyId",
                table: "transaction_accounts",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_accounts_TransactionAccountTypeId",
                table: "transaction_accounts",
                column: "TransactionAccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_categories_TransactionTypeId",
                table: "transaction_categories",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_details_TransactionAmountTypeId",
                table: "transaction_details",
                column: "TransactionAmountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_details_TransactionId",
                table: "transaction_details",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_PlanningId",
                table: "transactions",
                column: "PlanningId");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_TransactionAccountId",
                table: "transactions",
                column: "TransactionAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_TransactionCategoryId",
                table: "transactions",
                column: "TransactionCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_TransactionStateId",
                table: "transactions",
                column: "TransactionStateId");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_TransactionTypeId",
                table: "transactions",
                column: "TransactionTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transaction_details");

            migrationBuilder.DropTable(
                name: "transaction_amount_types");

            migrationBuilder.DropTable(
                name: "transactions");

            migrationBuilder.DropTable(
                name: "plannings");

            migrationBuilder.DropTable(
                name: "transaction_accounts");

            migrationBuilder.DropTable(
                name: "transaction_categories");

            migrationBuilder.DropTable(
                name: "transaction_states");

            migrationBuilder.DropTable(
                name: "currencies");

            migrationBuilder.DropTable(
                name: "transaction_account_types");

            migrationBuilder.DropTable(
                name: "transaction_types");
        }
    }
}
