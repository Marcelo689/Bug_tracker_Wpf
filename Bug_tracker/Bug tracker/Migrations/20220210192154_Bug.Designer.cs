﻿// <auto-generated />
using Bug_tracker.Conexao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bug_tracker.Migrations
{
    [DbContext(typeof(DB))]
    [Migration("20220210192154_Bug")]
    partial class Bug
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Bug_tracker.Model.Bug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Autor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Comentario")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Prioridade")
                        .HasColumnType("int");

                    b.Property<string>("Tela")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Versao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Bug");
                });
#pragma warning restore 612, 618
        }
    }
}
