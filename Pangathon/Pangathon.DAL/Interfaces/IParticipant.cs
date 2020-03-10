using Pangathon.DAL.Entities;
using System;

namespace Pangathon.DAL.Interfaces
{
    public interface IParticipant
    {
        Guid IdTache { get; set; }
        Tache Tache { get; set; }
        Guid IdUtilisateur { get; set; }
        Utilisateur Utilisateur { get; set; }
    }
}
