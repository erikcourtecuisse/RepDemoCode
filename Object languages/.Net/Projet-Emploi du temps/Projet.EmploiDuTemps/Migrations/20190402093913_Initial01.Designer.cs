﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projet.EmploiDuTemps.Data;

namespace Projet.EmploiDuTemps.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190402093913_Initial01")]
    partial class Initial01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Projet.EmploiDuTemps.Models.Batiment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomBatiment");

                    b.HasKey("ID");

                    b.ToTable("Batiment");
                });

            modelBuilder.Entity("Projet.EmploiDuTemps.Models.Enseignant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom");

                    b.Property<string>("Prenom");

                    b.HasKey("ID");

                    b.ToTable("Enseignant");
                });

            modelBuilder.Entity("Projet.EmploiDuTemps.Models.Enseignement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupeID");

                    b.Property<int>("UEID");

                    b.HasKey("ID");

                    b.HasIndex("GroupeID");

                    b.HasIndex("UEID");

                    b.ToTable("Enseignement");
                });

            modelBuilder.Entity("Projet.EmploiDuTemps.Models.Groupe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LUEID");

                    b.Property<string>("NomGroupe");

                    b.HasKey("ID");

                    b.HasIndex("LUEID");

                    b.ToTable("Groupe");
                });

            modelBuilder.Entity("Projet.EmploiDuTemps.Models.Salle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BatimentID");

                    b.Property<string>("NomSalle");

                    b.HasKey("ID");

                    b.HasIndex("BatimentID");

                    b.ToTable("Salle");
                });

            modelBuilder.Entity("Projet.EmploiDuTemps.Models.Seance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Duree");

                    b.Property<int>("EnseignantID");

                    b.Property<int>("EnseignementID");

                    b.Property<int>("HeureDebut");

                    b.Property<DateTime>("Jour");

                    b.Property<int?>("LUEID");

                    b.Property<int?>("LeGroupeID");

                    b.Property<int>("NumeroSemaine");

                    b.Property<string>("Remarque");

                    b.Property<int>("SalleID");

                    b.Property<int>("TypeSeanceID");

                    b.HasKey("ID");

                    b.HasIndex("EnseignantID");

                    b.HasIndex("EnseignementID");

                    b.HasIndex("LUEID");

                    b.HasIndex("LeGroupeID");

                    b.HasIndex("SalleID");

                    b.HasIndex("TypeSeanceID");

                    b.ToTable("Seance");
                });

            modelBuilder.Entity("Projet.EmploiDuTemps.Models.TypeSeance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Intitule");

                    b.HasKey("ID");

                    b.ToTable("TypeSeance");
                });

            modelBuilder.Entity("Projet.EmploiDuTemps.Models.UE", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Intitule");

                    b.Property<string>("Numero");

                    b.HasKey("ID");

                    b.ToTable("UE");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Projet.EmploiDuTemps.Models.Enseignement", b =>
                {
                    b.HasOne("Projet.EmploiDuTemps.Models.Groupe", "Groupe")
                        .WithMany()
                        .HasForeignKey("GroupeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Projet.EmploiDuTemps.Models.UE", "UE")
                        .WithMany()
                        .HasForeignKey("UEID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Projet.EmploiDuTemps.Models.Groupe", b =>
                {
                    b.HasOne("Projet.EmploiDuTemps.Models.UE", "LUE")
                        .WithMany("LesGroupes")
                        .HasForeignKey("LUEID");
                });

            modelBuilder.Entity("Projet.EmploiDuTemps.Models.Salle", b =>
                {
                    b.HasOne("Projet.EmploiDuTemps.Models.Batiment", "Batiment")
                        .WithMany("LesSalles")
                        .HasForeignKey("BatimentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Projet.EmploiDuTemps.Models.Seance", b =>
                {
                    b.HasOne("Projet.EmploiDuTemps.Models.Enseignant", "Enseignant")
                        .WithMany()
                        .HasForeignKey("EnseignantID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Projet.EmploiDuTemps.Models.Enseignement", "Enseignement")
                        .WithMany()
                        .HasForeignKey("EnseignementID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Projet.EmploiDuTemps.Models.UE", "LUE")
                        .WithMany("LesSeances")
                        .HasForeignKey("LUEID");

                    b.HasOne("Projet.EmploiDuTemps.Models.Groupe", "LeGroupe")
                        .WithMany("LesSeances")
                        .HasForeignKey("LeGroupeID");

                    b.HasOne("Projet.EmploiDuTemps.Models.Salle", "Salle")
                        .WithMany()
                        .HasForeignKey("SalleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Projet.EmploiDuTemps.Models.TypeSeance", "TypeSeance")
                        .WithMany("LesSeances")
                        .HasForeignKey("TypeSeanceID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
