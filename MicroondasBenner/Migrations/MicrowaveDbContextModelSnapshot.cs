﻿// <auto-generated />
using MicroondasBenner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MicroondasBenner.Migrations
{
    [DbContext(typeof(MicrowaveDbContext))]
    partial class MicrowaveDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("MicroondasBenner.Models.CookModels", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alimento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Alteravel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Potencia")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Tempo")
                        .HasColumnType("TEXT");

                    b.Property<string>("instrucoes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("stringAquecimento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("CookModes");
                });
#pragma warning restore 612, 618
        }
    }
}
