using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilisateur.DAL.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int Promo { get; set; }
        public string MotDePasse { get; set; }
        public int Age { get; set; }
        public string Ecole { get; set; }
        public string Discipline { get; set; }

        public Utilisateur()
        {
            Nom = "";
            Prenom = "";
            Email = "";
            Promo = 0;
            MotDePasse = "";
            Age = 0;
            Ecole = "";
            Discipline = "";
        }
    }
}
