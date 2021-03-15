﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetlogProject.Entity;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NetlogProject.Entity.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.ActionType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("createDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("createdBy")
                        .HasColumnType("integer");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.Property<int?>("modifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("modifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("createdBy");

                    b.HasIndex("modifiedBy");

                    b.ToTable("ActionType");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.Maintenance", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("createDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("createdBy")
                        .HasColumnType("integer");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<DateTime?>("expectedTimeToFix")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("locationLatitude")
                        .HasColumnType("text");

                    b.Property<string>("locationLongitude")
                        .HasColumnType("text");

                    b.Property<int?>("modifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("modifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("pictureGroupId")
                        .HasColumnType("integer");

                    b.Property<int?>("responsibleUserId")
                        .HasColumnType("integer");

                    b.Property<int?>("statusId")
                        .HasColumnType("integer");

                    b.Property<int?>("userId")
                        .HasColumnType("integer");

                    b.Property<int?>("vehicleId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("createdBy");

                    b.HasIndex("modifiedBy");

                    b.HasIndex("pictureGroupId");

                    b.HasIndex("responsibleUserId");

                    b.HasIndex("statusId");

                    b.HasIndex("userId");

                    b.HasIndex("vehicleId");

                    b.ToTable("Maintenance");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.MaintenanceHistory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("actionTypeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("createdBy")
                        .HasColumnType("integer");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("maintenanceId")
                        .HasColumnType("integer");

                    b.Property<int?>("modifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("modifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("text")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("actionTypeId");

                    b.HasIndex("createdBy");

                    b.HasIndex("maintenanceId");

                    b.HasIndex("modifiedBy");

                    b.ToTable("MaintenanceHistory");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.PictureGroup", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("createDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("createdBy")
                        .HasColumnType("integer");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.Property<int?>("modifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("modifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("pictureImage")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("createdBy");

                    b.HasIndex("modifiedBy");

                    b.ToTable("PictureGroup");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.Status", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("createDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("createdBy")
                        .HasColumnType("integer");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.Property<int?>("modifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("modifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("createdBy");

                    b.HasIndex("modifiedBy");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("address")
                        .HasColumnType("text");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("createdBy")
                        .HasColumnType("integer");

                    b.Property<string>("firstName")
                        .HasColumnType("text");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("lastName")
                        .HasColumnType("text");

                    b.Property<int?>("modifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("modifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("profilePicture")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("createdBy");

                    b.HasIndex("modifiedBy");

                    b.ToTable("User");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.Vehicle", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("createDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("createdBy")
                        .HasColumnType("integer");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.Property<int?>("modifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("modifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("plateNo")
                        .HasColumnType("text");

                    b.Property<int>("userId")
                        .HasColumnType("integer");

                    b.Property<int>("vehicleTypeId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("createdBy");

                    b.HasIndex("modifiedBy");

                    b.HasIndex("userId");

                    b.HasIndex("vehicleTypeId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.VehicleType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("createDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("createdBy")
                        .HasColumnType("integer");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.Property<int?>("modifiedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("modifyDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("createdBy");

                    b.HasIndex("modifiedBy");

                    b.ToTable("VehicleType");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.ActionType", b =>
                {
                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "createdUser")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "modifiedUser")
                        .WithMany()
                        .HasForeignKey("modifiedBy");

                    b.Navigation("createdUser");

                    b.Navigation("modifiedUser");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.Maintenance", b =>
                {
                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "createdUser")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "modifiedUser")
                        .WithMany()
                        .HasForeignKey("modifiedBy");

                    b.HasOne("EFCoreNetlogProject.Entity.Model.PictureGroup", "pictureGroup")
                        .WithMany("maintenances")
                        .HasForeignKey("pictureGroupId");

                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "responsibleUser")
                        .WithMany()
                        .HasForeignKey("responsibleUserId");

                    b.HasOne("EFCoreNetlogProject.Entity.Model.Status", "status")
                        .WithMany("maintenances")
                        .HasForeignKey("statusId");

                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");

                    b.HasOne("EFCoreNetlogProject.Entity.Model.Vehicle", "vehicle")
                        .WithMany("maintenances")
                        .HasForeignKey("vehicleId");

                    b.Navigation("createdUser");

                    b.Navigation("modifiedUser");

                    b.Navigation("pictureGroup");

                    b.Navigation("responsibleUser");

                    b.Navigation("status");

                    b.Navigation("user");

                    b.Navigation("vehicle");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.MaintenanceHistory", b =>
                {
                    b.HasOne("EFCoreNetlogProject.Entity.Model.ActionType", "actionType")
                        .WithMany("maintenanceHistories")
                        .HasForeignKey("actionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "createdUser")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreNetlogProject.Entity.Model.Maintenance", "maintenance")
                        .WithMany("maintenanceHistories")
                        .HasForeignKey("maintenanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "modifiedUser")
                        .WithMany()
                        .HasForeignKey("modifiedBy");

                    b.Navigation("actionType");

                    b.Navigation("createdUser");

                    b.Navigation("maintenance");

                    b.Navigation("modifiedUser");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.PictureGroup", b =>
                {
                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "createdUser")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "modifiedUser")
                        .WithMany()
                        .HasForeignKey("modifiedBy");

                    b.Navigation("createdUser");

                    b.Navigation("modifiedUser");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.Status", b =>
                {
                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "createdUser")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "modifiedUser")
                        .WithMany()
                        .HasForeignKey("modifiedBy");

                    b.Navigation("createdUser");

                    b.Navigation("modifiedUser");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.User", b =>
                {
                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "createdUser")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "modifiedUser")
                        .WithMany()
                        .HasForeignKey("modifiedBy");

                    b.Navigation("createdUser");

                    b.Navigation("modifiedUser");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.Vehicle", b =>
                {
                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "createdUser")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "modifiedUser")
                        .WithMany()
                        .HasForeignKey("modifiedBy");

                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreNetlogProject.Entity.Model.VehicleType", "vehicleType")
                        .WithMany("vehicles")
                        .HasForeignKey("vehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("createdUser");

                    b.Navigation("modifiedUser");

                    b.Navigation("user");

                    b.Navigation("vehicleType");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.VehicleType", b =>
                {
                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "createdUser")
                        .WithMany()
                        .HasForeignKey("createdBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreNetlogProject.Entity.Model.User", "modifiedUser")
                        .WithMany()
                        .HasForeignKey("modifiedBy");

                    b.Navigation("createdUser");

                    b.Navigation("modifiedUser");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.ActionType", b =>
                {
                    b.Navigation("maintenanceHistories");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.Maintenance", b =>
                {
                    b.Navigation("maintenanceHistories");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.PictureGroup", b =>
                {
                    b.Navigation("maintenances");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.Status", b =>
                {
                    b.Navigation("maintenances");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.Vehicle", b =>
                {
                    b.Navigation("maintenances");
                });

            modelBuilder.Entity("EFCoreNetlogProject.Entity.Model.VehicleType", b =>
                {
                    b.Navigation("vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
