using Pangathon.DAL.Entities;
using System;

namespace Pangathon.DAL.Interfaces
{
    public interface IParticipant
    {
        Guid TacheId { get; set; }
        Tache Tache { get; set; }
        Guid UtilisateurId { get; set; }
        Utilisateur Utilisateur { get; set; }
    }
}
