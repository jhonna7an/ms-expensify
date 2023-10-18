using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ms_expensify.Infraestructure.Migrations
{
    public partial class planningTransactionAccountRelationshipAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transactions",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(519),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transactions",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(401),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transaction_types",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2508),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transaction_types",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2391),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transaction_states",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(1965),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transaction_states",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(1885),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transaction_details",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(1364),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transaction_details",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(966),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transaction_categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(9918),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transaction_categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(9790),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transaction_amount_types",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(8956),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transaction_amount_types",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(8849),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transaction_accounts",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(4457),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transaction_accounts",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(4330),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transaction_account_types",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(7273),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transaction_account_types",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(5994),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "plannings",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(2557),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "plannings",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(2419),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.AddColumn<int>(
                name: "TransactionAccountId",
                table: "plannings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "currencies",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(1610),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "currencies",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(1493),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "currencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2787), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "currencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2793), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "transaction_account_types",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2802), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "transaction_account_types",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2809), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "transaction_amount_types",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "transaction_amount_types",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "transaction_categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2687), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "transaction_categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2693), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "transaction_categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2699), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "transaction_categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2703), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "transaction_categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "transaction_categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2759), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "transaction_states",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2815), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "transaction_states",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2821), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "transaction_states",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2825), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "transaction_types",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2664), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "transaction_types",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2677), new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.CreateIndex(
                name: "IX_plannings_TransactionAccountId",
                table: "plannings",
                column: "TransactionAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_plannings_transaction_accounts_TransactionAccountId",
                table: "plannings",
                column: "TransactionAccountId",
                principalTable: "transaction_accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_plannings_transaction_accounts_TransactionAccountId",
                table: "plannings");

            migrationBuilder.DropIndex(
                name: "IX_plannings_TransactionAccountId",
                table: "plannings");

            migrationBuilder.DropColumn(
                name: "TransactionAccountId",
                table: "plannings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transactions",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(3666),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transactions",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(3526),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transaction_types",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5163),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transaction_types",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5078),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transaction_states",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4707),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transaction_states",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4587),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transaction_details",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4244),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transaction_details",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(4118),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 591, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transaction_categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(3067),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transaction_categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2949),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transaction_amount_types",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2523),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transaction_amount_types",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2438),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transaction_accounts",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(1409),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transaction_accounts",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(1306),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "transaction_account_types",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(2029),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "transaction_account_types",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(1909),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "plannings",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(826),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "plannings",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(714),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "currencies",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(126),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "currencies",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(7),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 10, 18, 14, 5, 30, 590, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "currencies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5412), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "currencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5419), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "transaction_account_types",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5426), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "transaction_account_types",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5483), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "transaction_amount_types",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5393), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "transaction_amount_types",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5399), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "transaction_categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5361), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "transaction_categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5367), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "transaction_categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5372), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "transaction_categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5376), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "transaction_categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5381), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "transaction_categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5386), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "transaction_states",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5490), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "transaction_states",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5495), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "transaction_states",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5500), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "transaction_types",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5334), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "transaction_types",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5351), new DateTime(2023, 10, 18, 13, 56, 25, 282, DateTimeKind.Local).AddTicks(5351) });
        }
    }
}
