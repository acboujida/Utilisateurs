using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilisateur.DAL.Models;

namespace Utilisateur.DAL
{
    public class UtilisateurDBContext : DbContext
    {
        public UtilisateurDBContext(DbContextOptions<UtilisateurDBContext> options) : base(options) { }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
    }
}
