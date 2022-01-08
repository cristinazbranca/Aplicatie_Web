﻿// <auto-generated />
using Aplicatie_Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aplicatie_Web.Migrations
{
    [DbContext(typeof(Aplicatie_WebContext))]
    [Migration("20220105115155_Abonament")]
    partial class Abonament
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aplicatie_Web.Models.Abonament", b =>
                {
                    b.Property<int>("AbonamentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumeAbonament")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PretAbonament")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("ValabilitateAbonament")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AbonamentID");

                    b.ToTable("Abonament");
                });

            modelBuilder.Entity("Aplicatie_Web.Models.Clasa", b =>
                {
                    b.Property<int>("ClasaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Durata")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ora_inceperii")
                        .HasColumnType("int");

                    b.Property<string>("Program")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClasaID");

                    b.ToTable("Clasa");
                });
#pragma warning restore 612, 618
        }
    }
}
