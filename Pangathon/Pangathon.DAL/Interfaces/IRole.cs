using Pangathon.DAL.Entities;
using System.Collections.Generic;

namespace Pangathon.DAL.Interfaces
{
    public interface IRole<TIdType> : IEntity<TIdType>
    {
        string Nom { get; set; }
        string Description { get; set; }
        List<UtilisateurRole> UtilisateurRoles { get; set; }
    }
}
