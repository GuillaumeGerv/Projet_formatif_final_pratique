using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_formatif_final.DataAcess.Pivots
{
    public class RoleUtilisateurs
    {
        public int RoleId { get; set; }
        public int UtilisateurId { get; set; }
        public RoleUtilisateurs() { }
        public RoleUtilisateurs(int roleId, int utilisateurId)
        {
            this.RoleId = roleId;
            this.UtilisateurId = utilisateurId;
        }
    }
}
