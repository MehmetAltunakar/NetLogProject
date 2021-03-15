using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetlogProject.Entity.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "createDate",
                table: "VehicleType",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "createdBy",
                table: "VehicleType",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "VehicleType",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "modifiedBy",
                table: "VehicleType",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifyDate",
                table: "VehicleType",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createDate",
                table: "Vehicle",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "createdBy",
                table: "Vehicle",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Vehicle",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "modifiedBy",
                table: "Vehicle",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifyDate",
                table: "Vehicle",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createDate",
                table: "User",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "createdBy",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "User",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "modifiedBy",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifyDate",
                table: "User",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createDate",
                table: "PictureGroup",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "createdBy",
                table: "PictureGroup",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "PictureGroup",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "modifiedBy",
                table: "PictureGroup",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifyDate",
                table: "PictureGroup",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createDate",
                table: "Maintenance",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "createdBy",
                table: "Maintenance",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Maintenance",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "modifiedBy",
                table: "Maintenance",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifyDate",
                table: "Maintenance",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createDate",
                table: "ActionType",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "createdBy",
                table: "ActionType",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "ActionType",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "modifiedBy",
                table: "ActionType",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "modifyDate",
                table: "ActionType",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_VehicleType_createdBy",
                table: "VehicleType",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleType_modifiedBy",
                table: "VehicleType",
                column: "modifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_createdBy",
                table: "Vehicle",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_modifiedBy",
                table: "Vehicle",
                column: "modifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_User_createdBy",
                table: "User",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_User_modifiedBy",
                table: "User",
                column: "modifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PictureGroup_createdBy",
                table: "PictureGroup",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_PictureGroup_modifiedBy",
                table: "PictureGroup",
                column: "modifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_createdBy",
                table: "Maintenance",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_modifiedBy",
                table: "Maintenance",
                column: "modifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ActionType_createdBy",
                table: "ActionType",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_ActionType_modifiedBy",
                table: "ActionType",
                column: "modifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_ActionType_User_createdBy",
                table: "ActionType",
                column: "createdBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActionType_User_modifiedBy",
                table: "ActionType",
                column: "modifiedBy",
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
                name: "FK_Maintenance_User_modifiedBy",
                table: "Maintenance",
                column: "modifiedBy",
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
                name: "FK_PictureGroup_User_modifiedBy",
                table: "PictureGroup",
                column: "modifiedBy",
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
                name: "FK_User_User_modifiedBy",
                table: "User",
                column: "modifiedBy",
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
                name: "FK_Vehicle_User_modifiedBy",
                table: "Vehicle",
                column: "modifiedBy",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleType_User_createdBy",
                table: "VehicleType",
                column: "createdBy",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActionType_User_createdBy",
                table: "ActionType");

            migrationBuilder.DropForeignKey(
                name: "FK_ActionType_User_modifiedBy",
                table: "ActionType");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_User_createdBy",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_User_modifiedBy",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_PictureGroup_User_createdBy",
                table: "PictureGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_PictureGroup_User_modifiedBy",
                table: "PictureGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_createdBy",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_modifiedBy",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_createdBy",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_modifiedBy",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleType_User_createdBy",
                table: "VehicleType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleType_User_modifiedBy",
                table: "VehicleType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleType_createdBy",
                table: "VehicleType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleType_modifiedBy",
                table: "VehicleType");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_createdBy",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_modifiedBy",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_User_createdBy",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_modifiedBy",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_PictureGroup_createdBy",
                table: "PictureGroup");

            migrationBuilder.DropIndex(
                name: "IX_PictureGroup_modifiedBy",
                table: "PictureGroup");

            migrationBuilder.DropIndex(
                name: "IX_Maintenance_createdBy",
                table: "Maintenance");

            migrationBuilder.DropIndex(
                name: "IX_Maintenance_modifiedBy",
                table: "Maintenance");

            migrationBuilder.DropIndex(
                name: "IX_ActionType_createdBy",
                table: "ActionType");

            migrationBuilder.DropIndex(
                name: "IX_ActionType_modifiedBy",
                table: "ActionType");

            migrationBuilder.DropColumn(
                name: "createDate",
                table: "VehicleType");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "VehicleType");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "VehicleType");

            migrationBuilder.DropColumn(
                name: "modifiedBy",
                table: "VehicleType");

            migrationBuilder.DropColumn(
                name: "modifyDate",
                table: "VehicleType");

            migrationBuilder.DropColumn(
                name: "createDate",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "modifiedBy",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "modifyDate",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "createDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "User");

            migrationBuilder.DropColumn(
                name: "modifiedBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "modifyDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "createDate",
                table: "PictureGroup");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "PictureGroup");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "PictureGroup");

            migrationBuilder.DropColumn(
                name: "modifiedBy",
                table: "PictureGroup");

            migrationBuilder.DropColumn(
                name: "modifyDate",
                table: "PictureGroup");

            migrationBuilder.DropColumn(
                name: "createDate",
                table: "Maintenance");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "Maintenance");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Maintenance");

            migrationBuilder.DropColumn(
                name: "modifiedBy",
                table: "Maintenance");

            migrationBuilder.DropColumn(
                name: "modifyDate",
                table: "Maintenance");

            migrationBuilder.DropColumn(
                name: "createDate",
                table: "ActionType");

            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "ActionType");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "ActionType");

            migrationBuilder.DropColumn(
                name: "modifiedBy",
                table: "ActionType");

            migrationBuilder.DropColumn(
                name: "modifyDate",
                table: "ActionType");
        }
    }
}
