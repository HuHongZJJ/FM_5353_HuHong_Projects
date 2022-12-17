﻿// <auto-generated />
using System;
using HW6;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HW6db.Migrations
{
    [DbContext(typeof(OptionContext))]
    partial class OptionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HW6.Exchange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ExchangeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ExchangeSymbol")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Exchange");
                });

            modelBuilder.Entity("HW6.FutureEvaluation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EvaluationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("TradeId")
                        .HasColumnType("integer");

                    b.Property<double>("marketPrice")
                        .HasColumnType("double precision");

                    b.Property<double>("pnl")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("FutureEvaluation");
                });

            modelBuilder.Entity("HW6.Instrument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MarketId")
                        .HasColumnType("integer");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UnitId")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MarketId");

                    b.HasIndex("UnitId");

                    b.ToTable("Instrument");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("HW6.Market", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ExchangeId")
                        .HasColumnType("integer");

                    b.Property<string>("MarketName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ExchangeId");

                    b.ToTable("Market");
                });

            modelBuilder.Entity("HW6.OptionEvaluation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Delta")
                        .HasColumnType("double precision");

                    b.Property<double>("Gamma")
                        .HasColumnType("double precision");

                    b.Property<double>("Rho")
                        .HasColumnType("double precision");

                    b.Property<double>("StdErrorNorm")
                        .HasColumnType("double precision");

                    b.Property<double>("StdErrorReduce")
                        .HasColumnType("double precision");

                    b.Property<double>("Theta")
                        .HasColumnType("double precision");

                    b.Property<int>("TradeId")
                        .HasColumnType("integer");

                    b.Property<double>("Vega")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("dateEvl")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("optionId")
                        .HasColumnType("integer");

                    b.Property<double>("pnl")
                        .HasColumnType("double precision");

                    b.Property<double>("simulatePrice")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("optionId");

                    b.ToTable("OptionEvaluation");
                });

            modelBuilder.Entity("HW6.OptionProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("BarrierLevel")
                        .HasColumnType("double precision");

                    b.Property<bool>("IsCall")
                        .HasColumnType("boolean");

                    b.Property<string>("KnockType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OptionType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("PayOut")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("OptionProperty");
                });

            modelBuilder.Entity("HW6.RateCurve", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RateCurve");
                });

            modelBuilder.Entity("HW6.RatePoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Rate")
                        .HasColumnType("double precision");

                    b.Property<int>("RateCurveId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Term")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("RatePoint");
                });

            modelBuilder.Entity("HW6.Trade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("instrumentId")
                        .HasColumnType("integer");

                    b.Property<string>("instrumentType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("price")
                        .HasColumnType("double precision");

                    b.Property<int>("quantity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("tradeDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Trade");
                });

            modelBuilder.Entity("HW6.UnderlyingEvaluation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("TradeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("dateEvl")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("marketPrice")
                        .HasColumnType("double precision");

                    b.Property<double>("pnl")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("UnderlyingEvaluation");
                });

            modelBuilder.Entity("HW6.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<string>("UnitType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("HW6.Future", b =>
                {
                    b.HasBaseType("HW6.Instrument");

                    b.Property<DateTime>("Expirationdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UnderlyingId")
                        .HasColumnType("integer");

                    b.HasIndex("UnderlyingId");

                    b.ToTable("Future");
                });

            modelBuilder.Entity("HW6.Option", b =>
                {
                    b.HasBaseType("HW6.Instrument");

                    b.Property<DateTime>("Expirationdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("OPId")
                        .HasColumnType("integer");

                    b.Property<int>("UnderlyingId")
                        .HasColumnType("integer");

                    b.Property<double>("vol")
                        .HasColumnType("double precision");

                    b.HasIndex("OPId");

                    b.HasIndex("UnderlyingId");

                    b.ToTable("Option");
                });

            modelBuilder.Entity("HW6.Underlying", b =>
                {
                    b.HasBaseType("HW6.Instrument");

                    b.ToTable("Underlying");
                });

            modelBuilder.Entity("HW6.Instrument", b =>
                {
                    b.HasOne("HW6.Market", "Market")
                        .WithMany()
                        .HasForeignKey("MarketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HW6.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Market");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("HW6.Market", b =>
                {
                    b.HasOne("HW6.Exchange", "Exchange")
                        .WithMany()
                        .HasForeignKey("ExchangeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exchange");
                });

            modelBuilder.Entity("HW6.OptionEvaluation", b =>
                {
                    b.HasOne("HW6.Option", "option")
                        .WithMany()
                        .HasForeignKey("optionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("option");
                });

            modelBuilder.Entity("HW6.Future", b =>
                {
                    b.HasOne("HW6.Instrument", null)
                        .WithOne()
                        .HasForeignKey("HW6.Future", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HW6.Underlying", "Underlying")
                        .WithMany()
                        .HasForeignKey("UnderlyingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Underlying");
                });

            modelBuilder.Entity("HW6.Option", b =>
                {
                    b.HasOne("HW6.Instrument", null)
                        .WithOne()
                        .HasForeignKey("HW6.Option", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HW6.OptionProperty", "OP")
                        .WithMany()
                        .HasForeignKey("OPId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HW6.Underlying", "Underlying")
                        .WithMany()
                        .HasForeignKey("UnderlyingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OP");

                    b.Navigation("Underlying");
                });

            modelBuilder.Entity("HW6.Underlying", b =>
                {
                    b.HasOne("HW6.Instrument", null)
                        .WithOne()
                        .HasForeignKey("HW6.Underlying", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
