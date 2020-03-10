using System;
using System.Collections.Generic;
using System.Text;

namespace Pangathon.DAL.Interfaces
{
    public interface ICommentaire<TIdType> : IEntity<TIdType>
    {
        DateTime dateCreation { get; set; }
        string Contenu { get; set; }
        ITache<Guid> Tache { get; set; }
        IUtilisateur<Guid> Utilisateur { get; set; }
    }
}
