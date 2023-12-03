using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_formatif_final.DataAcess.DTOs
{
    public class Role
    {
        public const int MAX_NAME_LENGTH = 64;
        public const int MAX_DESCRIPTION_LENGTH = 256;
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public byte[] Version { get; set; }


        public virtual List<Utilisateur> Utilisateurs { get; set; }

        public Role()
        {

        }
        public Role(int id, string nom, string description, byte[] version) {
            this.Id = id;
            this.Nom = nom;
            this.Description = description;
            this.Version = version;
        }
        public override string ToString()
        {
            return this.Id.ToString() + " - " + this.Nom;
        }
    }
}
