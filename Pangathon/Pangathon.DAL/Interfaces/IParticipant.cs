using System;
using System.Collections.Generic;
using System.Text;

namespace Pangathon.DAL.Interfaces
{
    public interface IParticipant<TIdType> : IEntity<TIdType>
    {
        ITache<Guid> Tache { get; set; }
        IUtilisateur<Guid> Utilisateur { get; set; }
    }
}
