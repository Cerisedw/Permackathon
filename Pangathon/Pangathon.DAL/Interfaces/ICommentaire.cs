using Pangathon.DAL.Entities;
using System;

namespace Pangathon.DAL.Interfaces
{
    public interface ICommentaire<TIdType> : IEntity<TIdType>
    {
        DateTime DateCreation { get; set; }
        string Contenu { get; set; }
        Tache Tache { get; set; }
        Utilisateur Utilisateur { get; set; }
    }
}
