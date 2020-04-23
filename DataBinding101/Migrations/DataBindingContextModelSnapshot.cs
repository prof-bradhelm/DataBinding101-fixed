﻿// <auto-generated />
using System;
using DataBinding101.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataBinding101.Migrations
{
    [DbContext(typeof(DataBindingContext))]
    partial class DataBindingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("DataBinding101.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Charisma")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Constitution")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Dexterity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Intelligence")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Strength")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Wisdom")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("DataBinding101.Models.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("OwnerCharacterId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EquipmentId");

                    b.HasIndex("OwnerCharacterId");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("DataBinding101.Models.Equipment", b =>
                {
                    b.HasOne("DataBinding101.Models.Character", "Owner")
                        .WithMany("Equipment")
                        .HasForeignKey("OwnerCharacterId");
                });
#pragma warning restore 612, 618
        }
    }
}
