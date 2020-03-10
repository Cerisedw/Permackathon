using System;

namespace Pangathon.DAL.Interfaces
{
    public interface IParticipant
    {
        Guid IdTache { get; set; }
        ITache<Guid> Tache { get; set; }
        Guid IdUtilisateur { get; set; }
        IUtilisateur<Guid> Utilisateur { get; set; }
    }
}
