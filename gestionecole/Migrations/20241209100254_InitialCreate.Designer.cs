﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace gestionecole.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241209100254_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("gestionecole.Models.Absences", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createat");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updateat");

                    b.Property<int>("coursId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("etudiantId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("coursId");

                    b.HasIndex("etudiantId");

                    b.ToTable("absences");
                });

            modelBuilder.Entity("gestionecole.Models.Classe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createat");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updateat");

                    b.Property<string>("libelle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("niveau")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("classe");
                });

            modelBuilder.Entity("gestionecole.Models.Cours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClasseId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createat");

                    b.Property<DateTime?>("NbreHoraire")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ProfesseurId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updateat");

                    b.Property<DateTime?>("datedebut")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("datefin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("module")
                        .HasColumnType("integer");

                    b.Property<int>("semestre")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClasseId");

                    b.HasIndex("ProfesseurId");

                    b.ToTable("cours");
                });

            modelBuilder.Entity("gestionecole.Models.DetailCours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createat");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updateat");

                    b.Property<int>("classeId")
                        .HasColumnType("integer");

                    b.Property<int>("coursId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("classeId");

                    b.HasIndex("coursId");

                    b.ToTable("detailsCours");
                });

            modelBuilder.Entity("gestionecole.Models.Etudiant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createat");

                    b.Property<string>("Matricule")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updateat");

                    b.Property<string>("addresse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("classeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("classeId");

                    b.ToTable("etudiant");
                });

            modelBuilder.Entity("gestionecole.Models.Professeur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createat");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updateat");

                    b.Property<string>("grade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("specialite")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("professeur");
                });

            modelBuilder.Entity("gestionecole.Models.Absences", b =>
                {
                    b.HasOne("gestionecole.Models.Cours", "cours")
                        .WithMany()
                        .HasForeignKey("coursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gestionecole.Models.Etudiant", "etudiant")
                        .WithMany()
                        .HasForeignKey("etudiantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cours");

                    b.Navigation("etudiant");
                });

            modelBuilder.Entity("gestionecole.Models.Cours", b =>
                {
                    b.HasOne("gestionecole.Models.Classe", "Classe")
                        .WithMany("detailCours")
                        .HasForeignKey("ClasseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gestionecole.Models.Professeur", "Professeur")
                        .WithMany("classes")
                        .HasForeignKey("ProfesseurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classe");

                    b.Navigation("Professeur");
                });

            modelBuilder.Entity("gestionecole.Models.DetailCours", b =>
                {
                    b.HasOne("gestionecole.Models.Classe", "classe")
                        .WithMany()
                        .HasForeignKey("classeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gestionecole.Models.Cours", "cours")
                        .WithMany("detailCours")
                        .HasForeignKey("coursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("classe");

                    b.Navigation("cours");
                });

            modelBuilder.Entity("gestionecole.Models.Etudiant", b =>
                {
                    b.HasOne("gestionecole.Models.Classe", "classe")
                        .WithMany()
                        .HasForeignKey("classeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("classe");
                });

            modelBuilder.Entity("gestionecole.Models.Classe", b =>
                {
                    b.Navigation("detailCours");
                });

            modelBuilder.Entity("gestionecole.Models.Cours", b =>
                {
                    b.Navigation("detailCours");
                });

            modelBuilder.Entity("gestionecole.Models.Professeur", b =>
                {
                    b.Navigation("classes");
                });
#pragma warning restore 612, 618
        }
    }
}
