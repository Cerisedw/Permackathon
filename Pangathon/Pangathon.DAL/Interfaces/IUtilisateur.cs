using Pangathon.DAL.Entities;
using System.Collections.Generic;

namespace Pangathon.DAL.Interfaces
{
    public interface IUtilisateur : IEntity
    {
        string Nom { get; set; }
        string Prenom { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string Image { get; set; }
        string Telephone { get; set; }
        Entreprise Entreprise { get; set; }
        Poste Poste { get; set; }
        List<UtilisateurRole> UtilisateurRoles { get; set; }
        List<Participant> Participations { get; set; }
    }
}
