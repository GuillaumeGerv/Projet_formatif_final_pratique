using Projet_formatif_final.DataAcess.Context;
using Projet_formatif_final.DataAcess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_formatif_final.DataAcess.DAOs
{
    internal class RoleDAO
    {
        private AppDbContext Context { get; set; }

        public RoleDAO(AppDbContext context)
        {
            Context = context;
        }   

        public List<Role> GetAll()
        {
            return this.Context.Roles.ToList();
        }
    }
}
