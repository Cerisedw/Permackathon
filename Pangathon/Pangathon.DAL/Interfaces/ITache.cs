using System;

namespace Pangathon.DAL.Interfaces
{
    public interface ITache<TIdType> : IEntity<TIdType>
    {
        string Nom { get; set; }
        string Description { get; set; }
        DateTime DateCreation { get; set; }
        DateTime DateDeadline { get; set; }
        IUtilisateur<Guid> Createur { get; set; }
        IPriorite<Guid> Priorite { get; set; }
        IStatut<Guid> Statut { get; set; }
        IEntreprise<Guid> Entreprise { get; set; }
        IType<Guid> Type { get; set; }
    }
}
