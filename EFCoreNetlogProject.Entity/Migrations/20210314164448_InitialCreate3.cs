using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetlogProject.Entity.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActionType_User_modifiedBy",
                table: "ActionType");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_User_modifiedBy",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceHistory_User_modifiedBy",
                table: "MaintenanceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PictureGroup_User_modifiedBy",
                table: "PictureGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_Status_User_modifiedBy",
                table: "Status");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_modifiedBy",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_modifiedBy",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleType_User_modifiedBy",
                table: "VehicleType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "VehicleType",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "VehicleType",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "Vehicle",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "Vehicle",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "User",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "User",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "Status",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "Status",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "PictureGroup",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "PictureGroup",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "MaintenanceHistory",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "MaintenanceHistory",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "Maintenance",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "Maintenance",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "ActionType",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "ActionType",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_ActionType_User_modifiedBy",
                table: "ActionType",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_User_modifiedBy",
                table: "Maintenance",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceHistory_User_modifiedBy",
                table: "MaintenanceHistory",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PictureGroup_User_modifiedBy",
                table: "PictureGroup",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Status_User_modifiedBy",
                table: "Status",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_modifiedBy",
                table: "User",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_User_modifiedBy",
                table: "Vehicle",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleType_User_modifiedBy",
                table: "VehicleType",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActionType_User_modifiedBy",
                table: "ActionType");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_User_modifiedBy",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceHistory_User_modifiedBy",
                table: "MaintenanceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PictureGroup_User_modifiedBy",
                table: "PictureGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_Status_User_modifiedBy",
                table: "Status");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_modifiedBy",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_modifiedBy",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleType_User_modifiedBy",
                table: "VehicleType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "VehicleType",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "VehicleType",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "Vehicle",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "Vehicle",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "User",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "Status",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "Status",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "PictureGroup",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "PictureGroup",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "MaintenanceHistory",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "MaintenanceHistory",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "Maintenance",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "Maintenance",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "modifyDate",
                table: "ActionType",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modifiedBy",
                table: "ActionType",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ActionType_User_modifiedBy",
                table: "ActionType",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_User_modifiedBy",
                table: "Maintenance",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceHistory_User_modifiedBy",
                table: "MaintenanceHistory",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PictureGroup_User_modifiedBy",
                table: "PictureGroup",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Status_User_modifiedBy",
                table: "Status",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_modifiedBy",
                table: "User",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_User_modifiedBy",
                table: "Vehicle",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleType_User_modifiedBy",
                table: "VehicleType",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
