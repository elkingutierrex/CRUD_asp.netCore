﻿// <auto-generated />
using Asp.netCoreMVCCRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Asp.netCoreMVCCRUD.Migrations
{
    [DbContext(typeof(ClienteContext))]
    partial class ClienteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Asp.netCoreMVCCRUD.Models.Cliente", b =>
                {
                    b.Property<int>("id_cliente")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("departamento")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("nombre_cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("pais")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("tipo_cliente")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id_cliente");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}