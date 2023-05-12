﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Data;

#nullable disable

namespace Server.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    [Migration("20230402124353_DeviceFixed")]
    partial class DeviceFixed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("Server.Models.Bill", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Month")
                        .HasColumnType("REAL");

                    b.Property<float>("Year")
                        .HasColumnType("REAL");

                    b.Property<float>("Consumption")
                        .HasColumnType("REAL");

                    b.Property<float>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("UserId", "Month", "Year");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Server.Models.ChargingScheduler", b =>
                {
                    b.Property<long>("DeviceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Day")
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.HasKey("DeviceId", "Day", "Time");

                    b.ToTable("ChargingSchedulers");
                });

            modelBuilder.Entity("Server.Models.Device", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Controlability")
                        .HasColumnType("INTEGER");

                    b.Property<long>("DeviceModelId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("EnergyInKwh")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<float>("StandByKwh")
                        .HasColumnType("REAL");

                    b.Property<bool>("TurnOn")
                        .HasColumnType("INTEGER");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Visibility")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DeviceModelId");

                    b.HasIndex("UserId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("Server.Models.DeviceEnergyUsage", b =>
                {
                    b.Property<long>("DeviceId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<float>("EnergyInKWh")
                        .HasColumnType("REAL");

                    b.HasKey("DeviceId", "StartTime", "EndTime");

                    b.ToTable("DeviceEnergyUsages");
                });

            modelBuilder.Entity("Server.Models.DropDowns.Devices.DeviceBrand", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DeviceBrands");
                });

            modelBuilder.Entity("Server.Models.DropDowns.Devices.DeviceCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DeviceCategories");
                });

            modelBuilder.Entity("Server.Models.DropDowns.Devices.DeviceModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("DeviceBrandId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("DeviceTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("EnergyKwh")
                        .HasColumnType("REAL");

                    b.Property<string>("Mark")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("StandByKwh")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("DeviceBrandId");

                    b.HasIndex("DeviceTypeId");

                    b.ToTable("DeviceModels");
                });

            modelBuilder.Entity("Server.Models.DropDowns.Devices.DeviceType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("DeviceTypes");
                });

            modelBuilder.Entity("Server.Models.DropDowns.Location.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CountryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Server.Models.DropDowns.Location.Country", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Server.Models.DropDowns.Location.Settlement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Settlements");
                });

            modelBuilder.Entity("Server.Models.InclusionScheduler", b =>
                {
                    b.Property<long>("DeviceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Day")
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("TurnOn")
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("TurnOff")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.HasKey("DeviceId", "Day", "TurnOn", "TurnOff");

                    b.ToTable("InclusionSchedulers");
                });

            modelBuilder.Entity("Server.Models.ResetPasswordModel", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ExpireAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResetKey")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("ResetPassword");
                });

            modelBuilder.Entity("Server.Models.RoleModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Server.Models.UserEnergyUsage", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<float?>("Consumption")
                        .HasColumnType("REAL");

                    b.Property<float?>("EnergyStock")
                        .HasColumnType("REAL");

                    b.Property<float?>("Production")
                        .HasColumnType("REAL");

                    b.HasKey("UserId", "Date");

                    b.ToTable("UserEnergyUsages");
                });

            modelBuilder.Entity("Server.Models.UserModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Blocked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Server.Models.Bill", b =>
                {
                    b.HasOne("Server.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Server.Models.ChargingScheduler", b =>
                {
                    b.HasOne("Server.Models.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
                });

            modelBuilder.Entity("Server.Models.Device", b =>
                {
                    b.HasOne("Server.Models.DropDowns.Devices.DeviceModel", "DeviceModel")
                        .WithMany()
                        .HasForeignKey("DeviceModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Server.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeviceModel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Server.Models.DeviceEnergyUsage", b =>
                {
                    b.HasOne("Server.Models.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
                });

            modelBuilder.Entity("Server.Models.DropDowns.Devices.DeviceModel", b =>
                {
                    b.HasOne("Server.Models.DropDowns.Devices.DeviceBrand", "DeviceBrand")
                        .WithMany()
                        .HasForeignKey("DeviceBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Server.Models.DropDowns.Devices.DeviceType", "DeviceType")
                        .WithMany()
                        .HasForeignKey("DeviceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeviceBrand");

                    b.Navigation("DeviceType");
                });

            modelBuilder.Entity("Server.Models.DropDowns.Devices.DeviceType", b =>
                {
                    b.HasOne("Server.Models.DropDowns.Devices.DeviceCategory", "DeviceCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeviceCategory");
                });

            modelBuilder.Entity("Server.Models.DropDowns.Location.City", b =>
                {
                    b.HasOne("Server.Models.DropDowns.Location.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Server.Models.DropDowns.Location.Settlement", b =>
                {
                    b.HasOne("Server.Models.DropDowns.Location.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Server.Models.InclusionScheduler", b =>
                {
                    b.HasOne("Server.Models.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
                });

            modelBuilder.Entity("Server.Models.ResetPasswordModel", b =>
                {
                    b.HasOne("Server.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Server.Models.UserEnergyUsage", b =>
                {
                    b.HasOne("Server.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Server.Models.UserModel", b =>
                {
                    b.HasOne("Server.Models.RoleModel", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
