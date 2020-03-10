using Pangathon.DAL.Interfaces;
using System;

namespace Pangathon.DAL.Entities
{
    public class Utilisateur : IUtilisateur<Guid>
    {
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string Telephone { get; set; }
        public IEntreprise Entreprise { get; set; }
        public IPoste Poste { get; set; }
    }
}
