using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NetlogProject.Entity.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActionType",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PictureGroup",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pictureImage = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PictureGroup", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firstName = table.Column<string>(type: "text", nullable: true),
                    lastName = table.Column<string>(type: "text", nullable: true),
                    phoneNumber = table.Column<string>(type: "text", nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    profilePicture = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleType",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    createDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    createdBy = table.Column<int>(type: "integer", nullable: false),
                    modifyDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    modifiedBy = table.Column<int>(type: "integer", nullable: false),
                    isDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.id);
                    table.ForeignKey(
                        name: "FK_Status_User_createdBy",
                        column: x => x.createdBy,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Status_User_modifiedBy",
                        column: x => x.modifiedBy,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    plateNo = table.Column<string>(type: "text", nullable: true),
                    vehicleTypeId = table.Column<int>(type: "integer", nullable: false),
                    userId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vehicle_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleType_vehicleTypeId",
                        column: x => x.vehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Maintenance",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vehicleId = table.Column<int>(type: "integer", nullable: false),
                    userId = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    pictureGroupId = table.Column<int>(type: "integer", nullable: false),
                    expectedTimeToFix = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    responsibleUserId = table.Column<int>(type: "integer", nullable: false),
                    locationLongitude = table.Column<string>(type: "text", nullable: true),
                    locationLatitude = table.Column<string>(type: "text", nullable: true),
                    statusId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenance", x => x.id);
                    table.ForeignKey(
                        name: "FK_Maintenance_PictureGroup_pictureGroupId",
                        column: x => x.pictureGroupId,
                        principalTable: "PictureGroup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Maintenance_Status_statusId",
                        column: x => x.statusId,
                        principalTable: "Status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Maintenance_User_responsibleUserId",
                        column: x => x.responsibleUserId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Maintenance_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Maintenance_Vehicle_vehicleId",
                        column: x => x.vehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceHistory",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    maintenanceId = table.Column<int>(type: "integer", nullable: false),
                    actionTypeId = table.Column<int>(type: "integer", nullable: false),
                    text = table.Column<string>(type: "text", nullable: true),
                    createDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    createdBy = table.Column<int>(type: "integer", nullable: false),
                    modifyDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    modifiedBy = table.Column<int>(type: "integer", nullable: false),
                    isDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceHistory", x => x.id);
                    table.ForeignKey(
                        name: "FK_MaintenanceHistory_ActionType_actionTypeId",
                        column: x => x.actionTypeId,
                        principalTable: "ActionType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaintenanceHistory_Maintenance_maintenanceId",
                        column: x => x.maintenanceId,
                        principalTable: "Maintenance",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaintenanceHistory_User_createdBy",
                        column: x => x.createdBy,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaintenanceHistory_User_modifiedBy",
                        column: x => x.modifiedBy,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_pictureGroupId",
                table: "Maintenance",
                column: "pictureGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_responsibleUserId",
                table: "Maintenance",
                column: "responsibleUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_statusId",
                table: "Maintenance",
                column: "statusId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_userId",
                table: "Maintenance",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_vehicleId",
                table: "Maintenance",
                column: "vehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceHistory_actionTypeId",
                table: "MaintenanceHistory",
                column: "actionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceHistory_createdBy",
                table: "MaintenanceHistory",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceHistory_maintenanceId",
                table: "MaintenanceHistory",
                column: "maintenanceId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceHistory_modifiedBy",
                table: "MaintenanceHistory",
                column: "modifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Status_createdBy",
                table: "Status",
                column: "createdBy");

            migrationBuilder.CreateIndex(
                name: "IX_Status_modifiedBy",
                table: "Status",
                column: "modifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_userId",
                table: "Vehicle",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_vehicleTypeId",
                table: "Vehicle",
                column: "vehicleTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaintenanceHistory");

            migrationBuilder.DropTable(
                name: "ActionType");

            migrationBuilder.DropTable(
                name: "Maintenance");

            migrationBuilder.DropTable(
                name: "PictureGroup");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "VehicleType");
        }
    }
}
