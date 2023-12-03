using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Projet_formatif_final.DataAcess.DAOs;
using Projet_formatif_final.DataAcess.DTOs;
using Projet_formatif_final.DataAcess.Pivots;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_formatif_final.DataAcess.Context
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateurs { get; set; }

        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            _ = optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(ConfigurationManager.ConnectionStrings["Connexion"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            _ = modelBuilder.Entity<Utilisateur>()
                .ToTable("Utilisateurs")
                .HasKey(user => user.Id);

            _ = modelBuilder.Entity<Utilisateur>()
                .Property(user => user.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            _ = modelBuilder.Entity<Utilisateur>()
                .Property(user => user.NomUtilisateur)
                .HasColumnName("NomUtilisateur")
                .HasColumnType($"nvarchar({Utilisateur.MAX_USERNAME_LENGTH})");
            _ = modelBuilder.Entity<Utilisateur>()
                .Property(user => user.MotDePasse)
                .HasColumnName("MotDePasse")
                .HasColumnType($"nvarchar({Utilisateur.MAX_PASSWORD_LENGTH})");
            _ = modelBuilder.Entity<Utilisateur>()
                .Property(user => user.Version)
                .HasColumnName("Version")
                .IsRowVersion();

            _ = modelBuilder.Entity<Role>()
                .ToTable("Roles")
                .HasKey(role => role.Id);

            _ = modelBuilder.Entity<Role>()
                .Property(role => role.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            _ = modelBuilder.Entity<Role>()
                .Property(role => role.Nom)
                .HasColumnName("Nom")
                .HasColumnType($"nvarchar({Role.MAX_NAME_LENGTH})");
            _ = modelBuilder.Entity<Role>()
                .Property(role => role.Description)
                .HasColumnName("Description")
                .HasColumnType($"nvarchar({Role.MAX_DESCRIPTION_LENGTH})");
            _ = modelBuilder.Entity<Role>()
                .Property(role => role.Version)
                .HasColumnName("Version")
                .IsRowVersion();


            _ = modelBuilder.Entity<Utilisateur>()
                .HasMany(role => role.Roles)
                .WithMany(role => role.Utilisateurs)
                .UsingEntity<RoleUtilisateurs>().ToTable("RoleUtilisateurs")
                .HasKey(roleUser => new { roleUser.RoleId, roleUser.UtilisateurId} );


            _ = modelBuilder.Entity<Utilisateur>().HasData(
                new Utilisateur() { Id = 1, NomUtilisateur = "TestUser1", MotDePasse = "12345678" },
                new Utilisateur() { Id = 2, NomUtilisateur = "TestUser2", MotDePasse = "87654321" });

            _ = modelBuilder.Entity<Role>().HasData(
                new Role() { Id = 1, Nom = "Utilisateur", Description = "Utilisateur regulier" },
                new Role() { Id = 2, Nom = "Gestionnaire", Description = "Gestionnaire" },
                new Role() { Id = 3, Nom = "Administrateur", Description = "Administrateur Systeme" });

        }
    }
}
