using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetlogProject.Entity.Migrations
{
    public partial class nullable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActionType_User_createdBy",
                table: "ActionType");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_User_createdBy",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceHistory_ActionType_actionTypeId",
                table: "MaintenanceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceHistory_Maintenance_maintenanceId",
                table: "MaintenanceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceHistory_User_createdBy",
                table: "MaintenanceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PictureGroup_User_createdBy",
                table: "PictureGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_Status_User_createdBy",
                table: "Status");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_createdBy",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_createdBy",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_userId",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleType_vehicleTypeId",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleType_User_createdBy",
                table: "VehicleType");

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "VehicleType",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "VehicleType",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "vehicleTypeId",
                table: "Vehicle",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "Vehicle",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "Vehicle",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "Vehicle",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "User",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "User",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "Status",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "Status",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "PictureGroup",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "PictureGroup",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "maintenanceId",
                table: "MaintenanceHistory",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "MaintenanceHistory",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "MaintenanceHistory",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "actionTypeId",
                table: "MaintenanceHistory",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "Maintenance",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "Maintenance",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "ActionType",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "ActionType",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddForeignKey(
                name: "FK_ActionType_User_createdBy",
                table: "ActionType",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_User_createdBy",
                table: "Maintenance",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceHistory_ActionType_actionTypeId",
                table: "MaintenanceHistory",
                column: "actionTypeId",
                principalTable: "ActionType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceHistory_Maintenance_maintenanceId",
                table: "MaintenanceHistory",
                column: "maintenanceId",
                principalTable: "Maintenance",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceHistory_User_createdBy",
                table: "MaintenanceHistory",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PictureGroup_User_createdBy",
                table: "PictureGroup",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Status_User_createdBy",
                table: "Status",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_createdBy",
                table: "User",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_User_createdBy",
                table: "Vehicle",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_User_userId",
                table: "Vehicle",
                column: "userId",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleType_vehicleTypeId",
                table: "Vehicle",
                column: "vehicleTypeId",
                principalTable: "VehicleType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleType_User_createdBy",
                table: "VehicleType",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActionType_User_createdBy",
                table: "ActionType");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_User_createdBy",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceHistory_ActionType_actionTypeId",
                table: "MaintenanceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceHistory_Maintenance_maintenanceId",
                table: "MaintenanceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceHistory_User_createdBy",
                table: "MaintenanceHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PictureGroup_User_createdBy",
                table: "PictureGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_Status_User_createdBy",
                table: "Status");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_createdBy",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_createdBy",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_userId",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleType_vehicleTypeId",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleType_User_createdBy",
                table: "VehicleType");

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "VehicleType",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "VehicleType",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "vehicleTypeId",
                table: "Vehicle",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "Vehicle",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "Vehicle",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "Vehicle",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "User",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "Status",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "Status",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "PictureGroup",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "PictureGroup",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "maintenanceId",
                table: "MaintenanceHistory",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "MaintenanceHistory",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "MaintenanceHistory",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "actionTypeId",
                table: "MaintenanceHistory",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "Maintenance",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "Maintenance",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdBy",
                table: "ActionType",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createDate",
                table: "ActionType",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ActionType_User_createdBy",
                table: "ActionType",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_User_createdBy",
                table: "Maintenance",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceHistory_ActionType_actionTypeId",
                table: "MaintenanceHistory",
                column: "actionTypeId",
                principalTable: "ActionType",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceHistory_Maintenance_maintenanceId",
                table: "MaintenanceHistory",
                column: "maintenanceId",
                principalTable: "Maintenance",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceHistory_User_createdBy",
                table: "MaintenanceHistory",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PictureGroup_User_createdBy",
                table: "PictureGroup",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Status_User_createdBy",
                table: "Status",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_createdBy",
                table: "User",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_User_createdBy",
                table: "Vehicle",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_User_userId",
                table: "Vehicle",
                column: "userId",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleType_vehicleTypeId",
                table: "Vehicle",
                column: "vehicleTypeId",
                principalTable: "VehicleType",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleType_User_createdBy",
                table: "VehicleType",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
