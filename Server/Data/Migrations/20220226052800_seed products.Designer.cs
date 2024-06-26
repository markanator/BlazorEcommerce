﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220226052800_seed products")]
    partial class seedproducts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                            ImageUrl = "https://th.bing.com/th/id/OIP.sZidizqnhAyTX0Tnx1i4ywHaKj?w=208&h=297&c=7&r=0&o=5&dpr=1.25&pid=1.7",
                            Price = 12.99m,
                            Title = "The Hitchhiker's Guide to the Galaxy, v1.1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline.",
                            ImageUrl = "https://th.bing.com/th/id/R.7a2446a678be4698c510c698d3386ea4?rik=rPXgM6tmXc6p8Q&pid=ImgRaw&r=0",
                            Price = 29.99m,
                            Title = "Ready Player One, v1.1"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.",
                            ImageUrl = "https://th.bing.com/th/id/OIP.QZQQcihFq4QJ28fXUzQskgDJE1?w=201&h=309&c=7&r=0&o=5&dpr=1.25&pid=1.7",
                            Price = 9.99m,
                            Title = "1984, v1.1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
