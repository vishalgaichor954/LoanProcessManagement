﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanProcessManagement.Persistence.Migrations
{
    public partial class initial_15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LpmLeadITRDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    lead_Id = table.Column<string>(nullable: true),
                    FormNo = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ApplicantDetailId = table.Column<long>(nullable: false),
                    ApplicantType = table.Column<int>(nullable: false),
                    IsConsent = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsSuccess = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LpmLeadITRDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LpmLeadITRDetails_LpmLeadApplicantsDetails_ApplicantDetailId",
                        column: x => x.ApplicantDetailId,
                        principalTable: "LpmLeadApplicantsDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "Date",
                value: new DateTime(2022, 10, 10, 19, 18, 26, 788, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "Date",
                value: new DateTime(2022, 9, 10, 19, 18, 26, 788, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "Date",
                value: new DateTime(2022, 4, 10, 19, 18, 26, 788, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "Date",
                value: new DateTime(2022, 8, 10, 19, 18, 26, 788, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "Date",
                value: new DateTime(2022, 4, 10, 19, 18, 26, 788, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2022, 6, 10, 19, 18, 26, 787, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2021, 12, 10, 19, 18, 26, 788, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2021, 12, 10, 19, 18, 26, 788, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2021, 12, 10, 19, 18, 26, 788, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2021, 12, 10, 19, 18, 26, 788, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2021, 12, 10, 19, 18, 26, 788, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2021, 12, 10, 19, 18, 26, 788, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2021, 12, 10, 19, 18, 26, 788, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.CreateIndex(
                name: "IX_LpmLeadITRDetails_ApplicantDetailId",
                table: "LpmLeadITRDetails",
                column: "ApplicantDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LpmLeadITRDetails");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "Date",
                value: new DateTime(2022, 9, 30, 14, 40, 31, 105, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "Date",
                value: new DateTime(2022, 8, 30, 14, 40, 31, 104, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "Date",
                value: new DateTime(2022, 3, 30, 14, 40, 31, 105, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "Date",
                value: new DateTime(2022, 7, 30, 14, 40, 31, 105, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "Date",
                value: new DateTime(2022, 3, 30, 14, 40, 31, 105, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2022, 5, 30, 14, 40, 31, 103, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2021, 11, 30, 14, 40, 31, 105, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2021, 11, 30, 14, 40, 31, 105, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2021, 11, 30, 14, 40, 31, 105, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2021, 11, 30, 14, 40, 31, 105, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2021, 11, 30, 14, 40, 31, 105, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2021, 11, 30, 14, 40, 31, 105, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2021, 11, 30, 14, 40, 31, 105, DateTimeKind.Local).AddTicks(3892));
        }
    }
}
