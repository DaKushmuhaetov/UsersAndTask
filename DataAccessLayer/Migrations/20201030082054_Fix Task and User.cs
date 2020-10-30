using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class FixTaskandUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaskUsers",
                columns: new[] { "Id", "DateCreate", "DateLastEdit", "Description", "DirectorId", "Name", "PerformerId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 10, 30, 13, 20, 53, 740, DateTimeKind.Local).AddTicks(9822), new DateTime(2020, 10, 30, 13, 20, 53, 740, DateTimeKind.Local).AddTicks(9822), "test1", 1, "test1", 2, 1 },
                    { 24, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4418), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4418), "test24", 1, "test24", 2, 0 },
                    { 23, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4414), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4414), "test23", 5, "test23", 3, 0 },
                    { 22, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4410), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4410), "test22", 5, "test22", 4, 0 },
                    { 21, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4406), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4406), "test21", 5, "test21", 1, 0 },
                    { 20, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4402), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4402), "test20", 5, "test20", 2, 0 },
                    { 19, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4398), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4398), "test19", 4, "test19", 2, 0 },
                    { 18, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4394), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4394), "test18", 3, "test18", 1, 0 },
                    { 17, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4390), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4390), "test17", 3, "test17", 2, 0 },
                    { 16, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4386), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4386), "test16", 3, "test16", 1, 0 },
                    { 14, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4378), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4378), "test14", 2, "test14", 5, 0 },
                    { 13, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4374), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4374), "test13", 1, "test13", 2, 0 },
                    { 15, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4382), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4382), "test15", 3, "test15", 4, 0 },
                    { 11, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4371), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4371), "test11", 4, "test11", 2, 0 },
                    { 10, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4367), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4367), "test10", 2, "test10", 3, 0 },
                    { 9, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4359), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4359), "test9", 1, "test9", 4, 1 },
                    { 8, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4355), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4355), "test8", 4, "test8", 2, 1 },
                    { 7, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4351), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4351), "test7", 1, "test7", 3, 2 },
                    { 6, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4347), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4347), "test6", 1, "test6", 2, 1 },
                    { 5, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4331), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4331), "test5", 2, "test5", 1, 1 },
                    { 4, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4327), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4327), "test4", 1, "test4", 5, 4 },
                    { 3, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4319), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4319), "test3", 1, "test3", 4, 1 },
                    { 2, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4086), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4086), "test2", 1, "test2", 3, 1 },
                    { 12, new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4374), new DateTime(2020, 10, 30, 13, 20, 53, 744, DateTimeKind.Local).AddTicks(4374), "test12", 5, "test12", 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreate", "DateLastEdit", "FirstName", "MiddleName", "Status" },
                values: new object[,]
                {
                    { 4, new DateTime(2020, 10, 30, 13, 20, 53, 748, DateTimeKind.Local).AddTicks(1551), new DateTime(2020, 10, 30, 13, 20, 53, 748, DateTimeKind.Local).AddTicks(1555), "test4", "test4", 2 },
                    { 1, new DateTime(2020, 10, 30, 13, 20, 53, 747, DateTimeKind.Local).AddTicks(7469), new DateTime(2020, 10, 30, 13, 20, 53, 747, DateTimeKind.Local).AddTicks(7473), "test1", "test1", 0 },
                    { 2, new DateTime(2020, 10, 30, 13, 20, 53, 748, DateTimeKind.Local).AddTicks(1448), new DateTime(2020, 10, 30, 13, 20, 53, 748, DateTimeKind.Local).AddTicks(1456), "test2", "test2", 0 },
                    { 3, new DateTime(2020, 10, 30, 13, 20, 53, 748, DateTimeKind.Local).AddTicks(1547), new DateTime(2020, 10, 30, 13, 20, 53, 748, DateTimeKind.Local).AddTicks(1547), "test3", "test3", 1 },
                    { 5, new DateTime(2020, 10, 30, 13, 20, 53, 748, DateTimeKind.Local).AddTicks(1559), new DateTime(2020, 10, 30, 13, 20, 53, 748, DateTimeKind.Local).AddTicks(1559), "test5", "test5", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TaskUsers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
