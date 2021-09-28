﻿// <auto-generated />
using JetCommerceApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JetCommerceApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JetCommerceApi.Cart", b =>
                {
                    b.Property<int>("idItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idProduto")
                        .HasColumnType("int");

                    b.Property<int>("quantidadeProduto")
                        .HasColumnType("int");

                    b.Property<double>("valorProduto")
                        .HasColumnType("float");

                    b.HasKey("idItem");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("JetCommerceApi.Produto", b =>
                {
                    b.Property<int>("idProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nomeProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("valorProduto")
                        .HasColumnType("float");

                    b.HasKey("idProduto");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
