using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetlogProject.Entity.Migrations
{
    public partial class nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_PictureGroup_pictureGroupId",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_Status_statusId",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_User_responsibleUserId",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_User_userId",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_Vehicle_vehicleId",
                table: "Maintenance");

            migrationBuilder.AlterColumn<int>(
                name: "vehicleId",
                table: "Maintenance",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "Maintenance",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "statusId",
                table: "Maintenance",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "responsibleUserId",
                table: "Maintenance",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "pictureGroupId",
                table: "Maintenance",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "expectedTimeToFix",
                table: "Maintenance",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_PictureGroup_pictureGroupId",
                table: "Maintenance",
                column: "pictureGroupId",
                principalTable: "PictureGroup",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_Status_statusId",
                table: "Maintenance",
                column: "statusId",
                principalTable: "Status",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_User_responsibleUserId",
                table: "Maintenance",
                column: "responsibleUserId",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_User_userId",
                table: "Maintenance",
                column: "userId",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_Vehicle_vehicleId",
                table: "Maintenance",
                column: "vehicleId",
                principalTable: "Vehicle",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_PictureGroup_pictureGroupId",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_Status_statusId",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_User_responsibleUserId",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_User_userId",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_Vehicle_vehicleId",
                table: "Maintenance");

            migrationBuilder.AlterColumn<int>(
                name: "vehicleId",
                table: "Maintenance",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "Maintenance",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "statusId",
                table: "Maintenance",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "responsibleUserId",
                table: "Maintenance",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "pictureGroupId",
                table: "Maintenance",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "expectedTimeToFix",
                table: "Maintenance",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_PictureGroup_pictureGroupId",
                table: "Maintenance",
                column: "pictureGroupId",
                principalTable: "PictureGroup",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_Status_statusId",
                table: "Maintenance",
                column: "statusId",
                principalTable: "Status",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_User_responsibleUserId",
                table: "Maintenance",
                column: "responsibleUserId",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_User_userId",
                table: "Maintenance",
                column: "userId",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_Vehicle_vehicleId",
                table: "Maintenance",
                column: "vehicleId",
                principalTable: "Vehicle",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
