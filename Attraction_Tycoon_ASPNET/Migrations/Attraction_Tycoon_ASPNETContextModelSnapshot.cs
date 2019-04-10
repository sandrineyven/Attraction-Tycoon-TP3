﻿// <auto-generated />
using System;
using Attraction_Tycoon_ASPNET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Attraction_Tycoon_ASPNET.Migrations
{
    [DbContext(typeof(Attraction_Tycoon_ASPNETContext))]
    partial class Attraction_Tycoon_ASPNETContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
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

            modelBuilder.Entity("Attraction_Tycoon_ASPNET.Models.Shop", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<string>("type")
                        .IsRequired();

                    b.Property<int>("zone");

                    b.HasKey("id");

                    b.ToTable("Shop");
                });

            modelBuilder.Entity("Attraction_Tycoon_ASPNET.Models.Staff", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("hours");

                    b.Property<int>("id_user");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<double>("salary");

                    b.Property<int?>("shopid");

                    b.Property<string>("status");

                    b.Property<string>("type")
                        .IsRequired();

                    b.HasKey("id");

                    b.HasIndex("shopid");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Attraction_Tycoon_ASPNET.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email");

                    b.Property<string>("login")
                        .IsRequired();

                    b.Property<string>("password");

                    b.HasKey("id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Attraction_Tycoon_ASPNET.Models.Zone", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Zone");
                });

            modelBuilder.Entity("Attraction_Tycoon_ASPNET.Models.Staff", b =>
                {
                    b.HasOne("Attraction_Tycoon_ASPNET.Models.Shop", "shop")
                        .WithMany("staffs")
                        .HasForeignKey("shopid");
                });
#pragma warning restore 612, 618
        }
    }
}
