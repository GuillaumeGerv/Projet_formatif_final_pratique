using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Projet_formatif_final.DataAcess.Context;
using Projet_formatif_final.DataAcess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_formatif_final.DataAcess.DAOs
{
    internal class UtilisateurDAO
    {
        private AppDbContext Context { get; set; }

        public UtilisateurDAO(AppDbContext context)
        {
            Context = context;
        }

        public List<Utilisateur> GetAll() {
            return this.Context.Utilisateurs.Include(user => user.Roles).ToList();
        }

        public Utilisateur? GetById(int id) { 
            return this.Context?.Utilisateurs.Include(user => user.Roles).FirstOrDefault(x => x.Id == id);
        }
        public Utilisateur Create(Utilisateur utilisateur) {
            this.Context.Utilisateurs.Add(utilisateur);
            this.Context.SaveChanges();
            return utilisateur;
        }
        public Utilisateur Update(Utilisateur utilisateur)
        {
            this.Context.Utilisateurs.Update(utilisateur);
            this.Context.SaveChanges();
            return utilisateur;
        }
        public Utilisateur Delete(Utilisateur utilisateur)
        {
            this.Context.Utilisateurs.Remove(utilisateur);
            this.Context.SaveChanges();
            return utilisateur;
        }
    }
}
