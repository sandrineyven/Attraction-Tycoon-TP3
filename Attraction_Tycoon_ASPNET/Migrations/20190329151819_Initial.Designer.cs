﻿// <auto-generated />
using Attraction_Tycoon_ASPNET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Attraction_Tycoon_ASPNET.Migrations
{
    [DbContext(typeof(Attraction_Tycoon_ASPNETContext))]
    [Migration("20190329151819_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Attraction_Tycoon_ASPNET.Models.Carousel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("capacity");

                    b.Property<int>("duration");

                    b.Property<bool>("is_open");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<string>("state");

                    b.Property<string>("type")
                        .IsRequired();

                    b.Property<int>("waiting_time");

                    b.Property<int>("zone");

                    b.HasKey("id");

                    b.ToTable("Carousel");
                });
#pragma warning restore 612, 618
        }
    }
}
