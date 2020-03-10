using System;

namespace Pangathon.DAL.Interfaces
{
    public interface IUtilisateurRole<TIdType> : IEntity<TIdType>
    {
        IUtilisateur<Guid> Utilisateur { get; set; }
        IRole<Guid> Role { get; set; }
    }
}
