using Microsoft.Identity.Client;
using Projet_formatif_final.DataAcess.Context;
using Projet_formatif_final.DataAcess.DAOs;
using Projet_formatif_final.DataAcess.DTOs;
using Projet_formatif_final.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_formatif_final.Business
{
    internal class FinalFormatifApp
    {
        private AppDbContext context;
        private UtilisateurDAO utilisateurDAO;
        private RoleDAO roleDAO;
        private MainMenu mainMenu;
        private UserManagementForm userForm;
        public FinalFormatifApp() {
            ApplicationConfiguration.Initialize();
            this.context = new AppDbContext();
            this.utilisateurDAO = new UtilisateurDAO(this.context);
            this.roleDAO = new RoleDAO(this.context);
            this.mainMenu = new MainMenu(this);
            this.userForm = new UserManagementForm(this);
        }

        public void Start() {
            Application.Run(this.mainMenu);
        }
        public void Terminate() {
            Application.Exit();
        }

        public List<Utilisateur> GetAllUtilisateur() {
            return this.utilisateurDAO.GetAll();
        }

        public Utilisateur? DeleteUser(Utilisateur user) {
            DialogResult resultat = this.userForm.OpenForDelete(user);
            if (resultat == DialogResult.OK)
            {
                _ = this.utilisateurDAO.Delete(user);
                return user;
            }
            else
            {
                return null;
            }

        }
        public Utilisateur? CreateNewUser() {
            Utilisateur newUser = new Utilisateur();
            DialogResult resultat = this.userForm.OpenForCreate(newUser);
            if (resultat == DialogResult.OK)
            {
                _ = this.utilisateurDAO.Create(newUser);
                return newUser;
            }
            else {
                return null;
            }        
        }
        public List<Role> GetAllRoles() { 
            return this.roleDAO.GetAll();
        }
        public Utilisateur ViewUserDetails(Utilisateur user) {
            _ = this.userForm.OpenForView(user);
            return user;
        }

        public Utilisateur EditUser(Utilisateur user) {
            DialogResult resultat = this.userForm.OpenForEdit(user);
            if (resultat == DialogResult.OK)
            {
                _ = this.utilisateurDAO.Update(user);
                return user;
            }
            else
            {
                return user;
            }
        }
    }
}
