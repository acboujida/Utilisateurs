using static System.Formats.Asn1.AsnWriter;

namespace Utilisateur.DTO
{
    public class UtilisateurDTO
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
        public UtilisateurDTO()
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
        public UtilisateurDTO(string nom, string prenom, string email, int promo, string motDePasse, int age, string ecole, string discipline)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Promo = promo;
            MotDePasse = motDePasse;
            Age = age;
            Ecole = ecole;
            Discipline = discipline;
        }
    }
}