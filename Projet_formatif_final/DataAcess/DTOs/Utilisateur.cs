using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_formatif_final.DataAcess.DTOs;

public class Utilisateur
{
    public const int MAX_USERNAME_LENGTH = 48;
    public const int MAX_PASSWORD_LENGTH = 32;
    public int Id { get; set; }
    public string? NomUtilisateur { get; set; }
    public string? MotDePasse { get; set; }
    public byte[] Version { get; set; }

    public virtual List<Role> Roles { get; set; }

    public Utilisateur()
    {

    }
    public Utilisateur(int id, string nomUtilisateur, string motDePasse, byte[] version) {
        this.Id = id;
        this.NomUtilisateur = nomUtilisateur;
        this.MotDePasse = motDePasse;
        this.Version = version;
    }
    public override string ToString()
    {
        return this.Id.ToString() + " - " + this.NomUtilisateur;
    }
}
